using Microsoft.AspNetCore.Mvc;
using Jupiter.Business.Models;

namespace Jupiter.WebApi.Helpers.Response
{
    public class ResponseHandler<T> : IResponseHandler<T> where T : class
    {
        public IActionResult Create(T Data, int? StatusCode, string Message = null, string ReturnToUrl = null, List<string> errorMessages = null)
        {
            APIResponseEntity<T> retResult = new APIResponseEntity<T>();
            retResult.Object = Data;
            retResult.Message = Message;
            retResult.ReturnToUrl = ReturnToUrl;
            retResult.ErrorMessages = errorMessages;

            if (StatusCode == 200)
                retResult.Success = true;
            else
                retResult.Success = false;

            return new ObjectResult(retResult) { StatusCode = StatusCode };
        }

        public IActionResult CreateError(T Data, int? StatusCode, Exception ex = null, string Message = null, string ReturnToUrl = null)
        {
            var err = new List<string>();
            if (ex != null)
            {
                err.Add(ex.Message);
                err.Add(ex.InnerException?.Message);
            }

            APIResponseEntity<T> retResult = new APIResponseEntity<T>();
            retResult.Object = Data;
            retResult.Message = Message;
            retResult.ReturnToUrl = ReturnToUrl;
            retResult.ErrorMessages = err;

            if (StatusCode == 200)
                retResult.Success = true;
            else
                retResult.Success = false;

            return new ObjectResult(retResult) { StatusCode = StatusCode };
        }

        public IActionResult CreateData(T Data, int? StatusCode)
        {
            return new ObjectResult(Data) { StatusCode = StatusCode };
        }
    }
}
