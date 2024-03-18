using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jupiter.Data.DataAccess.Helper
{
    public class AppConstants
    {
        public static string ConnectionStringkey = "ConnectionStrings:MedullaEmergencyDBConn";

        public static string msgLinkToResetpasswordSentOnEmail = "Forgot password link sent successfully.";
        public static string SomeErrorOccurred = "Some error occurred";
        public static string msgEmailAddressNotExistIndatabase = "Entered email address is not found";
        public static string msgPasswordResetSuccessfully = "Password Reset successfully";
        public static string msgResetPasswordTokenExpired = "You link has been expired please go to forgot password page to reset your password again";
        public static string msgInvalidLink = "Invalid Link";
        public static string AccessRestriction = "AccessRestriction";
        public static string Home = "Home";

        public static string TableName = "TableName";
        public static string TableId = "TableId";
        public static string TableKeyId = "TableKeyId";

        public static string NoRecordFound = "No Record Found";
        public static string InsertSuccess = "Data inserted successfully";
        public static string UpdateSuccess = "Data updated successfully";
        public static string DeleteSuccess = "Data deleted successfully";
        public static string BadRequest = "Bad Request";
        public static string ActionSuccess = "Action performed successfully.";
        public static string ActionFailed = "Action failed.";
        public static string DuplicateRecordFound = "Duplicate Record Found";

        public static string P_SearchText = "@SearchText";
        public static string P_SortDirection = "@SortDirection";
        public static string P_SortColumn = "@SortColumn";
        public static string P_PageSize = "@PageSize";
        public static string P_CurrentPageNumber = "@CurrentPageNumber";
        public static string P_Id = "@Id";
        public static string P_CreatedBy = "@CreatedBy";
        public static string P_RequestData = "@RequestData";
        public static string CreatedBy = "CreatedBy";
        public static string ModifiedBy = "ModifiedBy";
        public static string MenusCache = "MenusCache";
        public static string NotificationsCache = "NotificationCache";
        public static string LogInUserId = "LogInUserId";

        public static DateTime DateTime = DateTime.Now;
        public static string DateFormat1 = DateTime.Now.ToString("dd-MMM-yyyy");
        public static string DateFormat2 = DateTime.Now.ToString("yyMMdd");


        public static string ID_ValuationRequest = string.Format("VR{0}", DateFormat2);
        public static string ID_QuotationsRequest = string.Format("QT{0}", DateFormat2);
        public static string ID_InvoiceRequest = string.Format("IN{0}", DateFormat2);
        public static string ID_PaymentRequest = string.Format("PY{0}", DateFormat2);


        public static string EmailSubject_Created = "Valuation request created";
        public static string EmailSubject_StatusChanged = "Valuation request Status changed";
        public static string EmailSubject_QuotationCreated = "Valuation request Quotation created";
        public static string EmailSubject_PaymentCreated = "Valuation request Payment created";
    }

    public class AppSettings
    {
        public static string ConnString = "ConnectionStrings:MedullaEmergencyDBConn";
    }
}
