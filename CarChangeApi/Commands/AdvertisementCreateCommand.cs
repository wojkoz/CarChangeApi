
using CarChangeApi.Contracts.Requests;
using CarChangeApi.Contracts.Responses;
using CarChangeApi.Services;
using MediatR;
using Microsoft.Extensions.Logging;
using System.Threading;
using System.Threading.Tasks;

namespace CarChangeApi.Commands
{
    public class AdvertisementCreateCommand : BaseRequest, IRequest<AdvertisementCreateResponse>
    {
        public AdvertisementCreateRequest CreateRequest { get; private set; }

        public AdvertisementCreateCommand(AdvertisementCreateRequest createRequest)
        {
            CreateRequest = createRequest;
        }
    }

    public class AdvertisementCreateCommandHandler : IRequestHandler<AdvertisementCreateCommand, AdvertisementCreateResponse>
    {
        private readonly ILogger<AdvertisementCreateCommand> _logger;
        private readonly IAdvertisementService _advertisementService;
        public AdvertisementCreateCommandHandler(ILogger<AdvertisementCreateCommand> logger, IAdvertisementService advertisementService)
        {
            _logger = logger;
            _advertisementService = advertisementService;
        }

        public async Task<AdvertisementCreateResponse> Handle(AdvertisementCreateCommand request, CancellationToken cancellationToken)
        {
            _logger.LogInformation("RegisterUserCommand handler");

            var result = await _advertisementService.AddAdvertisementAsync(request.CreateRequest, request.UserId);

            return new AdvertisementCreateResponse() { Advertisement = result, Succeded = true};

            //if (result is null)
            //{
            //    IEnumerable<IdentityError> errors = new List<IdentityError>() {
            //            new(){Code = "-1", Description = "User with that email already exists"}
            //        };

            //    return new UserRegisterResponse() { Succeded = false, Errors = errors };
            //}

            //return new UserRegisterResponse() { Succeded = result.Succeeded, Errors = result.Errors };

        }

    }
}
