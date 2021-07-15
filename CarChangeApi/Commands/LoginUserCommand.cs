using CarChangeApi.Contracts.Requests;
using CarChangeApi.Contracts.Responses;
using CarChangeApi.Services;
using MediatR;
using Microsoft.Extensions.Logging;
using System.Threading;
using System.Threading.Tasks;

namespace CarChangeApi.Commands
{
    public class LoginUserCommand : IRequest<UserLoginResponse>
    {
        public AuthLoginRequest LoginRequest { get; set; }

        public LoginUserCommand(AuthLoginRequest loginRequest)
        {
            LoginRequest = loginRequest;
        }
    }

    public class LoginUserCommandHandler : IRequestHandler<LoginUserCommand, UserLoginResponse>
    {
        private readonly ILogger<LoginUserCommand> _logger;
        private readonly IAuthService _authService;
        public LoginUserCommandHandler(ILogger<LoginUserCommand> logger, IAuthService authService)
        {
            _logger = logger;
            _authService = authService;
        }

        public async Task<UserLoginResponse> Handle(LoginUserCommand request, CancellationToken cancellationToken)
        {
            _logger.LogInformation("LoginUserCommand handler");

            return await _authService.LoginAsync(request.LoginRequest);
        }
    }
}