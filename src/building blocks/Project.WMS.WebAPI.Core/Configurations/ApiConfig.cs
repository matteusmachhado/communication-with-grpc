using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Projetct.WMS.Core.Interfaces;
using Projetct.WMS.Core.Services;

namespace Project.WMS.WebAPI.Core.Configurations
{
    public static class ApiConfig
    {
        public static void AddApiServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddScoped<INotificationService, NotificationService>();
        }
    }
}
