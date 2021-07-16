using System;
using System.Linq.Expressions;
using CarChangeApi.Domain.Dtos;
using CarChangeApi.Domain.Mapster.Mappers;
using CarChangeApi.Domain.Models;

namespace CarChangeApi.Domain.Generated
{
    public partial class CarMapper : ICarMapper
    {
        public Expression<Func<Car, CarDto>> ProjectToDto => p1 => new CarDto()
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
        public CarDto MapToDto(Car p2)
        {
            return p2 == null ? null : new CarDto()
            {
                CarId = p2.CarId,
                Type = p2.Type,
                Mark = p2.Mark,
                Model = p2.Model,
                Color = p2.Color,
                EngineCapacity = p2.EngineCapacity,
                HorsePower = p2.HorsePower,
                ProductionYear = p2.ProductionYear,
                MileageKm = p2.MileageKm,
                MileageMl = p2.MileageMl,
                Doors = p2.Doors,
                GearboxType = p2.GearboxType,
                AdvertisementId = p2.AdvertisementId
            };
        }
        public Car MapToExisting(CarDto p3, Car p4)
        {
            if (p3 == null)
            {
                return null;
            }
            Car result = p4 ?? new Car();
            
            result.CarId = p3.CarId;
            result.Type = p3.Type;
            result.Mark = p3.Mark;
            result.Model = p3.Model;
            result.Color = p3.Color;
            result.EngineCapacity = p3.EngineCapacity;
            result.HorsePower = p3.HorsePower;
            result.ProductionYear = p3.ProductionYear;
            result.MileageKm = p3.MileageKm;
            result.MileageMl = p3.MileageMl;
            result.Doors = p3.Doors;
            result.GearboxType = p3.GearboxType;
            result.AdvertisementId = p3.AdvertisementId;
            return result;
            
        }
    }
}