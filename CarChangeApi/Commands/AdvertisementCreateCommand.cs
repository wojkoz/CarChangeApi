
using CarChangeApi.Contracts.Requests;
using CarChangeApi.Contracts.Responses;
using CarChangeApi.Services;
using MediatR;
using Microsoft.Extensions.Logging;
using System.Threading.Tasks;

namespace CarChangeApi.Commands
{
    public class AdvertisementCreateCommand
    {
        public class Command : IRequest<Task<AdvertisementCreateResponse>>
        {
            public AdvertisementCreateRequest CreateRequest { get; set; }
        }

        public class Handler : RequestHandler<Command, Task<AdvertisementCreateResponse>>
        {
            private readonly ILogger<AdvertisementCreateCommand> _logger;
            private readonly IAdvertisementService _advertisementService ;
            public Handler(ILogger<AdvertisementCreateCommand> logger, IAdvertisementService advertisementService)
            {
                _logger = logger;
                _advertisementService = advertisementService;
            }
            protected override async Task<AdvertisementCreateResponse> Handle(Command request)
            {
                _logger.LogInformation("RegisterUserCommand handler");

                var result = await _advertisementService.ad

               /* var result = await _authService.RegisterAsync(request.RegisterRequest);

                if (result is null)
                {
                    IEnumerable<IdentityError> errors = new List<IdentityError>() {
                        new(){Code = "-1", Description = "User with that email already exists"}
                    };

                    return new UserRegisterResponse() { Succeded = false, Errors = errors };
                }

                return new UserRegisterResponse() { Succeded = result.Succeeded, Errors = result.Errors };
               */

            }
        }
    }
}
