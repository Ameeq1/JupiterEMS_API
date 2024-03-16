﻿using Jupiter.Business.Core.Interface;
        private readonly IMasterNotificationService _notification;
        private readonly Microsoft.Extensions.Configuration.IConfiguration configuration;

        private IRepository<MasterUser> _repository { get; set; }
            _approverLevelRepository = _unitOfWork.GetRepository<MasterValuationRequestApproverLevel>();
            _auditLogService = auditLogService;
            _notification = notification;
        }
            UserSessionEntity oUser = null;
            SqlParameter[] osqlParameter =
                oUser.Email = UserList.Rows[0]["EmailAddress"].ToString();
                oUser.RoleName = UserList.Rows[0]["RoleName"].ToString();
                oUser.UserId = Convert.ToInt32(UserList.Rows[0]["UserId"]);
            }
            var entityUser = _repository.Get(x => x.Id == id);
            {
                Body = strHtml,
                Subject = "Forgot Password",
                ToEmailList = entityUser.Email
            };

            //var res = email.SendMail(entityUser.Email, string.Empty, "Eltizam - Forgot Password", strHtml, GetSMTPConfiguration()); 

            EmailLogHistory emailLogHistory = new EmailLogHistory();

            emailLogHistory.ToAddress = notification.ToEmailList;
            //emailLogHistory.CreatedDate = AppConstants.DateTime;
            emailLogHistory.Body = notification.Body;

            _emailLog.AddAsync(emailLogHistory);

            //if (IsSuccess)
            return res.Result;

        /// <summary>

                // Return a success operation indicating successful deletion.
                return DBOperation.Success;
            if (entityUser.UserId >= 0 && entityUser.NewPassword == entityUser.ConfirmPassword)
                    // _repository.UpdateGraph(objUser, EntityState.Modified);

                    await _unitOfWork.SaveChangesAsync();

            return DBOperation.Success;


        /// <summary>
            {

                var entityDoc = _documentRepository.Get(id);
            // Return a success operation indicating successful deletion.
            return DBOperation.Success;
                        .Any(user => user.Email == email);

            return false;