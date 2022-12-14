using API.Models;
using System.Net;
using System.Text.Json;

namespace API.Middleware
{
    public class ApplicationErrorInterceptorMiddleware
    {
        private readonly RequestDelegate _next;

        public ApplicationErrorInterceptorMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task InvokeAsync(
            HttpContext context)
        {
            try
            {
                await _next(context);
            }
            catch (Exception ex)
            {
                OnErrorr(ex, context);
            }
        }

        protected void OnErrorr(Exception ex, HttpContext context)
        {
 
            if (!context.Response.HasStarted)
            {
                var errorResponse = GetApiErrorResponse();
                var serializedResponse = JsonSerializer.Serialize(errorResponse);

                context.Response.ContentType = "application/json";
                context.Response.StatusCode = (int)HttpStatusCode.InternalServerError;
                context.Response.WriteAsync(serializedResponse);
            }
        }

        protected ApiErrorResponseModel GetApiErrorResponse()
        {
            var errorResponse = new ApiErrorResponseModel(HttpStatusCode.InternalServerError)
            {
                Message = "Server failed to  your request."
            };

            return errorResponse;
        }
    }
}
