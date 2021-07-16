using System;
using System.Linq.Expressions;
using CarChangeApi.Domain.Dtos;
using CarChangeApi.Domain.Mapster.Mappers;
using CarChangeApi.Domain.Models;

namespace CarChangeApi.Domain.Generated
{
    public partial class AdvertisementMapper : IAdvertisementMapper
    {
        public Expression<Func<Advertisement, AdvertisementDto>> ProjectToDto => p1 => new AdvertisementDto()
        {
            AdvertisementId = p1.AdvertisementId,
            Title = p1.Title,
            Description = p1.Description,
            Price = p1.Price,
            Location = p1.Location,
            CreatedAt = p1.CreatedAt,
            Ends = p1.Ends,
            UserId = p1.UserId,
            Car = p1.Car == null ? null : new CarDto()
            {
                CarId = p1.Car.CarId,
                Type = p1.Car.Type,
                Mark = p1.Car.Mark,
                Model = p1.Car.Model,
                Color = p1.Car.Color,
                EngineCapacity = p1.Car.EngineCapacity,
                HorsePower = p1.Car.HorsePower,
                ProductionYear = p1.Car.ProductionYear,
                MileageKm = p1.Car.MileageKm,
                MileageMl = p1.Car.MileageMl,
                Doors = p1.Car.Doors,
                GearboxType = p1.Car.GearboxType,
                AdvertisementId = p1.Car.AdvertisementId
            }
        };
        public AdvertisementDto MapToDto(Advertisement p2)
        {
            return p2 == null ? null : new AdvertisementDto()
            {
                AdvertisementId = p2.AdvertisementId,
                Title = p2.Title,
                Description = p2.Description,
                Price = p2.Price,
                Location = p2.Location,
                CreatedAt = p2.CreatedAt,
                Ends = p2.Ends,
                UserId = p2.UserId,
                Car = p2.Car == null ? null : new CarDto()
                {
                    CarId = p2.Car.CarId,
                    Type = p2.Car.Type,
                    Mark = p2.Car.Mark,
                    Model = p2.Car.Model,
                    Color = p2.Car.Color,
                    EngineCapacity = p2.Car.EngineCapacity,
                    HorsePower = p2.Car.HorsePower,
                    ProductionYear = p2.Car.ProductionYear,
                    MileageKm = p2.Car.MileageKm,
                    MileageMl = p2.Car.MileageMl,
                    Doors = p2.Car.Doors,
                    GearboxType = p2.Car.GearboxType,
                    AdvertisementId = p2.Car.AdvertisementId
                }
            };
        }
        public Advertisement MapToExisting(AdvertisementDto p3, Advertisement p4)
        {
            if (p3 == null)
            {
                return null;
            }
            Advertisement result = p4 ?? new Advertisement();
            
            result.AdvertisementId = p3.AdvertisementId;
            result.Title = p3.Title;
            result.Description = p3.Description;
            result.Price = p3.Price;
            result.Location = p3.Location;
            result.CreatedAt = p3.CreatedAt;
            result.Ends = p3.Ends;
            result.UserId = p3.UserId;
            result.Car = funcMain1(p3.Car, result.Car);
            return result;
            
        }
        
        private Car funcMain1(CarDto p5, Car p6)
        {
            if (p5 == null)
            {
                return null;
            }
            Car result = p6 ?? new Car();
            
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