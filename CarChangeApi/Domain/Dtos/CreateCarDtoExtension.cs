using CarChangeApi.Domain.Models;

namespace CarChangeApi.Domain.Dtos
{
    public static class CreateCarDtoExtension
    {
        public static Car ToCar(this CreateCarDto dto)
        {
            return new Car()
            {
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
                Type = dto.Type,
            };
        }
    }
}
