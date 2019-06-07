using Microsoft.AspNetCore.Builder;

namespace DigitalTraining.ActiveDirectory
{
    public static class MiddlewareExtensions
    {
        public static IApplicationBuilder UseAdMiddleware(this IApplicationBuilder builder)
        {
            return builder.UseMiddleware<AdUserMiddleware>();
        }
    }
}