using CarChangeApi.Contracts.Requests;
using CarChangeApi.Contracts.Responses;
using CarChangeApi.Services;
using MediatR;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CarChangeApi.Commands
{
    public class RegisterUserCommand
    {
        public class Command : IRequest<Task<UserRegisterResponse>>
        {
            public AuthRegisterRequest RegisterRequest { get; set; }
        }

        public class Handler : RequestHandler<Command, Task<UserRegisterResponse>>
        {
            private readonly ILogger<RegisterUserCommand> _logger;
            private readonly IAuthService _authService;
            public Handler(ILogger<RegisterUserCommand> logger, IAuthService authService)
            {
                _logger = logger;
                _authService = authService;
            }
            protected override async Task<UserRegisterResponse> Handle(Command request)
            {
                _logger.LogInformation("RegisterUserCommand handler");

                var result = await _authService.RegisterAsync(request.RegisterRequest);

                if (result is null)
                {
                    IEnumerable<IdentityError> errors = new List<IdentityError>() {
                        new(){Code = "-1", Description = "User with that email already exists"}
                    };

                    return new UserRegisterResponse() { Succeded = false, Errors = errors };
                }

                return new UserRegisterResponse() { Succeded = result.Succeeded, Errors = result.Errors };

            }
        }
    }
}
