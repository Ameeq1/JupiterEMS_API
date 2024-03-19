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

    public class CodeMasterController : Controller
    {
     
        #region Properties

        private readonly IConfiguration _configuration;
        private readonly IResponseHandler<dynamic> _ObjectResponse;
        private readonly IMasterUserService _MasterUserService;
        //private readonly IStringLocalizer<Errors> _stringLocalizerError;
        private readonly IExceptionService _ExceptionService;
        private readonly IHelper _helper;
        private string SuccessMessage = "Success: Action performed successfully.";
        private string ErrorMessage = "Failed: Action not performed due to issue: {DBError}";
        #endregion Properties
        #region Constructor

        public CodeMasterController(IConfiguration configuration, IResponseHandler<dynamic> ObjectResponse, IMasterUserService MasterUserService, IExceptionService exceptionService, IHelper helper)
        {
            _configuration = configuration;
            _ObjectResponse = ObjectResponse;
            _MasterUserService = MasterUserService;
            //	_stringLocalizerError = stringLocalizerError;
            _ExceptionService = exceptionService;
            _helper = helper;
        }

        #endregion Constructor
      
        [HttpGet, Route("GetById")]
        public async Task<IActionResult> GetById(int id)
        {
            bool isSuccess = true;
            CodeMasterModel result = new CodeMasterModel();
            if (isSuccess)
                return _ObjectResponse.Create(result, (int)HttpStatusCode.OK, SuccessMessage);
            return _ObjectResponse.Create(null, (int)HttpStatusCode.InternalServerError, ErrorMessage);
        }

        [HttpGet, Route("GetAll")]
        public async Task<IActionResult> GetAll(int unitid)
        {
            bool isSuccess = true;
            List<CodeMasterModel> result = new List<CodeMasterModel>() { new CodeMasterModel()};
            if (isSuccess)
                return _ObjectResponse.Create(result, (int)HttpStatusCode.OK, SuccessMessage);
            return _ObjectResponse.Create(null, (int)HttpStatusCode.InternalServerError, ErrorMessage);
        }

        [HttpPost, Route("Delete")]
        public async Task<IActionResult> Delete(int id)
        {
            bool isSuccess = true;
            int result = 101;
            if (isSuccess)
                return _ObjectResponse.Create(result, (int)HttpStatusCode.OK, SuccessMessage);
            return _ObjectResponse.Create(null, (int)HttpStatusCode.InternalServerError, ErrorMessage);
        }

        [HttpPost, Route("Upsert")]
        public async Task<IActionResult> Upsert(CodeMasterModel code)
        {
            bool isSuccess = true;
            var result = new CodeMasterModel();
            if (isSuccess)
                return _ObjectResponse.Create(result, (int)HttpStatusCode.OK, SuccessMessage);
            return _ObjectResponse.Create(null, (int)HttpStatusCode.InternalServerError, ErrorMessage);
        }
       

    }
}
