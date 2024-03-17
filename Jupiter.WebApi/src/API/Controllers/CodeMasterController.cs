﻿using Jupiter.Business.Core.Interface;
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
      
        [HttpGet, Route("GetCodeDetailsById")]
        public async Task<IActionResult> GetCodeDetailsById(int id)
        {
            bool isSuccess = true;
            CodeMasterModel result = new CodeMasterModel();
            if (isSuccess)
                return _ObjectResponse.Create(result, (int)HttpStatusCode.OK);
            return _ObjectResponse.Create(null, (int)HttpStatusCode.InternalServerError, "Internal Server Error");
        }

        [HttpGet, Route("GetAllCodeList")]
        public async Task<IActionResult> GetAllCodeList()
        {
            bool isSuccess = true;
            List<CodeMasterModel> result = new List<CodeMasterModel>() { new CodeMasterModel()};
            if (isSuccess)
                return _ObjectResponse.Create(result, (int)HttpStatusCode.OK);
            return _ObjectResponse.Create(null, (int)HttpStatusCode.InternalServerError, "Internal Server Error");
        }

        [HttpPost, Route("DeleteCode")]
        public async Task<IActionResult> DeleteCode(int id)
        {
            bool isSuccess = true;
            int result = 101;
            if (isSuccess)
                return _ObjectResponse.Create(result, (int)HttpStatusCode.OK);
            return _ObjectResponse.Create(null, (int)HttpStatusCode.InternalServerError, "Internal Server Error");
        }

        [HttpPost, Route("UpsertCode")]
        public async Task<IActionResult> UpsertCode(CodeMasterModel code)
        {
            bool isSuccess = true;
            int result = 101;  
            if (isSuccess)
                return _ObjectResponse.Create(result, (int)HttpStatusCode.OK);
            return _ObjectResponse.Create(null, (int)HttpStatusCode.InternalServerError, "Internal Server Error");
        }
       

    }
}