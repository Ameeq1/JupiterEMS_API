using Jupiter.Business.Core.Interface;
using Jupiter.Business.Core;
using Jupiter.WebApi.Helpers.Response;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Jupiter.Data.DataAccess.Helper;
using System.Net;
using Jupiter.Business.Models;

namespace Jupiter.WebApi.Controllers
{
    [ApiVersion("1")]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiController]
    //[Authorize]
    public class DashBoardBlueController : ControllerBase
    {
        #region Properties

        private readonly IConfiguration _configuration;
        private readonly IResponseHandler<dynamic> _ObjectResponse;
        private readonly IDashBoardService _DashBoardService;
        //private readonly IStringLocalizer<Errors> _stringLocalizerError;
        private readonly IExceptionService _ExceptionService;
        private readonly IHelper _helper;
        #endregion Properties

        #region Constructor

        public DashBoardBlueController(IConfiguration configuration, IResponseHandler<dynamic> ObjectResponse, IDashBoardService DashBoardService, IExceptionService exceptionService, IHelper helper)
        {
            _configuration = configuration;
            _ObjectResponse = ObjectResponse;
            _DashBoardService = DashBoardService;
            //	_stringLocalizerError = stringLocalizerError;
            _ExceptionService = exceptionService;
            _helper = helper;
        }

        #endregion Constructor

        #region API Methods

        /// <summary>
        /// Description - To Login User and return JWT Token String
        /// </summary>
        /// <param name="User"></param>
        /// <returns></returns>
        /// <response code="200">OK</response>
        /// <response code="400">Bad Request</response>
        /// <response code="403">Forbidden</response>
        /// <response code="404">Not Found</response>
        /// <response code="405">Method Not Allowed</response>
        /// <response code="415">Unsupported Media Type</response>
        /// <response code="500">Internal Server</response>
        /// 


       
        [HttpGet, Route("GetCodewiseAnalysisCount")]
        public async Task<IActionResult> GetCodewiseAnalysisCount(DateTime? FromDate, DateTime ToDate)
        {
            bool isSuccess = true;
            List<DashboardCodewiseAnalysisCountModel> result = new List<DashboardCodewiseAnalysisCountModel>() { new DashboardCodewiseAnalysisCountModel() };  // return EmergencyList Model details to diplay page
            if (isSuccess)
                return _ObjectResponse.Create(result, (int)HttpStatusCode.OK);
            return _ObjectResponse.Create(null, (int)HttpStatusCode.InternalServerError, "Internal Server Error");
        }



        [HttpGet, Route("GetCPRAnalysisAdult")]
        public async Task<IActionResult> GetCPRAnalysisAdult(DateTime? FromDate, DateTime ToDate)
        {
            bool isSuccess = true;
            List<DashboardPRAnalysisCountModel> result = new List<DashboardPRAnalysisCountModel>() { new DashboardPRAnalysisCountModel() };  // return EmergencyList Model details to diplay page
            if (isSuccess)
                return _ObjectResponse.Create(result, (int)HttpStatusCode.OK);
            return _ObjectResponse.Create(null, (int)HttpStatusCode.InternalServerError, "Internal Server Error");
        }


        [HttpGet, Route("GetCPRAnalysisPaediatric")]
        public async Task<IActionResult> GetCPRAnalysisPaediatric(DateTime? FromDate, DateTime ToDate)
        {
            bool isSuccess = true;
            List<DashboardPRAnalysisCountModel> result = new List<DashboardPRAnalysisCountModel>() { new DashboardPRAnalysisCountModel() };  // return EmergencyList Model details to diplay page
            if (isSuccess)
                return _ObjectResponse.Create(result, (int)HttpStatusCode.OK);
            return _ObjectResponse.Create(null, (int)HttpStatusCode.InternalServerError, "Internal Server Error");
        }

        #endregion API Methods 
    }
}
