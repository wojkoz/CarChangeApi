using CarChangeApi.Services;
using CarChangeApi.Services.impl;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace CarChangeApi.Installers
{
    public class DIInstaller : IInstaller
    {
        public void InstallServices(IServiceCollection services, IConfiguration configuration)
        {
            services.AddTransient<IAuthService, AuthService>();
        }
    }
}
