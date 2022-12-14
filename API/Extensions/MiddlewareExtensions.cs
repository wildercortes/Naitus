using API.Middleware;

namespace API.Extensions
{
    public static class MiddlewareExtensions
    {
        public static IApplicationBuilder UseSimpleResponseMiddleware(this IApplicationBuilder builder)
        {
            return builder.UseMiddleware<ApplicationErrorInterceptorMiddleware>();
        }
    }
}
