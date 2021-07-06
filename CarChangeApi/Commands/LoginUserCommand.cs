using CarChangeApi.Contracts.Requests;
using CarChangeApi.Contracts.Responses;
using CarChangeApi.Services;
using MediatR;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarChangeApi.Commands
{
    public class LoginUserCommand
    {
        public class Command : IRequest<Task<UserLoginResponse>>
        {
            public AuthLoginRequest LoginRequest { get; set; }
        }

        public class Handler : RequestHandler<Command, Task<UserLoginResponse>>
        {
            private readonly ILogger<LoginUserCommand> _logger;
            private readonly IAuthService _authService;
            public Handler(ILogger<LoginUserCommand> logger, IAuthService authService)
            {
                _logger = logger;
                _authService = authService;
            }
            protected override async Task<UserLoginResponse> Handle(Command request)
            {
                _logger.LogInformation("LoginUserCommand handler");

                return await _authService.LoginAsync(request.LoginRequest);

            }
        }
    }
}
