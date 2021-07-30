using CarChangeApi.Domain.Generated;
using CarChangeApi.Domain.Mapster.Mappers;
using CarChangeApi.Pipes;
using CarChangeApi.Repositories;
using CarChangeApi.Repositories.Impl;
using CarChangeApi.Services;
using CarChangeApi.Services.impl;
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

            services.AddTransient<IAdvertisementRepository, AdvertisementRepository>();
            services.AddTransient<ICarRepository, CarRepository>();
            services.AddTransient<IAuthService, AuthService>();
            services.AddTransient<IAdvertisementService, AdvertisementService>();
            services.AddTransient<IAdvertisementMapper, AdvertisementMapper>();

            services.AddScoped(typeof(IPipelineBehavior<,>), typeof(UserIdPipe<,>));
            services.AddMediatR(typeof(Startup));

            services.AddCors(o =>
                o.AddPolicy("CorsAllowAll", cors =>
                    cors.AllowAnyOrigin()
                        .AllowAnyMethod()
                        .AllowAnyHeader()
                    )
                );

            services.AddControllers();
        }
    }
}
