using CarChangeApi.Contracts.Requests;
using CarChangeApi.Contracts.Responses;
using CarChangeApi.Domain.Utils;
using CarChangeApi.Services;
using MediatR;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace CarChangeApi.Commands
{
    public class RegisterUserCommand : IRequest<UserRegisterResponse>
    {
        public AuthRegisterRequest RegisterRequest { get; set; }

        public RegisterUserCommand(AuthRegisterRequest registerRequest)
        {
            RegisterRequest = registerRequest;
        }
    }

    public class RegisterUserCommandHandler : IRequestHandler<RegisterUserCommand, UserRegisterResponse>
    {
        private readonly ILogger<RegisterUserCommand> _logger;
        private readonly IAuthService _authService;
        public RegisterUserCommandHandler(ILogger<RegisterUserCommand> logger, IAuthService authService)
        {
            _logger = logger;
            _authService = authService;
        }

        public async Task<UserRegisterResponse> Handle(RegisterUserCommand request, CancellationToken cancellationToken)
        {
            _logger.LogInformation("RegisterUserCommand handler");

            var result = await _authService.RegisterAsync(request.RegisterRequest);

            if (result is null)
            {
                IEnumerable<IdentityError> errors = ErrorListGenerator.CreateError("User with that email already exists");

                return new UserRegisterResponse() { Succeded = false, Errors = errors };
            }

            return new UserRegisterResponse() { Succeded = result.Succeeded, Errors = result.Errors };
        }
    }
}
