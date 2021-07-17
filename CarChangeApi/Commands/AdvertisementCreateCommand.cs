using CarChangeApi.Contracts.Requests;
using CarChangeApi.Contracts.Responses;
using CarChangeApi.Domain.Utils;
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
            _logger.LogInformation("AdvertisementCreateCommandHandler");

            var result = await _advertisementService.AddAdvertisementAsync(request.CreateRequest, request.UserId);

            return new AdvertisementCreateResponse() 
            { 
                Data = result, 
                Succeded = true, 
                Errors = ErrorListGenerator.CreateEmpty() 
            };
        }

    }
}
