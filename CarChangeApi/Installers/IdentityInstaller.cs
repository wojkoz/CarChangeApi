using CarChangeApi.Domain.DatabaseContext;
using CarChangeApi.Domain.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace CarChangeApi.Installers
{
    public class IdentityInstaller : IInstaller
    {
        public void InstallServices(IServiceCollection services, IConfiguration configuration)
        {
            services.AddIdentity<User, IdentityRole>()
                .AddEntityFrameworkStores<MyDBContext>()
                .AddDefaultTokenProviders();

            services.AddIdentityCore<User>(u => u.User.RequireUniqueEmail = true);

        }
    }
}
