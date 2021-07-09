using CarChangeApi.Contracts.Requests;
using CarChangeApi.Domain.Generated;
using CarChangeApi.Repositories;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CarChangeApi.Services.impl
{
    public class AdvertisementService : IAdvertisementService
    {
        private readonly ILogger<AdvertisementService> _logger;
        private readonly ICarRepository _carRepository;
        private readonly IAdvertisementRepository _advertisementRepository;

        public AdvertisementService(IAdvertisementRepository advertisementRepository, ICarRepository carRepository, ILogger<AdvertisementService> logger)
        {
            _advertisementRepository = advertisementRepository;
            _carRepository = carRepository;
            _logger = logger;
        }

        public Task<AdvertisementDto> AddAdvertisementAsync(AdvertisementCreateRequest createRequest, string token)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAdvertisementAsync(long todoId, string token)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<AdvertisementDto>> GetAdvertisementListAsync()
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<AdvertisementDto>> GetAdvertisementListByUserAsync(string token)
        {
            throw new NotImplementedException();
        }

        public Task<AdvertisementDto> UpdateAdvertisementAsync(AdvertisementDto dto, string token)
        {
            throw new NotImplementedException();
        }
    }
}
