﻿using Jupiter.Business.Core.Interface;using Jupiter.Business.Core.ModelMapper;using Jupiter.Business.Models;using Jupiter.Data.DataAccess.Core.Repositories;using Jupiter.Data.DataAccess.Core.UnitOfWork;using Jupiter.Data.DataAccess.Entity;using Jupiter.Data.DataAccess.Helper;using Jupiter.Utility;using Jupiter.Utility.Enums;//using Jupiter.Utility.Helpers;using Jupiter.Utility.Utility;using Microsoft.EntityFrameworkCore;using System.Data;using System.Data.SqlClient;using static Jupiter.Utility.Enums.GeneralEnum;namespace Jupiter.Business.Core.Implementation{    public class MasterUserService : IMasterUserService    {        private readonly IUnitOfWork _unitOfWork;        private readonly IMapperFactory _mapperFactory;
        private readonly IMasterNotificationService _notification;
        private readonly Microsoft.Extensions.Configuration.IConfiguration configuration;

        private IRepository<MasterUser> _repository { get; set; }        private IRepository<MasterAddress> _addressRepository { get; set; }        private IRepository<MasterQualification> _qualifyRepository { get; set; }        private IRepository<MasterDocument> _documentRepository { get; set; }        private IRepository<EmailLogHistory> _emailLog { get; set; }        private IRepository<MasterValuationRequestApproverLevel> _approverLevelRepository { get; set; }        private readonly IAuditLogService _auditLogService;        private readonly IHelper _helper;        private readonly int? _LoginUserId;        public MasterUserService(IUnitOfWork unitOfWork, IMapperFactory mapperFactory, IAuditLogService auditLogService,                                  IHelper helper, Microsoft.Extensions.Configuration.IConfiguration _configuration, IMasterNotificationService notification)        {            _unitOfWork = unitOfWork;            _mapperFactory = mapperFactory;            _emailLog = _unitOfWork.GetRepository<EmailLogHistory>();            _repository = _unitOfWork.GetRepository<MasterUser>();            _addressRepository = _unitOfWork.GetRepository<MasterAddress>();            _qualifyRepository = _unitOfWork.GetRepository<MasterQualification>();            _documentRepository = _unitOfWork.GetRepository<MasterDocument>();
            _approverLevelRepository = _unitOfWork.GetRepository<MasterValuationRequestApproverLevel>();            configuration = _configuration;            _helper = helper;
            _auditLogService = auditLogService;
            _notification = notification;
        }        public async Task<UserSessionEntity> Login(LoginViewModel oLogin)        {
            UserSessionEntity oUser = null;
            SqlParameter[] osqlParameter =            {                new SqlParameter("@Email", oLogin.Email),                new SqlParameter("@Password", UtilityHelper.GenerateSHA256String(oLogin.Password))            };            var UserList = await _repository.GetBySP("usp_User_VerifyUserLogin", System.Data.CommandType.StoredProcedure, osqlParameter);            if (UserList != null && UserList.Rows.Count > 0)            {                oUser = new UserSessionEntity();                oUser.UserName = UserList.Rows[0]["UserName"].ToString();
                oUser.Email = UserList.Rows[0]["EmailAddress"].ToString();
                oUser.RoleName = UserList.Rows[0]["RoleName"].ToString();                oUser.RoleId = Convert.ToInt32(UserList.Rows[0]["RoleId"]);
                oUser.UserId = Convert.ToInt32(UserList.Rows[0]["UserId"]);
            }            return oUser;        }        public async Task<DBOperation> DeleteUser(int id)        {
            var entityUser = _repository.Get(x => x.Id == id);            if (entityUser == null)                return DBOperation.NotFound;            _repository.Remove(entityUser);            await _unitOfWork.SaveChangesAsync();            return DBOperation.Success;        }        public async Task<bool> CheckEmailAddressExists(string emailAddress)        {            var isExists = await _repository.GetAllQuery().AnyAsync(x => x.Email.ToLower() == emailAddress.ToLower());            return isExists;        }        public async Task<DBOperation> ForgotPassword(ForgotPasswordViewModel forgotPasswordViewModel)        {            EmailHelper email = new EmailHelper();            bool IsSuccess = false;            string baseURL = forgotPasswordViewModel.WebApplicationUrl;            var entityUser = _repository.Get(x => x.Email == forgotPasswordViewModel.Email);            if (entityUser == null)                return DBOperation.NotFound;            entityUser.ForgotPasswordToken = UtilityHelper.GenerateSHA256String(entityUser.Id.ToString());            entityUser.ForgotPasswordDateTime = AppConstants.DateTime;            _repository.UpdateAsync(entityUser);            await _unitOfWork.SaveChangesAsync();            string strURL = baseURL + @"/Account/ResetPassword?userToken=" + entityUser.ForgotPasswordToken;            string strHtml = System.IO.File.ReadAllText(@"wwwroot\Uploads\HTMLTemplates\ForgotPassword.html");            strHtml = strHtml.Replace("ValidateURL", strURL);            strHtml = strHtml.Replace("ValidDateTime", entityUser.ForgotPasswordDateTime.Value.AddHours(1).ToString());            strHtml = strHtml.Replace("Name", entityUser.FirstName + entityUser.LastName);            var notification = new SendNotificationModel()
            {
                Body = strHtml,
                Subject = "Forgot Password",
                ToEmailList = entityUser.Email
            };            var res = _notification.SendEmail2(notification);

            //var res = email.SendMail(entityUser.Email, string.Empty, "Eltizam - Forgot Password", strHtml, GetSMTPConfiguration()); 

            EmailLogHistory emailLogHistory = new EmailLogHistory();            emailLogHistory.FromAddress = configuration.GetSection("SMTPDetails").GetSection("FromEmail").Value;//entityUser.Email;

            emailLogHistory.ToAddress = notification.ToEmailList;            emailLogHistory.Subject = notification.Subject;            emailLogHistory.EmailResponse = "";            emailLogHistory.CreatedBy = 1;
            //emailLogHistory.CreatedDate = AppConstants.DateTime;
            emailLogHistory.Body = notification.Body;            emailLogHistory.IsSent = DBOperation.Success == res.Result;

            _emailLog.AddAsync(emailLogHistory);            await _unitOfWork.SaveChangesAsync();

            //if (IsSuccess)
            return res.Result;        }        public async Task<string> ResetPassword(MasterUserResetPasswordEntity resetPasswordentity)        {            var entityUser = _repository.Get(x => x.ForgotPasswordToken == resetPasswordentity.ForgotPasswordToken);            if (entityUser == null)                return "TokenNotFound";            if (entityUser.ForgotPasswordDateTime.Value.AddHours(1) < AppConstants.DateTime)            {                return "TokenExpired";            }            entityUser.Password = UtilityHelper.GenerateSHA256String(resetPasswordentity.Password);            entityUser.ForgotPasswordToken = string.Empty;            entityUser.ForgotPasswordDateTime = null;            _repository.UpdateAsync(entityUser);            await _unitOfWork.SaveChangesAsync();            return "ResetSuccessfully";        }        public SMTPEntityViewModel GetSMTPConfiguration()        {            SMTPEntityViewModel _smtp = new SMTPEntityViewModel();            _smtp.Host = configuration.GetSection("SMTPDetails").GetSection("Host").Value;            _smtp.Port = configuration.GetSection("SMTPDetails").GetSection("Port").Value;            _smtp.EnableSsl = configuration.GetSection("SMTPDetails").GetSection("Enable_SSL").Value;            _smtp.FromEmail = configuration.GetSection("SMTPDetails").GetSection("FromEmail").Value;            _smtp.UserName = configuration.GetSection("SMTPDetails").GetSection("UserName").Value;            _smtp.Password = configuration.GetSection("SMTPDetails").GetSection("Password").Value;            return _smtp;        }        public async Task<bool> IsTokenValid(string token)        {            var isExists = await _repository.GetAllQuery().AnyAsync(x => x.ForgotPasswordToken == token);            return isExists;        }       

        /// <summary>        /// User save code        ///         /// </summary>        /// <param name="entityUser"></param>        /// <returns></returns>               public async Task<List<MasterRoleModel>> GetRoleList()        {            var lId = _helper.GetLoggedInUser()?.UserId;            var lstStf = EltizamDBHelper.ExecuteMappedReader<MasterRoleModel>(ProcedureMetastore.usp_Role_SearchAllList,             DatabaseConnection.ConnString, CommandType.StoredProcedure, null);            return lstStf;        }        public async Task<DBOperation> Delete(int id)        {            var entityUser = _repository.Get(x => x.Id == id);            if (entityUser == null)                return DBOperation.NotFound;            else            {                var entityLocation = _addressRepository.Get(x => x.TableKeyId == id && x.TableName == "Master_User");                if (entityLocation != null)                    _addressRepository.Remove(entityLocation);                var entityContact = _documentRepository.Get(x => x.TableKeyId == id && x.TableName == "Master_User");                if (entityContact != null)                    _documentRepository.Remove(entityContact);                _repository.Remove(entityUser);                await _unitOfWork.SaveChangesAsync();

                // Return a success operation indicating successful deletion.
                return DBOperation.Success;            }        }        public async Task<DBOperation> ChangePassword(ChangePasswordModel entityUser)        {
            if (entityUser.UserId >= 0 && entityUser.NewPassword == entityUser.ConfirmPassword)            {                entityUser.NewPassword = Utility.Utility.UtilityHelper.GenerateSHA256String(entityUser.NewPassword);                entityUser.ConfirmPassword = entityUser.NewPassword;            }            MasterUser objUser;            if (entityUser.UserId > 0)            {                objUser = _repository.Get(entityUser.UserId);                var OldObjUser = objUser;                if (objUser != null)                {                    objUser.Password = entityUser.NewPassword;                    objUser.ModifiedBy = _LoginUserId;                    objUser.ModifiedDate = AppConstants.DateTime;                    _repository.UpdateAsync(objUser);
                    // _repository.UpdateGraph(objUser, EntityState.Modified);

                    await _unitOfWork.SaveChangesAsync();                }                else                {                    return DBOperation.NotFound;                }            }

            return DBOperation.Success;        }       


        /// <summary>        /// Get Footer by Table Name, Key        /// </summary>        /// <param name="TableKeyId"></param>        /// <param name="TableName"></param>        /// <returns></returns>        public async Task<GlobalAuditFields?> GetGlobalAuditFields(int TableKeyId, string TableName)        {            DbParameter[] p1 =            {                 new DbParameter(AppConstants.TableKeyId, TableKeyId, SqlDbType.Int),                 new DbParameter(AppConstants.TableName, TableName, SqlDbType.VarChar)            };            var data = EltizamDBHelper.ExecuteSingleMappedReader<GlobalAuditFields>(ProcedureMetastore.usp_GetPageFooterDetails,                       DatabaseConnection.ConnString, CommandType.StoredProcedure, p1);            data.TableName = TableName;            return data;        }        public async Task<List<MasterUserModel>> GetAllUserList()        {             var lstStf = EltizamDBHelper.ExecuteMappedReader<MasterUserModel>(ProcedureMetastore.usp_User_SearchAllList,                         DatabaseConnection.ConnString, CommandType.StoredProcedure, null);            return lstStf;        }        public async Task<DBOperation> DeleteDocument(int id)        {            if (id > 0)
            {

                var entityDoc = _documentRepository.Get(id);                if (entityDoc != null)                {                    _documentRepository.Remove(entityDoc);                    await _unitOfWork.SaveChangesAsync();                }            }
            // Return a success operation indicating successful deletion.
            return DBOperation.Success;        }        public async Task<bool> IsEmailExists(string email, int? userId)        {            if (email != null)            {                if (userId == null || userId == 0)                {                    var isExistWithEmail = _repository.GetAll()
                        .Any(user => user.Email == email);                    if (isExistWithEmail)                    {                        return true;                    }                }                else                {                    var isExistWithUserId = _repository.GetAll()                        .Any(user => user.Email == email && user.Id != userId);                    if (isExistWithUserId)                    {                        return true;                    }                }            }

            return false;        }    }}