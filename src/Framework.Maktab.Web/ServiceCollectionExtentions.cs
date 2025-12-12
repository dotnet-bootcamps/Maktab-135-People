using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;

namespace Framework.Maktab.Web
{
    public static class ServiceCollectionExtentions
    {
        public static void AddMyServices(this IServiceCollection services)
        {
            //services.AddScoped()
        }

        public static void UseMiddlewares(this WebApplication application)
        {
            //application.UseMiddleware()
        }

    }
}
