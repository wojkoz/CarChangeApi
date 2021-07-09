using CarChangeApi.Domain.Models;
using Mapster;
using System.Reflection;

namespace CarChangeApi.Domain.Mapster
{
    public class MyRegister : ICodeGenerationRegister
    {
        public void Register(CodeGenerationConfig config)
        {
            
             config.AdaptTo("[name]Dto")
                .ForAllTypesInNamespace(Assembly.GetExecutingAssembly(), "CarChangeApi.Domain.Models");

            config.AdaptTo("[name]Dto")
                .ForType<Advertisement>(ctx => {
                    ctx.Ignore(a => a.User);
                });
            
            config.AdaptTo("[name]Dto")
                .ForType<Car>(ctx => {
                    ctx.Ignore(c => c.Advertisement);
                });
            
            config.AdaptTo("[name]Dto")
                .ForType<User>(ctx => {
                    ctx.Ignore(u => u.LockoutEnd);
                    ctx.Ignore(u => u.TwoFactorEnabled);
                    ctx.Ignore(u => u.PhoneNumberConfirmed);
                    ctx.Ignore(u => u.PhoneNumber);
                    ctx.Ignore(u => u.ConcurrencyStamp);
                    ctx.Ignore(u => u.SecurityStamp);
                    ctx.Ignore(u => u.PasswordHash);
                    ctx.Ignore(u => u.EmailConfirmed);
                    ctx.Ignore(u => u.NormalizedEmail);
                    ctx.Ignore(u => u.NormalizedUserName);
                    ctx.Ignore(u => u.LockoutEnabled);
                    ctx.Ignore(u => u.AccessFailedCount);
                });

            config.GenerateMapper("[name]Mapper")
                .ForType<User>()
                .ForType<Car>()
                .ForType<Advertisement>(); 
             
        }
    }
}
