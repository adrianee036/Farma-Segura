using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Fama_Segura.Core.Application.Interfaces.Services;
using Fama_Segura.Core.Domain.Settings;
using Fama_Segura.Infrastructure.Shared.Services;

namespace Fama_Segura.Infrastructure.Shared
{
    public static class ServiceRegistration
    {
        public static void AddSharedLayer(this IServiceCollection services, IConfiguration _config)
        {
            services.Configure<MailSettings>(_config.GetSection("MailSettings"));         
            services.AddTransient<IEmailService, EmailService>();
        }
    }
}
