using Jupiter.Business.Core.Interface;
using Jupiter.Business.Core;
using Jupiter.WebApi.Helpers.Response;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using System.Net;
using Jupiter.Business.Models;
using Jupiter.Business.Core.Implementation;

namespace Jupiter.WebApi.Controllers
{
    [ApiVersion("1")]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiController]
    //[Authorize]
    public class EmergencyController : ControllerBase
    {

        #region Properties

        private readonly IConfiguration _configuration;
        private readonly IResponseHandler<dynamic> _ObjectResponse;
        private readonly IMasterUserService _MasterUserService;
        private readonly IEmergencyService _EmergencyService;
        //private readonly IStringLocalizer<Errors> _stringLocalizerError;
        private readonly IExceptionService _ExceptionService;
        private readonly IHelper _helper;
        #endregion Properties

        #region Constructor

        public EmergencyController(IConfiguration configuration, IResponseHandler<dynamic> ObjectResponse, IMasterUserService MasterUserService, IEmergencyService EmergencyService, IExceptionService exceptionService, IHelper helper)
        {
            _configuration = configuration;
            _ObjectResponse = ObjectResponse;
            _MasterUserService = MasterUserService;
            _EmergencyService = EmergencyService;
            //	_stringLocalizerError = stringLocalizerError;
            _ExceptionService = exceptionService;
            _helper = helper;
        }

        #endregion Constructor

        [HttpPost, Route("ManageEmergency")]
        public async Task<IActionResult> ManageEmergency([FromBody]EmergencyModel emergencyModel)//(Employee emp)//
        {
            //emp.Id = 1;
            //emp.FirstName = "Mohd";
            //emp.LastName = "Ameeq";
            //emp.JobTitle = "SDE";
            //emp.Salary = 5000;
            //emp.HireDate = DateTime.Now;
            //_EmergencyService.Create(emp);
            bool isSuccess = true;
            string InputPayload = @"{ ""emergencyId"":0,""entryType"":{ ""entryTypeId"":1,""entryDetails"":{ ""activationDateTime"":null,""deactivationDateTime"":null,""reasonLateEntry"":null,""remarks"":null} },""codeTypeId"":1,""locationId"":2,""locationDetails"":""Hello"",""codeBlueDetails"":{ ""victimDetails"":{ ""victimTypeId"":1,""victimRefNo"":""12345"",""victimCondition"":[""Unconsious""]},""checkList"":{ ""checklist1"":true,""checklist1Reason"":""Hello1"",""checklist2"":true,""checklist2Reason"":""Hello2"",""checklist3"":true,""checklist3Reason"":""Hello3""} },""codePinkDetails"":{ },""codeHazmatDetails"":{ },""codePurpleDetails"":{ },""codeGreyDetails"":{ },""codeRedDetails"":{ },""codeBlackDetails"":{ },""createdDate"":""2024 - 03 - 15T10: 51:46.302Z"",""updatedDate"":""2024 - 03 - 15T10: 51:46.302Z"",""isActivated"":true}""}";
            EmployeeNotification result = new EmployeeNotification();  // return EmergencyId, Employee Notification Details and Location details
            if (isSuccess)
                return _ObjectResponse.Create(result, (int)HttpStatusCode.OK);
            return _ObjectResponse.Create(null, (int)HttpStatusCode.InternalServerError, "Internal Server Error");
        }

        [HttpGet,Route("GetById")]
        public async Task<IActionResult> GetById(int id)
        {
            bool isSuccess = true;
            string InputPayload = @"{ ""emergencyId"":123""}";
            EmergencyModel result = new EmergencyModel();  // return Employee Model details to diplay Active Emergency page
            result.codeBlackDetails = new CodeBlackDetails();
            result.codeBlueDetails = new CodeBlueDetails();
            result.codePinkDetails = new CodePinkDetails();
            result.codeRedDetails = new CodeRedDetails();
            result.codePurpleDetails = new CodePurpleDetails();
            result.codeHazmatDetails = new CodeHazmatDetails();
            result.codeGreyDetails = new CodeGreyDetails();
            if (isSuccess)
                return _ObjectResponse.Create(result, (int)HttpStatusCode.OK);
            return _ObjectResponse.Create(null, (int)HttpStatusCode.InternalServerError, "Internal Server Error");
        }

        [HttpPost, Route("DeactivateStatus")]
        public async Task<IActionResult> DeactivateStatus(int id, [FromBody] PageLoginUserModel pageLoginUserModel)
        {
            bool isSuccess = true;
            string InputPayload = @"{ ""emergencyId"":123""}";
            bool result = true;  // only return true
            if (isSuccess)
                return _ObjectResponse.Create(result, (int)HttpStatusCode.OK);
            return _ObjectResponse.Create(null, (int)HttpStatusCode.InternalServerError, "Internal Server Error");
        }

        [HttpPost,Route("ManageCodeBlueStatus")]
        public async Task<IActionResult> ManageCodeBlueStatus([FromBody] CodeBlueEmergencyModel emp)
        {
            bool isSuccess = true;
            string InputPayload = "Input Payload"; // JSON of "CodeBlueEmergencyModel"
            int result = 0;   // check only return true or not
            if (isSuccess)
                return _ObjectResponse.Create(result, (int)HttpStatusCode.OK);
            return _ObjectResponse.Create(null, (int)HttpStatusCode.InternalServerError, "Internal Server Error");
        }

        [HttpGet,Route("GetCodeBlueStatusById")]
        public async Task<IActionResult> GetCodeBlueStatusById(int id)
        {
            bool isSuccess = true;
            string InputPayload = @"{ ""emergencyId"":123""}";
            CodeBlueEmergencyModel result = new CodeBlueEmergencyModel();  // return CodeBlueEmergency Model details to diplay page
            if (isSuccess)
                return _ObjectResponse.Create(result, (int)HttpStatusCode.OK);
            return _ObjectResponse.Create(null, (int)HttpStatusCode.InternalServerError, "Internal Server Error");
        }

        [HttpPost,Route("ManageCodePinkStatus")]
        public EmergencyModel ManageCodePinkEmergencyStatus([FromBody] CodeBlueEmergencyModel emp) // Change to CodePinkEmergencyModel
        {
            return null;
        }

        [HttpGet,Route("GetCodePinkStatusById")]
        public IEnumerable<EmergencyModel> GetCodePinkStatusById(int id)
        {
            return new List<EmergencyModel>();
        }

        [HttpPost,Route("ManagePostEventAnalysis")]
        public async Task<IActionResult> ManagePostEventAnalysis([FromBody] PostEventAnalysisModel emp)
        {
            bool isSuccess = true;
            string InputPayload = "Input Payload"; // JSON of "PostEventAnalysisModel"
            int result = 0;   // check only return true or not
            if (isSuccess)
                return _ObjectResponse.Create(result, (int)HttpStatusCode.OK);
            return _ObjectResponse.Create(null, (int)HttpStatusCode.InternalServerError, "Internal Server Error");
        }
        
        [HttpGet,Route("GetPostEventAnalysisById")]
        public async Task<IActionResult> GetPostEventAnalysisById(int id)
        {
            bool isSuccess = true;
            string InputPayload = @"{ ""emergencyId"":123""}";
            PostEventAnalysisModel result = new PostEventAnalysisModel();  // return PostEventAnalysis Model details to diplay page
            if (isSuccess)
                return _ObjectResponse.Create(result, (int)HttpStatusCode.OK);
            return _ObjectResponse.Create(null, (int)HttpStatusCode.InternalServerError, "Internal Server Error");
        }

        [HttpPost,Route("ManageVerification")]
        public async Task<IActionResult> ManageVerification([FromBody] EmergencyVerificationModel emp)
        {
            bool isSuccess = true;
            string InputPayload = "Input Payload"; // JSON of "PostEventAnalysisModel"
            int result = 0;   // check only return true or not
            if (isSuccess)
                return _ObjectResponse.Create(result, (int)HttpStatusCode.OK);
            return _ObjectResponse.Create(null, (int)HttpStatusCode.InternalServerError, "Internal Server Error");
        }

        [HttpGet,Route("GetVerificationById")]
        public async Task<IActionResult> GetVerificationById(int id)
        {
            bool isSuccess = true;
            string InputPayload = @"{ ""emergencyId"":123""}";
            EmergencyVerificationModel result = new EmergencyVerificationModel();  // return EmergencyVerification Model details to diplay page
            if (isSuccess)
                return _ObjectResponse.Create(result, (int)HttpStatusCode.OK);
            return _ObjectResponse.Create(null, (int)HttpStatusCode.InternalServerError, "Internal Server Error");
        }

    [HttpPost,Route("ManageAssignedAction")]
        public async Task<IActionResult> ManageAssignedAction([FromBody] EmergencyActionAssignedModel emp)
        {
            bool isSuccess = true;
            string InputPayload = "Input Payload"; // JSON of "PostEventAnalysisModel"
            int result = 0;   // return Employee Notification Model to send email notification
            if (isSuccess)
                return _ObjectResponse.Create(result, (int)HttpStatusCode.OK);
            return _ObjectResponse.Create(null, (int)HttpStatusCode.InternalServerError, "Internal Server Error");
        }

        [HttpGet,Route("GetAssignedActionById")]
        public async Task<IActionResult> GetAssignedActionById(int id)
        {
            bool isSuccess = true;
            string InputPayload = @"{ ""emergencyId"":123""}";
            EmergencyActionAssignedModel result = new EmergencyActionAssignedModel()
            {
                EmergencyId = 101,
                ActionItem = new List<ActionAssignItem>()
                {
                    new ActionAssignItem() {
                        ActionDescription ="",
                        ActionCompletedBy=101,
                        ActionCompletedDate=DateTime.Now,
                        ActionAssignTo= new List<string>(){"str1", "str1", "str1" }
                     }
                }
            };  // return EmergencyVerification Model details to diplay page
            if (isSuccess)
                return _ObjectResponse.Create(result, (int)HttpStatusCode.OK);
            return _ObjectResponse.Create(null, (int)HttpStatusCode.InternalServerError, "Internal Server Error");
        }

        [HttpPost,Route("ManageActionTaken")]
        public async Task<IActionResult> ManageActionTaken([FromBody] EmergencyActionTakenModel emp)
        {
            bool isSuccess = true;
            string InputPayload = "Input Payload"; // JSON of "EmergencyActionTakenModel"
            int result = 0;   // return Employee Notification Model to send email notification
            if (isSuccess)
                return _ObjectResponse.Create(result, (int)HttpStatusCode.OK);
            return _ObjectResponse.Create(null, (int)HttpStatusCode.InternalServerError, "Internal Server Error");
        }

    [HttpGet,Route("GetActionTakenById")]
        public async Task<IActionResult> GetActionTakenById(int id)
        {
            bool isSuccess = true;
            string InputPayload = @"{ ""emergencyId"":123""}";
            EmergencyActionTakenModel result = new EmergencyActionTakenModel();  // return EmergencyVerification Model details to diplay page
            if (isSuccess)
                return _ObjectResponse.Create(result, (int)HttpStatusCode.OK);
            return _ObjectResponse.Create(null, (int)HttpStatusCode.InternalServerError, "Internal Server Error");
        }

        [HttpPost,Route("ManageActionClosure")]
        public async Task<IActionResult> ManageActionClosure([FromBody] EmergencyActionClosureModel emp)
        {
            bool isSuccess = true;
            string InputPayload = "Input Payload"; // JSON of "EmergencyActionTakenModel"
            int result = 0;   // return true
            if (isSuccess)
                return _ObjectResponse.Create(result, (int)HttpStatusCode.OK);
            return _ObjectResponse.Create(null, (int)HttpStatusCode.InternalServerError, "Internal Server Error");
        }

        [HttpGet,Route("GetActionClosureById")]
        public async Task<IActionResult> GetActionClosureById(int id)
        {
            bool isSuccess = true;
            string InputPayload = @"{ ""emergencyId"":123""}";
            EmergencyActionClosureModel result = new EmergencyActionClosureModel();  // return EmergencyVerification Model details to diplay page
            if (isSuccess)
                return _ObjectResponse.Create(result, (int)HttpStatusCode.OK);
            return _ObjectResponse.Create(null, (int)HttpStatusCode.InternalServerError, "Internal Server Error");
        }

        [HttpGet, Route("GetAll")]
        public async Task<IActionResult> GetAll([FromQuery]PageSizeModel pageSizeModel)
        {
            bool isSuccess = true;
            List<EmergencyListModel> result = new List<EmergencyListModel>();  // return EmergencyList Model details to diplay page
            if (isSuccess)
                return _ObjectResponse.Create(result, (int)HttpStatusCode.OK);
            return _ObjectResponse.Create(null, (int)HttpStatusCode.InternalServerError, "Internal Server Error");
        }

        [HttpGet, Route("GetAllByFilter")]
        public async Task<IActionResult> GetAllByFilter(ListFilterModel listFilterModel)
        {
            bool isSuccess = true;
            List<EmergencyListModel> result = new List<EmergencyListModel>();  // return EmergencyList Model details to diplay page
            if (isSuccess)
                return _ObjectResponse.Create(result, (int)HttpStatusCode.OK);
            return _ObjectResponse.Create(null, (int)HttpStatusCode.InternalServerError, "Internal Server Error");
        }

        [HttpGet, Route("ViewById")]
        public async Task<IActionResult> ViewById(int id)
        {
            bool isSuccess = true;
            ViewEditEmergencyModel result = new ViewEditEmergencyModel();  // return ViewEditEmergency Model details to diplay page
            if (isSuccess)
                return _ObjectResponse.Create(result, (int)HttpStatusCode.OK);
            return _ObjectResponse.Create(null, (int)HttpStatusCode.InternalServerError, "Internal Server Error");
        }

        [HttpPost, Route("ActionAssignedNotification")]
        public async Task<IActionResult> ActionAssignedNotification(ActionAssignedNotificationModel actionAssignedNotificationModel)
        {
            bool isSuccess = true;
            //ViewEditEmergencyModel result = new ViewEditEmergencyModel();  // return ViewEditEmergency Model details to diplay page
            bool result = true;
            if (isSuccess)
                return _ObjectResponse.Create(result, (int)HttpStatusCode.OK);
            return _ObjectResponse.Create(null, (int)HttpStatusCode.InternalServerError, "Internal Server Error");
        }

        [HttpPost, Route("ActionTakenNotification")]
        public async Task<IActionResult> ActionTakenNotification(ActionTakenNotificationModel actionTakenNotificationModel)
        {
            bool isSuccess = true;
            //ViewEditEmergencyModel result = new ViewEditEmergencyModel();  // return ViewEditEmergency Model details to diplay page
            bool result = true;
            if (isSuccess)
                return _ObjectResponse.Create(result, (int)HttpStatusCode.OK);
            return _ObjectResponse.Create(null, (int)HttpStatusCode.InternalServerError, "Internal Server Error");
        }

        [HttpPost, Route("EmergencyResponseById")]
        public async Task<IActionResult> EmergencyResponseById(EmergencyResponseModel emergencyResponseModel)
        {
            bool isSuccess = true;
            bool result = true;
            if (isSuccess)
                return _ObjectResponse.Create(result, (int)HttpStatusCode.OK);
            return _ObjectResponse.Create(null, (int)HttpStatusCode.InternalServerError, "Internal Server Error");
        }

        [HttpPost, Route("PostEventAnalysisNotification")]
        public async Task<IActionResult> PostEventAnalysisNotification(PostEventAnalysisNotificationModel postEventAnalysisNotificationModel)
        {
            bool isSuccess = true;
            //ViewEditEmergencyModel result = new ViewEditEmergencyModel();  // return ViewEditEmergency Model details to diplay page
            bool result = true;
            if (isSuccess)
                return _ObjectResponse.Create(result, (int)HttpStatusCode.OK);
            return _ObjectResponse.Create(null, (int)HttpStatusCode.InternalServerError, "Internal Server Error");
        }
    }
}
