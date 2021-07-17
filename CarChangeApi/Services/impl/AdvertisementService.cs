using CarChangeApi.Contracts.Requests;
using CarChangeApi.Domain.Dtos;
using CarChangeApi.Domain.Models;
using CarChangeApi.Repositories;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Linq;
using Mapster;

namespace CarChangeApi.Services.impl
{
    public class AdvertisementService : IAdvertisementService
    {
        private readonly ILogger<AdvertisementService> _logger;
        private readonly ICarRepository _carRepository;
        private readonly IAdvertisementRepository _advertisementRepository;
        private readonly UserManager<User> _userManager;

        public AdvertisementService(IAdvertisementRepository advertisementRepository, ICarRepository carRepository, ILogger<AdvertisementService> logger, UserManager<User> userManager)
        {
            _advertisementRepository = advertisementRepository;
            _carRepository = carRepository;
            _logger = logger;
            _userManager = userManager;
        }

        public async Task<AdvertisementDto> AddAdvertisementAsync(AdvertisementCreateRequest createRequest, string userId)
        {
            var advertisementDto = createRequest.Advertisement;

            var user = await _userManager.FindByIdAsync(userId);
            var advertisement = advertisementDto.ToAdvertisement(user);

            await _advertisementRepository.InsertAsync(advertisement);

            await _advertisementRepository.Save();

            return advertisement.Adapt<AdvertisementDto>();
        }

        public async Task DeleteAdvertisementAsync(long entityId, string userId)
        {
            var isOwner = await IsOwner(entityId, userId);

            if (isOwner)
            {
                await _advertisementRepository.DeleteAsync(entityId);
                await _advertisementRepository.Save();
                return;
            }

            throw new NotImplementedException();
        }

        public async Task<IEnumerable<AdvertisementDto>> GetAdvertisementListAsync()
        {
            var advertisements = await _advertisementRepository.GetAllAsync();

            return advertisements.Adapt<IEnumerable<AdvertisementDto>>();
        }

        public Task<IEnumerable<AdvertisementDto>> GetAdvertisementListByUserAsync(string userId)
        {
            throw new NotImplementedException();
        }

        public Task<AdvertisementDto> UpdateAdvertisementAsync(AdvertisementDto dto, string userId)
        {
            throw new NotImplementedException();
        }

        private async Task<bool> IsOwner(long advertisementId, string userId)
        {
            var advertisement = await _advertisementRepository.GetAsync(x => x.AdvertisementId == advertisementId);
            bool result = advertisement is not null && advertisement.UserId == userId;

            return result;
        }
    }
}
