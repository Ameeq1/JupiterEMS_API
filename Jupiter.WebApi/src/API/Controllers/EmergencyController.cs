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
        public async Task<IActionResult> ManageEmergency([FromBody]EmergencyModel emp)//(Employee emp)//
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
        public async Task<IActionResult> GetById(int EmergencyId)
        {
            bool isSuccess = true;
            string InputPayload = @"{ ""emergencyId"":123""}";
            EmergencyModel result = new EmergencyModel();  // return Employee Model details to diplay Active Emergency page
            if (isSuccess)
                return _ObjectResponse.Create(result, (int)HttpStatusCode.OK);
            return _ObjectResponse.Create(null, (int)HttpStatusCode.InternalServerError, "Internal Server Error");
        }

        [HttpPost, Route("DeactivateEmergencyStatus")]
        public async Task<IActionResult> DeactivateEmergencyStatus(int EmergencyId)
        {
            bool isSuccess = true;
            string InputPayload = @"{ ""emergencyId"":123""}";
            bool result = true;  // only return true
            if (isSuccess)
                return _ObjectResponse.Create(result, (int)HttpStatusCode.OK);
            return _ObjectResponse.Create(null, (int)HttpStatusCode.InternalServerError, "Internal Server Error");
        }

        [HttpPost,Route("ManageCodeBlueEmergencyStatus")]
        public async Task<IActionResult> ManageCodeBlueEmergencyStatus([FromBody] CodeBlueEmergencyModel emp)
        {
            bool isSuccess = true;
            string InputPayload = "Input Payload"; // JSON of "CodeBlueEmergencyModel"
            int result = 0;   // check only return true or not
            if (isSuccess)
                return _ObjectResponse.Create(result, (int)HttpStatusCode.OK);
            return _ObjectResponse.Create(null, (int)HttpStatusCode.InternalServerError, "Internal Server Error");
        }

        [HttpGet,Route("GetCodeBlueEmergencyStatusById")]
        public async Task<IActionResult> GetCodeBlueEmergencyStatusById(int EmergencyId)
        {
            bool isSuccess = true;
            string InputPayload = @"{ ""emergencyId"":123""}";
            CodeBlueEmergencyModel result = new CodeBlueEmergencyModel();  // return CodeBlueEmergency Model details to diplay page
            if (isSuccess)
                return _ObjectResponse.Create(result, (int)HttpStatusCode.OK);
            return _ObjectResponse.Create(null, (int)HttpStatusCode.InternalServerError, "Internal Server Error");
        }

        [HttpPost,Route("ManageCodePinkEmergencyStatus")]
        public EmergencyModel ManageCodePinkEmergencyStatus([FromBody] CodeBlueEmergencyModel emp) // Change to CodePinkEmergencyModel
        {
            return null;
        }

        [HttpGet,Route("GetCodePinkEmergencyStatusById")]
        public IEnumerable<EmergencyModel> GetCodePinkEmergencyStatusById(int EmergencyId)
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
        public async Task<IActionResult> GetPostEventAnalysisById(int EmergencyId)
        {
            bool isSuccess = true;
            string InputPayload = @"{ ""emergencyId"":123""}";
            PostEventAnalysisModel result = new PostEventAnalysisModel();  // return PostEventAnalysis Model details to diplay page
            if (isSuccess)
                return _ObjectResponse.Create(result, (int)HttpStatusCode.OK);
            return _ObjectResponse.Create(null, (int)HttpStatusCode.InternalServerError, "Internal Server Error");
        }

        [HttpPost,Route("ManageEmergencyVerification")]
        public async Task<IActionResult> ManageEmergencyVerification([FromBody] EmergencyVerificationModel emp)
        {
            bool isSuccess = true;
            string InputPayload = "Input Payload"; // JSON of "PostEventAnalysisModel"
            int result = 0;   // check only return true or not
            if (isSuccess)
                return _ObjectResponse.Create(result, (int)HttpStatusCode.OK);
            return _ObjectResponse.Create(null, (int)HttpStatusCode.InternalServerError, "Internal Server Error");
        }

        [HttpGet,Route("GetEmergencyVerificationById")]
        public async Task<IActionResult> GetEmergencyVerificationById(int EmergencyId)
        {
            bool isSuccess = true;
            string InputPayload = @"{ ""emergencyId"":123""}";
            EmergencyVerificationModel result = new EmergencyVerificationModel();  // return EmergencyVerification Model details to diplay page
            if (isSuccess)
                return _ObjectResponse.Create(result, (int)HttpStatusCode.OK);
            return _ObjectResponse.Create(null, (int)HttpStatusCode.InternalServerError, "Internal Server Error");
        }

    [HttpPost,Route("ManageEmergencyAssignedAction")]
        public async Task<IActionResult> ManageEmergencyAssignedAction([FromBody] EmergencyActionAssignedModel emp)
        {
            bool isSuccess = true;
            string InputPayload = "Input Payload"; // JSON of "PostEventAnalysisModel"
            int result = 0;   // return Employee Notification Model to send email notification
            if (isSuccess)
                return _ObjectResponse.Create(result, (int)HttpStatusCode.OK);
            return _ObjectResponse.Create(null, (int)HttpStatusCode.InternalServerError, "Internal Server Error");
        }

        [HttpGet,Route("GetEmergencyAssignedActionById")]
        public async Task<IActionResult> GetEmergencyAssignedActionById(int EmergencyId)
        {
            bool isSuccess = true;
            string InputPayload = @"{ ""emergencyId"":123""}";
            EmergencyActionAssignedModel result = new EmergencyActionAssignedModel();  // return EmergencyVerification Model details to diplay page
            if (isSuccess)
                return _ObjectResponse.Create(result, (int)HttpStatusCode.OK);
            return _ObjectResponse.Create(null, (int)HttpStatusCode.InternalServerError, "Internal Server Error");
        }

        [HttpPost,Route("ManageEmergencyActionTaken")]
        public async Task<IActionResult> ManageEmergencyActionTaken([FromBody] EmergencyActionTakenModel emp)
        {
            bool isSuccess = true;
            string InputPayload = "Input Payload"; // JSON of "EmergencyActionTakenModel"
            int result = 0;   // return Employee Notification Model to send email notification
            if (isSuccess)
                return _ObjectResponse.Create(result, (int)HttpStatusCode.OK);
            return _ObjectResponse.Create(null, (int)HttpStatusCode.InternalServerError, "Internal Server Error");
        }

    [HttpGet,Route("GetEmergencyActionTakenById")]
        public async Task<IActionResult> GetEmergencyActionTakenById(int EmergencyId)
        {
            bool isSuccess = true;
            string InputPayload = @"{ ""emergencyId"":123""}";
            EmergencyActionTakenModel result = new EmergencyActionTakenModel();  // return EmergencyVerification Model details to diplay page
            if (isSuccess)
                return _ObjectResponse.Create(result, (int)HttpStatusCode.OK);
            return _ObjectResponse.Create(null, (int)HttpStatusCode.InternalServerError, "Internal Server Error");
        }

        [HttpPost,Route("ManageEmergencyActionClosure")]
        public async Task<IActionResult> ManageEmergencyActionClosure([FromBody] EmergencyActionClosureModel emp)
        {
            bool isSuccess = true;
            string InputPayload = "Input Payload"; // JSON of "EmergencyActionTakenModel"
            int result = 0;   // return true
            if (isSuccess)
                return _ObjectResponse.Create(result, (int)HttpStatusCode.OK);
            return _ObjectResponse.Create(null, (int)HttpStatusCode.InternalServerError, "Internal Server Error");
        }

        [HttpGet,Route("GetEmergencyActionClosureById")]
        public async Task<IActionResult> GetEmergencyActionClosureById(int EmergencyId)
        {
            bool isSuccess = true;
            string InputPayload = @"{ ""emergencyId"":123""}";
            EmergencyActionClosureModel result = new EmergencyActionClosureModel();  // return EmergencyVerification Model details to diplay page
            if (isSuccess)
                return _ObjectResponse.Create(result, (int)HttpStatusCode.OK);
            return _ObjectResponse.Create(null, (int)HttpStatusCode.InternalServerError, "Internal Server Error");
        }

        [HttpGet, Route("GetEmergencyAll")]
        public async Task<IActionResult> GetEmergencyAll()
        {
            bool isSuccess = true;
            IEnumerable<EmergencyListModel> result = new List<EmergencyListModel>();  // return EmergencyListModel Model details to diplay page
            if (isSuccess)
                return _ObjectResponse.Create(result, (int)HttpStatusCode.OK);
            return _ObjectResponse.Create(null, (int)HttpStatusCode.InternalServerError, "Internal Server Error");
        }

        [HttpGet, Route("GetEmergencyAllByFilter")]
        public async Task<IActionResult> GetEmergencyAllByFilter(int? CodeTypeId,string? ReportedBy,int? LocationId,DateTime? FromDate,DateTime ToDate,string? SearchText)
        {
            bool isSuccess = true;
            IEnumerable<EmergencyListModel> result = new List<EmergencyListModel>();  // return EmergencyListModel Model details to diplay page
            if (isSuccess)
                return _ObjectResponse.Create(result, (int)HttpStatusCode.OK);
            return _ObjectResponse.Create(null, (int)HttpStatusCode.InternalServerError, "Internal Server Error");
        }

        [HttpGet, Route("ViewEmergencyById")]
        public async Task<IActionResult> ViewEmergencyById(int EmergencyId)
        {
            bool isSuccess = true;
            IEnumerable<EmergencyListModel> result = new List<EmergencyListModel>();  // return EmergencyListModel Model details to diplay page
            if (isSuccess)
                return _ObjectResponse.Create(result, (int)HttpStatusCode.OK);
            return _ObjectResponse.Create(null, (int)HttpStatusCode.InternalServerError, "Internal Server Error");
        }
    }
}
