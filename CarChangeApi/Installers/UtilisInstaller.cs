using CarChangeApi.Pipes;
using MediatR;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace CarChangeApi.Installers
{
    public class UtilisInstaller : IInstaller
    {
        public void InstallServices(IServiceCollection services, IConfiguration configuration)
        {
            services.AddHttpContextAccessor();

            services.AddScoped(typeof(IPipelineBehavior<,>), typeof(UserIdPipe<,>));
            services.AddMediatR(typeof(Startup));

            services.AddControllers();
        }
    }
}
