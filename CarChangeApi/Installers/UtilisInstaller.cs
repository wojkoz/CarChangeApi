using MediatR;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace CarChangeApi.Installers
{
    public class UtilisInstaller : IInstaller
    {
        public void InstallServices(IServiceCollection services, IConfiguration configuration)
        {
            services.AddMediatR(typeof(Startup));

            services.AddControllers();
        }
    }
}
