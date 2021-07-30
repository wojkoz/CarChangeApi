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
using CarChangeApi.Domain.Mapster.Mappers;

namespace CarChangeApi.Services.impl
{
    public class AdvertisementService : IAdvertisementService
    {
        private readonly ILogger<AdvertisementService> _logger;
        private readonly ICarRepository _carRepository;
        private readonly IAdvertisementRepository _advertisementRepository;
        private readonly UserManager<User> _userManager;
        private readonly IAdvertisementMapper _advertisementMapper;

        public AdvertisementService(IAdvertisementRepository advertisementRepository, ICarRepository carRepository, ILogger<AdvertisementService> logger, UserManager<User> userManager, IAdvertisementMapper advertisementMapper)
        {
            _advertisementRepository = advertisementRepository;
            _carRepository = carRepository;
            _logger = logger;
            _userManager = userManager;
            _advertisementMapper = advertisementMapper;
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

            throw new Exception($"Couldn't delete Advertisement with ID: {entityId} for userID: {userId}");
        }

        public async Task<IEnumerable<AdvertisementDto>> GetAdvertisementListAsync()
        {
            var advertisements = await _advertisementRepository.GetAllAsync(includes: new List<string>() { "Car" });

            return advertisements.Adapt<IEnumerable<AdvertisementDto>>();
        }

        public async Task<IEnumerable<AdvertisementDto>> GetAdvertisementListByUserAsync(string userId)
        {
            var advertisements = await _advertisementRepository.GetAllAsync(
                    expression: a => a.UserId == userId
                    , includes: new List<string>() { "Car" }
                );

            return advertisements.Adapt<IEnumerable<AdvertisementDto>>();
        }

        public async Task<AdvertisementDto> UpdateAdvertisementAsync(AdvertisementDto dto, string userId)
        {
            var advertisement = await _advertisementRepository.GetAsync(
                    a => a.AdvertisementId == dto.AdvertisementId
                    && a.UserId == userId
                );
            var car = await _carRepository.GetAsync(
                c => c.CarId == dto.Car.CarId
                && c.AdvertisementId == advertisement.AdvertisementId
                );


            if (advertisement is null || car is null)
            {
                throw new Exception($"Couldn't find Advertisement with ID: {dto.AdvertisementId} for userID: {userId}");
            }

            advertisement.Car = car;

            var updatedEntity = _advertisementMapper.MapToExisting(dto, advertisement);

            _advertisementRepository.Update(updatedEntity);
            await _advertisementRepository.Save();

            return _advertisementMapper.MapToDto(updatedEntity);
        }

        private async Task<bool> IsOwner(long advertisementId, string userId)
        {
            var advertisement = await _advertisementRepository.GetAsync(x => x.AdvertisementId == advertisementId);
            bool result = advertisement is not null && advertisement.UserId == userId;

            return result;
        }
    }
}
