using System.Net;

namespace API.Models
{
    public class ApiErrorResponseModel
    {
        public ApiErrorResponseModel(HttpStatusCode statusCode)
        {
            StatusCode = (int)statusCode;
        }

        public int StatusCode { get; private set; }

        public string Message { get; set; }
    }
}
