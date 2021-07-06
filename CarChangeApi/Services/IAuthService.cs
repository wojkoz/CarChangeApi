using CarChangeApi.Contracts.Requests;
using CarChangeApi.Contracts.Responses;
using Microsoft.AspNetCore.Identity;
using System.Threading.Tasks;

namespace CarChangeApi.Services
{
    public interface IAuthService
    {
        Task<IdentityResult> RegisterAsync(AuthRegisterRequest authRegisterRequest);
        Task<UserLoginResponse> LoginAsync(AuthLoginRequest authLoginRequest);
    }
}
