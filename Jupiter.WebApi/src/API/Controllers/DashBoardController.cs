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
    public class DashBoardController : ControllerBase
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

        public DashBoardController(IConfiguration configuration, IResponseHandler<dynamic> ObjectResponse, IDashBoardService DashBoardService, IExceptionService exceptionService, IHelper helper)
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

        [HttpGet, Route("GetActiveEmegencyList")]
        public async Task<IActionResult> GetActiveEmegencyList()
        {
            //try
            //{
            //    var oRoleList = await _DashBoardService.GetActiveEmegencyList();
            //    if (oRoleList != null)
            //        return _ObjectResponse.Create(oRoleList, (Int32)HttpStatusCode.OK);
            //    else
            //        return _ObjectResponse.Create(null, (Int32)HttpStatusCode.BadRequest, AppConstants.NoRecordFound);
            //}
            //catch (Exception ex)
            //{
            //    await _ExceptionService.LogException(ex);
            //    return _ObjectResponse.Create(false, (Int32)HttpStatusCode.InternalServerError, Convert.ToString(ex.StackTrace));
            //}

            try
            {
                // Simulate a successful response without calling the service method
                var oRoleList = new List<DashboardEmergencyModel>(); // Create an empty list or any mock data you want to return
                return _ObjectResponse.Create(oRoleList, (Int32)HttpStatusCode.OK);
               // return Ok(oRoleList);
            }
            catch (Exception ex)
            {
                await _ExceptionService.LogException(ex);
                return _ObjectResponse.Create(false, (Int32)HttpStatusCode.InternalServerError, Convert.ToString(ex.StackTrace));
            }
        }

        [HttpGet, Route("GetTodayEmegencyList1")]
        public async Task<IActionResult> GetTodayEmegencyList1(DateTime today)
        {
            //try
            //{
            //    var oRoleList = await _DashBoardService.GetTodayEmegencyList( today);
            //    if (oRoleList != null)
            //        return _ObjectResponse.Create(oRoleList, (Int32)HttpStatusCode.OK);
            //    else
            //        return _ObjectResponse.Create(null, (Int32)HttpStatusCode.BadRequest, AppConstants.NoRecordFound);
            //}
            //catch (Exception ex)
            //{
            //    await _ExceptionService.LogException(ex);
            //    return _ObjectResponse.Create(false, (Int32)HttpStatusCode.InternalServerError, Convert.ToString(ex.StackTrace));
            //}

            try
            {
                // Simulate a successful response without calling the service method
                var oRoleList = new List<DashboardEmergencyModel>(); // Create an empty list or any mock data you want to return
                return _ObjectResponse.Create(oRoleList, (Int32)HttpStatusCode.OK);
            }
            catch (Exception ex)
            {
                await _ExceptionService.LogException(ex);
                return _ObjectResponse.Create(false, (Int32)HttpStatusCode.InternalServerError, Convert.ToString(ex.StackTrace));
            }
        }

        [HttpGet, Route("GetTodayEmegencyList")]
        public async Task<IActionResult> GetEmergencyAllByFilter( DateTime? todayDate)
        {
            bool isSuccess = true;
            List<DashboardEmergencyModel> result = new List<DashboardEmergencyModel>();  // return EmergencyList Model details to diplay page
            if (isSuccess)
                return _ObjectResponse.Create(result, (int)HttpStatusCode.OK);
            return _ObjectResponse.Create(null, (int)HttpStatusCode.InternalServerError, "Internal Server Error");
        }


        [HttpGet, Route("GetReportedEmergencies")]
        public async Task<IActionResult> GetReportedEmergencies(DateTime fromDate, DateTime toDate)
        {
            //try
            //{
            //    var oRoleList = await _DashBoardService.GetReportedEmergencies(fromDate, toDate);
            //    if (oRoleList != null)
            //        return _ObjectResponse.Create(oRoleList, (Int32)HttpStatusCode.OK);
            //    else
            //        return _ObjectResponse.Create(null, (Int32)HttpStatusCode.BadRequest, AppConstants.NoRecordFound);
            //}
            //catch (Exception ex)
            //{
            //    await _ExceptionService.LogException(ex);
            //    return _ObjectResponse.Create(false, (Int32)HttpStatusCode.InternalServerError, Convert.ToString(ex.StackTrace));
            //}

            try
            {
                // Simulate a successful response without calling the service method
                var oRoleList = new List<DashboardReportedEmergencyModel>(); // Create an empty list or any mock data you want to return
                return _ObjectResponse.Create(oRoleList, (Int32)HttpStatusCode.OK);
            }
            catch (Exception ex)
            {
                await _ExceptionService.LogException(ex);
                return _ObjectResponse.Create(false, (Int32)HttpStatusCode.InternalServerError, Convert.ToString(ex.StackTrace));
            }
        }

        [HttpGet, Route("GetRecentEmergency")]
        public async Task<IActionResult> GetRecentEmergency()
        {
            //try
            //{
            //    var oRoleList = await _DashBoardService.GetRecentEmergency();
            //    if (oRoleList != null)
            //        return _ObjectResponse.Create(oRoleList, (Int32)HttpStatusCode.OK);
            //    else
            //        return _ObjectResponse.Create(null, (Int32)HttpStatusCode.BadRequest, AppConstants.NoRecordFound);
            //}
            //catch (Exception ex)
            //{
            //    await _ExceptionService.LogException(ex);
            //    return _ObjectResponse.Create(false, (Int32)HttpStatusCode.InternalServerError, Convert.ToString(ex.StackTrace));
            //}

            try
            {
                // Simulate a successful response without calling the service method
                var oRoleList = new List<DashboardRecentEmergencyModel>(); // Create an empty list or any mock data you want to return
                return _ObjectResponse.Create(oRoleList, (Int32)HttpStatusCode.OK);
            }
            catch (Exception ex)
            {
                await _ExceptionService.LogException(ex);
                return _ObjectResponse.Create(false, (Int32)HttpStatusCode.InternalServerError, Convert.ToString(ex.StackTrace));
            }
        }

        [HttpGet, Route("GetAssignedActionItems")]
        public async Task<IActionResult> GetAssignedActionItems()
        {
            //try
            //{
            //    var oRoleList = await _DashBoardService.GetAssignedActionItems();
            //    if (oRoleList != null)
            //        return _ObjectResponse.Create(oRoleList, (Int32)HttpStatusCode.OK);
            //    else
            //        return _ObjectResponse.Create(null, (Int32)HttpStatusCode.BadRequest, AppConstants.NoRecordFound);
            //}
            //catch (Exception ex)
            //{
            //    await _ExceptionService.LogException(ex);
            //    return _ObjectResponse.Create(false, (Int32)HttpStatusCode.InternalServerError, Convert.ToString(ex.StackTrace));
            //}

            try
            {
                // Simulate a successful response without calling the service method
                var oRoleList = new List<DashboardOverdueActionItemsforStaffModel>(); // Create an empty list or any mock data you want to return
                return _ObjectResponse.Create(oRoleList, (Int32)HttpStatusCode.OK);
            }
            catch (Exception ex)
            {
                await _ExceptionService.LogException(ex);
                return _ObjectResponse.Create(false, (Int32)HttpStatusCode.InternalServerError, Convert.ToString(ex.StackTrace));
            }
        }
        [HttpGet, Route("GetOverdueActionItemsforStaff")]
        public async Task<IActionResult> GetOverdueActionItemsforStaff()
        {
            //try
            //{
            //    var oRoleList = await _DashBoardService.GetOverdueActionItemsforStaff();
            //    if (oRoleList != null)
            //        return _ObjectResponse.Create(oRoleList, (Int32)HttpStatusCode.OK);
            //    else
            //        return _ObjectResponse.Create(null, (Int32)HttpStatusCode.BadRequest, AppConstants.NoRecordFound);
            //}
            //catch (Exception ex)
            //{
            //    await _ExceptionService.LogException(ex);
            //    return _ObjectResponse.Create(false, (Int32)HttpStatusCode.InternalServerError, Convert.ToString(ex.StackTrace));
            //}

            try
            {
                // Simulate a successful response without calling the service method
                var oRoleList = new List<DashboardOverdueActionItemsforStaffModel>(); // Create an empty list or any mock data you want to return
                return _ObjectResponse.Create(oRoleList, (Int32)HttpStatusCode.OK);
            }
            catch (Exception ex)
            {
                await _ExceptionService.LogException(ex);
                return _ObjectResponse.Create(false, (Int32)HttpStatusCode.InternalServerError, Convert.ToString(ex.StackTrace));
            }
        }

        [HttpGet, Route("GetCodewiseAnalysisCount")]
        public async Task<IActionResult> GetCodewiseAnalysisCount(DateTime fromDate, DateTime toDate)
        {
            //try
            //{
            //    var oRoleList = await _DashBoardService.GetCodewiseAnalysisCount(fromDate, toDate);
            //    if (oRoleList != null)
            //        return _ObjectResponse.Create(oRoleList, (Int32)HttpStatusCode.OK);
            //    else
            //        return _ObjectResponse.Create(null, (Int32)HttpStatusCode.BadRequest, AppConstants.NoRecordFound);
            //}
            //catch (Exception ex)
            //{
            //    await _ExceptionService.LogException(ex);
            //    return _ObjectResponse.Create(false, (Int32)HttpStatusCode.InternalServerError, Convert.ToString(ex.StackTrace));
            //}

            try
            {
                // Simulate a successful response without calling the service method
                var oRoleList = new List<DashboardCodewiseAnalysisCountModel>(); // Create an empty list or any mock data you want to return
                return _ObjectResponse.Create(oRoleList, (Int32)HttpStatusCode.OK);
            }
            catch (Exception ex)
            {
                await _ExceptionService.LogException(ex);
                return _ObjectResponse.Create(false, (Int32)HttpStatusCode.InternalServerError, Convert.ToString(ex.StackTrace));
            }
        }

        [HttpGet, Route("GetCPRAnalysisAdult")]
        public async Task<IActionResult> GetCPRAnalysisAdult(DateTime fromDate, DateTime toDate)
        {
            //try
            //{
            //    var oRoleList = await _DashBoardService.GetCPRAnalysisAdult(fromDate, toDate);
            //    if (oRoleList != null)
            //        return _ObjectResponse.Create(oRoleList, (Int32)HttpStatusCode.OK);
            //    else
            //        return _ObjectResponse.Create(null, (Int32)HttpStatusCode.BadRequest, AppConstants.NoRecordFound);
            //}
            //catch (Exception ex)
            //{
            //    await _ExceptionService.LogException(ex);
            //    return _ObjectResponse.Create(false, (Int32)HttpStatusCode.InternalServerError, Convert.ToString(ex.StackTrace));
            //}

            try
            {
                // Simulate a successful response without calling the service method
                var oRoleList = new List<DashboardPRAnalysisCountModel>(); // Create an empty list or any mock data you want to return
                return _ObjectResponse.Create(oRoleList, (Int32)HttpStatusCode.OK);
            }
            catch (Exception ex)
            {
                await _ExceptionService.LogException(ex);
                return _ObjectResponse.Create(false, (Int32)HttpStatusCode.InternalServerError, Convert.ToString(ex.StackTrace));
            }
        }

        [HttpGet, Route("GetCPRAnalysisPaediatric")]
        public async Task<IActionResult> GetCPRAnalysisPaediatric(DateTime fromDate, DateTime toDate)
        {
            //try
            //{
            //    var oRoleList = await _DashBoardService.GetCPRAnalysisPaediatric(fromDate, toDate);
            //    if (oRoleList != null)
            //        return _ObjectResponse.Create(oRoleList, (Int32)HttpStatusCode.OK);
            //    else
            //        return _ObjectResponse.Create(null, (Int32)HttpStatusCode.BadRequest, AppConstants.NoRecordFound);
            //}
            //catch (Exception ex)
            //{
            //    await _ExceptionService.LogException(ex);
            //    return _ObjectResponse.Create(false, (Int32)HttpStatusCode.InternalServerError, Convert.ToString(ex.StackTrace));
            //}

            try
            {
                // Simulate a successful response without calling the service method
                var oRoleList = new List<DashboardPRAnalysisCountModel>(); // Create an empty list or any mock data you want to return
                return _ObjectResponse.Create(oRoleList, (Int32)HttpStatusCode.OK);
            }
            catch (Exception ex)
            {
                await _ExceptionService.LogException(ex);
                return _ObjectResponse.Create(false, (Int32)HttpStatusCode.InternalServerError, Convert.ToString(ex.StackTrace));
            }
        }


        #endregion API Methods 
    }
}
