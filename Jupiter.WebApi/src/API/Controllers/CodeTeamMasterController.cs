using Jupiter.Business.Core.Interface;
using Jupiter.Business.Core;
using Jupiter.WebApi.Helpers.Response;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using System.Net;
using Jupiter.Business.Models;

namespace Jupiter.WebApi.Controllers
{
    [ApiVersion("1")]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiController]

    public class CodeTeamMasterController : Controller
    {
     
        #region Properties

        private readonly IConfiguration _configuration;
        private readonly IResponseHandler<dynamic> _ObjectResponse;
        private readonly IMasterUserService _MasterUserService;
        //private readonly IStringLocalizer<Errors> _stringLocalizerError;
        private readonly IExceptionService _ExceptionService;
        private readonly IHelper _helper;
        #endregion Properties
        #region Constructor

        public CodeTeamMasterController(IConfiguration configuration, IResponseHandler<dynamic> ObjectResponse, IMasterUserService MasterUserService, IExceptionService exceptionService, IHelper helper)
        {
            _configuration = configuration;
            _ObjectResponse = ObjectResponse;
            _MasterUserService = MasterUserService;
            //	_stringLocalizerError = stringLocalizerError;
            _ExceptionService = exceptionService;
            _helper = helper;
        }

        #endregion Constructor
      
        [HttpGet, Route("GetCodeTeamDetailsById")]
        public async Task<IActionResult> GetCodeTeamDetailsById(int id)
        {
            bool isSuccess = true;
            CodeTeamMasterModel result = new CodeTeamMasterModel();
            if (isSuccess)
                return _ObjectResponse.Create(result, (int)HttpStatusCode.OK);
            return _ObjectResponse.Create(null, (int)HttpStatusCode.InternalServerError, "Internal Server Error");
        }

        [HttpGet, Route("GetAllCodeTeamList")]
        public async Task<IActionResult> GetAllCodeTeamList()
        {
            bool isSuccess = true;
            List<CodeTeamMasterModel> result = new List<CodeTeamMasterModel>() { new CodeTeamMasterModel() };
            if (isSuccess)
                return _ObjectResponse.Create(result, (int)HttpStatusCode.OK);
            return _ObjectResponse.Create(null, (int)HttpStatusCode.InternalServerError, "Internal Server Error");
        }

        [HttpPost, Route("UpsertCodeTeam")]
        public async Task<IActionResult> UpsertCodeTeam(CodeTeamMasterModel codeTeam)
        {
            bool isSuccess = true;
            int result = 101;  
            if (isSuccess)
                return _ObjectResponse.Create(result, (int)HttpStatusCode.OK);
            return _ObjectResponse.Create(null, (int)HttpStatusCode.InternalServerError, "Internal Server Error");
        }
    }
}
