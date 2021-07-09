using CarChangeApi.Domain.Generated;
using CarChangeApi.Domain.Models;

namespace CarChangeApi.Domain.Generated
{
    public static partial class CarMapper
    {
        public static CarDto AdaptToDto(this Car p1)
        {
            return p1 == null ? null : new CarDto()
            {
                CarId = p1.CarId,
                Type = p1.Type,
                Mark = p1.Mark,
                Model = p1.Model,
                Color = p1.Color,
                EngineCapacity = p1.EngineCapacity,
                HorsePower = p1.HorsePower,
                ProductionYear = p1.ProductionYear,
                MileageKm = p1.MileageKm,
                MileageMl = p1.MileageMl,
                Doors = p1.Doors,
                GearboxType = p1.GearboxType,
                AdvertisementId = p1.AdvertisementId
            };
        }
        public static CarDto AdaptTo(this Car p2, CarDto p3)
        {
            if (p2 == null)
            {
                return null;
            }
            CarDto result = p3 ?? new CarDto();
            
            result.CarId = p2.CarId;
            result.Type = p2.Type;
            result.Mark = p2.Mark;
            result.Model = p2.Model;
            result.Color = p2.Color;
            result.EngineCapacity = p2.EngineCapacity;
            result.HorsePower = p2.HorsePower;
            result.ProductionYear = p2.ProductionYear;
            result.MileageKm = p2.MileageKm;
            result.MileageMl = p2.MileageMl;
            result.Doors = p2.Doors;
            result.GearboxType = p2.GearboxType;
            result.AdvertisementId = p2.AdvertisementId;
            return result;
            
        }
        public static CarDto AdaptToDto(this Car p4)
        {
            return p4 == null ? null : new CarDto()
            {
                CarId = p4.CarId,
                Type = p4.Type,
                Mark = p4.Mark,
                Model = p4.Model,
                Color = p4.Color,
                EngineCapacity = p4.EngineCapacity,
                HorsePower = p4.HorsePower,
                ProductionYear = p4.ProductionYear,
                MileageKm = p4.MileageKm,
                MileageMl = p4.MileageMl,
                Doors = p4.Doors,
                GearboxType = p4.GearboxType,
                AdvertisementId = p4.AdvertisementId
            };
        }
        public static CarDto AdaptTo(this Car p5, CarDto p6)
        {
            if (p5 == null)
            {
                return null;
            }
            CarDto result = p6 ?? new CarDto();
            
            result.CarId = p5.CarId;
            result.Type = p5.Type;
            result.Mark = p5.Mark;
            result.Model = p5.Model;
            result.Color = p5.Color;
            result.EngineCapacity = p5.EngineCapacity;
            result.HorsePower = p5.HorsePower;
            result.ProductionYear = p5.ProductionYear;
            result.MileageKm = p5.MileageKm;
            result.MileageMl = p5.MileageMl;
            result.Doors = p5.Doors;
            result.GearboxType = p5.GearboxType;
            result.AdvertisementId = p5.AdvertisementId;
            return result;
            
        }
    }
}