using CarChangeApi.Domain.Models;

namespace CarChangeApi.Domain.Dtos
{
    public static class CarDtoExtension
    {
        public static Car MapToCar(this CarDto dto)
        {
            return new()
            {
                CarId = dto.CarId,
                AdvertisementId = dto.AdvertisementId,
                Color = dto.Color,
                Doors = dto.Doors,
                EngineCapacity = dto.EngineCapacity,
                GearboxType = dto.GearboxType,
                HorsePower = dto.HorsePower,
                Mark = dto.Mark,
                MileageKm = dto.MileageKm,
                MileageMl = dto.MileageMl,
                Model = dto.Model,
                ProductionYear = dto.ProductionYear,
                Type = dto.Type
            };
        }
    }
}
