using Jupiter.Business.Models;
using Jupiter.Utility.Enums;
using static Jupiter.Utility.Enums.GeneralEnum;

namespace Jupiter.Business.Core.Interface
{
    public interface IMasterNotificationService
    {
        Task<DBOperation> SendEmail(SendNotificationModel notificationModel);
        Task<DBOperation> SendEmail2(SendNotificationModel notificationModel);
        SendNotificationModel GetValuationNotificationData(RecepientActionEnum subjectEnum, int valiadtionRequestId);
      
       
       
       
    }
}
