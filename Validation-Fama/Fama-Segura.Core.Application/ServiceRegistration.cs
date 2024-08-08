
using Fama_Segura.Core.Application.Interfaces.Services;
using Fama_Segura.Core.Application.Services;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

namespace Fama_Segura.Core.Application
{
    public static class ServiceRegistration
    {
        public static void AddApplicationLayer(this IServiceCollection services)
        {
            #region Services
            services.AddAutoMapper(Assembly.GetExecutingAssembly());

            services.AddScoped<IUserService, UserService>();
        #endregion

        }
    }
}
