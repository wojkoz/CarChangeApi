using CarChangeApi.Domain.DatabaseContext;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace CarChangeApi.Installers
{
    public class DbInstaller : IInstaller
    {
        public void InstallServices(IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<MyDBContext>(options =>
            {
                options.UseSqlServer(configuration.GetConnectionString("Default"));
            });
        }
    }
}
