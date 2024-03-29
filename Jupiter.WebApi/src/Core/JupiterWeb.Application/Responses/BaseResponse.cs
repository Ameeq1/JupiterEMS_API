using System.Collections.Generic;

namespace JupiterWeb.Application.Responses
{
    public class Response<T>
    {
        public Response()
        {
        }
        public Response(T data, string message = null)
        {
            Succeeded = true;
            Message = message;
            Data = data;
        }
        public Response(string message)
        {
            Succeeded = false;
            Message = message;
        }
        public bool Succeeded { get; set; }
        public string Message { get; set; }
        public List<string> Errors { get; set; }
        public T Data { get; set; }
    }

    public class PagedResponse<T> : Response<T>
    {
        public int TotalCount { get; set; }
        public int PageSize { get; set; }

        public PagedResponse(T data, int totalCount, int pageSize)
        {
            TotalCount = totalCount;
            PageSize = pageSize;
            Data = data;
            Message = null;
            Succeeded = true;
            Errors = null;
        }
    }
}
