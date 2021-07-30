using CarChangeApi.Contracts.Requests;
using CarChangeApi.Contracts.Responses;
using CarChangeApi.Domain.Dtos;
using CarChangeApi.Domain.Utils;
using CarChangeApi.Services;
using MediatR;
using Microsoft.Extensions.Logging;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace CarChangeApi.Commands
{
    public class AdvertisementUpdateCommand : BaseRequest, IRequest<AdvertisementUpdateResponse>
    {
        public AdvertisementDto Advertisement { get; private set; }

        public AdvertisementUpdateCommand(AdvertisementDto dto)
        {
            this.Advertisement = dto;
        }
    }

    public class AdvertisementUpdateCommandHandler : IRequestHandler<AdvertisementUpdateCommand, AdvertisementUpdateResponse>
    {
        private readonly ILogger<AdvertisementUpdateCommand> _logger;
        private readonly IAdvertisementService _advertisementService;
        public AdvertisementUpdateCommandHandler(ILogger<AdvertisementUpdateCommand> logger, IAdvertisementService advertisementService)
        {
            _logger = logger;
            _advertisementService = advertisementService;
        }

        public async Task<AdvertisementUpdateResponse> Handle(AdvertisementUpdateCommand request, CancellationToken cancellationToken)
        {
            _logger.LogInformation("AdvertisementCreateCommandHandler");
            try
            {
                var dto = await _advertisementService.UpdateAdvertisementAsync(request.Advertisement, request.UserId);
                return new AdvertisementUpdateResponse()
                {
                    Succeded = true,
                    Data = dto,
                    Errors = ErrorListGenerator.CreateEmpty()
                };
            }
            catch (Exception e)
            {
                var response = new AdvertisementUpdateResponse()
                {
                    Succeded = false,
                    Errors = ErrorListGenerator.CreateError(e.Message)
                };
                return response;
            };


        }
    }
}
