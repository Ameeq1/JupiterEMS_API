using Jupiter.Business.Models;
using System.Collections.Generic;
using System.Threading.Tasks;
using static Jupiter.Utility.Enums.GeneralEnum;

namespace Jupiter.Business.Core.Interface
{
    public interface IMasterUserService
    {
        Task<UserSessionEntity> Login(LoginViewModel oLogin);
       
     
        Task<bool> CheckEmailAddressExists(string emailAddress);
      
        Task<bool> IsTokenValid(string token);

      
   
        Task<DBOperation> ChangePassword(ChangePasswordModel changePasswordModel);
        Task<GlobalAuditFields?> GetGlobalAuditFields(int TableKeyId, string TableName);

       
        Task<bool> IsEmailExists(string email, int? userId);
        
    }
}