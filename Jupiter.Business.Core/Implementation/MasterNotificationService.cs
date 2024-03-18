using Jupiter.Business.Core.Interface;
using Jupiter.Business.Core.ModelMapper;
using Jupiter.Business.Models;
using Jupiter.Data.DataAccess.Core.Repositories;
using Jupiter.Data.DataAccess.Core.UnitOfWork;
using Jupiter.Data.DataAccess.Entity;
using Jupiter.Data.DataAccess.Helper;
using Jupiter.Utility.Enums;
using Jupiter.Utility.Utility;
using MailKit.Net.Smtp;
using Microsoft.Extensions.Caching.Memory;
using Microsoft.Extensions.Configuration;
using MimeKit;
using MimeKit.Text;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using static Jupiter.Utility.Enums.GeneralEnum;

namespace Jupiter.Business.Core.Implementation
{
    public class MasterNotificationService : IMasterNotificationService
    {
        private readonly IConfiguration _configuration;
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapperFactory _mapperFactory;
        private IRepository<MasterNotification> _repository { get; set; }
      
        private IRepository<MasterUser> _userrepository { get; set; }
        private readonly IMemoryCache _memoryCache;

        public MasterNotificationService(IUnitOfWork unitOfWork, IConfiguration configuration, IMapperFactory mapperFactory, IMemoryCache memoryCache)
        {
            _unitOfWork = unitOfWork;
            _repository = _unitOfWork.GetRepository<MasterNotification>();
            _configuration = configuration;
            _mapperFactory = mapperFactory;
           
            _userrepository = _unitOfWork.GetRepository<MasterUser>();
            _memoryCache = memoryCache;
        }

        /// <summary>
        /// Send email and log entry into DB
        /// </summary>
        public async Task<DBOperation> SendEmail(SendNotificationModel request)
        {
            try
            {
                // Replace placeholders in the email body with actual data
                request.Body = request.Body?.Replace("[PValRefNoP]", request.ValRefNo).Replace("[PClientP]", request.Client).Replace("[PPropertyP]", request.Property)
                                            .Replace("[PLocationP]", request.Location).Replace("[PStatusP]", request.Status).Replace("[PIdP]", request.ValId.ToString());

                var message = new MimeMessage();
                message.From.Add(MailboxAddress.Parse(_configuration.GetSection("SMTPDetails:FromEmail").Value));

                //Parse email data
                var Em = request.ToEmailList;
                if (Em.Contains(';'))
                {
                    foreach (var mail in Em.Split(';'))
                        message.To.Add(MailboxAddress.Parse(mail.Trim()));
                }
                else
                    message.To.Add(MailboxAddress.Parse(Em));

                message.Subject = _configuration.GetSection("ApiInfo:Environment").Value + " " + request.Subject;
                message.Body = new TextPart(TextFormat.Html) { Text = request.Body };

                using var smtp = new SmtpClient();
                smtp.Connect(_configuration.GetSection("SMTPDetails:Host").Value, 587, MailKit.Security.SecureSocketOptions.StartTls);
                smtp.Authenticate(_configuration.GetSection("SMTPDetails:UserName").Value,
                    _configuration.GetSection("SMTPDetails:Password").Value);

                //Send email 
                smtp.Send(message);
                smtp.Disconnect(true);

                //Log email entry
                var notification = new MasterNotification
                {
                    ValuationRequestId = request.ValId,
                    StatusId = request.StatusId,
                    Subject = request.Subject,
                    ToEmails = request.ToEmailList,
                    Body = request.Body,
                    SentDatetime = DateTime.Now,
                    IsEmailSent = true,
                    CreatedBy = 1,
                    CreatedDate = DateTime.Now,
                    ReadBy = 0,
                    ReadDate = null,
                };

                _repository.AddAsync(notification);
                await _unitOfWork.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                // Handle exception
            }
            finally
            {
                _memoryCache.Remove(AppConstants.NotificationsCache);
            }

            return DBOperation.Success;
        }

        public async Task<DBOperation> SendEmail2(SendNotificationModel request)
        {
            try
            {
                var message = new MimeMessage();
                message.From.Add(MailboxAddress.Parse(_configuration.GetSection("SMTPDetails:FromEmail").Value));

                //Parse email data
                var Em = request.ToEmailList;
                if (Em.Contains(';'))
                {
                    foreach (var mail in Em.Split(';'))
                        message.To.Add(MailboxAddress.Parse(mail.Trim()));
                }
                else
                    message.To.Add(MailboxAddress.Parse(Em));

                message.Subject = _configuration.GetSection("ApiInfo:Environment").Value + " " + request.Subject;
                message.Body = new TextPart(TextFormat.Html) { Text = request.Body };

                using var smtp = new SmtpClient();
                smtp.Connect(_configuration.GetSection("SMTPDetails:Host").Value, 587, MailKit.Security.SecureSocketOptions.StartTls);
                smtp.Authenticate(_configuration.GetSection("SMTPDetails:UserName").Value,
                    _configuration.GetSection("SMTPDetails:Password").Value);

                //Send email 
                smtp.Send(message);
                smtp.Disconnect(true);
            }
            catch (Exception ex)
            {
                // Handle exception
            }
            finally
            {
                _memoryCache.Remove(AppConstants.NotificationsCache);
            }

            return DBOperation.Success;
        }

        public SendNotificationModel GetValuationNotificationData(RecepientActionEnum subjectEnum, int valiadtionRequestId)
        {
            DbParameter[] osqlParameter =
            {
                new DbParameter("Action", subjectEnum, SqlDbType.Int),
                new DbParameter("ValId",  valiadtionRequestId, SqlDbType.Int),
            };

            var result = MedullaEmergencyDBHelper.ExecuteMappedReader<SendNotificationModel>(ProcedureMetastore.usp_ValuationRequest_GetNotificationData,
                         DatabaseConnection.ConnString, CommandType.StoredProcedure, osqlParameter).FirstOrDefault();

            return result;
        }

        public List<MasterNotificationEntitty> GetAll(int userId, int? valId, int? pagenum)
        {
            int count = 0;
            var finalResult = InitiateNotificationCache(userId, valId, pagenum, out count);

            return finalResult;
        }

        public int GetAllCount(int userId, int? valId)
        {
            int count = 0;
            InitiateNotificationCache(userId, valId, null, out count);

            return count;
        }

        /// <summary>
        /// For initiate cache of notifications
        /// </summary>
        public List<MasterNotificationEntitty> InitiateNotificationCache(int userId, int? valId, int? pagenum, out int count)
        {
            var finalResult = new List<MasterNotificationEntitty>();
            bool IsCount = pagenum == null;

            DbParameter[] prm =
            {
                new DbParameter(AppConstants.LogInUserId, userId, SqlDbType.Int),
                new DbParameter("ValReqId",               valId,  SqlDbType.Int),
                new DbParameter("IsCount",                IsCount, SqlDbType.Bit),
                new DbParameter("PageNum",                pagenum, SqlDbType.Int)
            };

            if (IsCount == true)
            {
                var cnt = MedullaEmergencyDBHelper.ExecuteMappedReader<NotificationCount>(ProcedureMetastore.usp_MasterNotification_AllList,
                                  DatabaseConnection.ConnString, CommandType.StoredProcedure, prm);
                count = cnt[0].TotalRecords;
                return finalResult;
            }
            else
            {
                finalResult = MedullaEmergencyDBHelper.ExecuteMappedReader<MasterNotificationEntitty>(ProcedureMetastore.usp_MasterNotification_AllList,
                              DatabaseConnection.ConnString, CommandType.StoredProcedure, prm);

                count = finalResult.Count;
                return finalResult;
            }
        }

        public async Task<DBOperation> UpdateNotification(int notificationid, int readBy)
        {
            var tobeupdateddata = await _repository.GetAsync(notificationid);
            if (tobeupdateddata != null)
            {
                tobeupdateddata.ReadBy = readBy;
                tobeupdateddata.ReadDate = DateTime.Now.Date;
                _repository.UpdateAsync(tobeupdateddata);
                await _unitOfWork.SaveChangesAsync();
            }

            return DBOperation.Success;
        }

       
        public async Task<bool> SenddDetailsToEmail(RecepientActionEnum subjectEnum, int valuationrequestId)
        {
            try
            {
                var notificationModel = GetValuationNotificationData(subjectEnum, valuationrequestId);

                string strHtml = File.ReadAllText(@"wwwroot\Uploads\HTMLTemplates\ValuationRequest_StatusChange.html");
                if (subjectEnum == RecepientActionEnum.ValuationCreated)
                {
                    strHtml = File.ReadAllText(@"wwwroot\Uploads\HTMLTemplates\ValuationRequest_Created.html");
                }
                strHtml = strHtml.Replace("[PValRefNoP]", notificationModel.ValRefNo);
                strHtml = strHtml.Replace("[PDateP]", DateTime.Now.ToString("dd-MMM-yyyy"));
                strHtml = strHtml.Replace("[PNewStatusP]", notificationModel.Status);

                notificationModel.Subject = subjectEnum.GetDescription();
                notificationModel.Body = strHtml;

                await SendEmail(notificationModel);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
