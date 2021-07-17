using CarChangeApi.Contracts.Requests;
using CarChangeApi.Contracts.Responses;
using CarChangeApi.Domain.Utils;
using CarChangeApi.Services;
using MediatR;
using Microsoft.Extensions.Logging;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace CarChangeApi.Commands
{
    public class AdvertisementDeleteCommand : BaseRequest, IRequest<AdvertisementDeleteResponse>
    {
        public long IdToDelete { get; private set; }

        public AdvertisementDeleteCommand(long idToDelete)
        {
            IdToDelete = idToDelete;
        }
    }

    public class AdvertisementDeleteCommandHandler : IRequestHandler<AdvertisementDeleteCommand, AdvertisementDeleteResponse>
    {
        private readonly ILogger<AdvertisementDeleteCommand> _logger;
        private readonly IAdvertisementService _advertisementService;
        public AdvertisementDeleteCommandHandler(ILogger<AdvertisementDeleteCommand> logger, IAdvertisementService advertisementService)
        {
            _logger = logger;
            _advertisementService = advertisementService;
        }

        public async Task<AdvertisementDeleteResponse> Handle(AdvertisementDeleteCommand request, CancellationToken cancellationToken)
        {
            _logger.LogInformation("AdvertisementCreateCommandHandler");
            try
            {
                await _advertisementService.DeleteAdvertisementAsync(request.IdToDelete, request.UserId);
            }
            catch (Exception e) 
            {
                var response = new AdvertisementDeleteResponse()
                {
                    Succeded = false,
                    Errors = ErrorListGenerator.CreateError(e.Message)
                };
                return response; 
            };

            return new AdvertisementDeleteResponse()
            {
                Succeded = true,
                Data = $"Deleted: {request.IdToDelete}",
                Errors = ErrorListGenerator.CreateEmpty()
            };
        }
    }
}
