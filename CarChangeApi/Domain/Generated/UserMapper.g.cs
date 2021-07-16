using System;
using System.Linq;
using System.Linq.Expressions;
using CarChangeApi.Domain.Dtos;
using CarChangeApi.Domain.Mapster.Mappers;
using CarChangeApi.Domain.Models;

namespace CarChangeApi.Domain.Generated
{
    public partial class UserMapper : IUserMapper
    {
        public Expression<Func<User, UserDto>> ProjectToDto => p1 => new UserDto()
        {
            Id = p1.Id,
            Advertisements = p1.Advertisements.Select<Advertisement, AdvertisementDto>(p2 => new AdvertisementDto()
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
            }),
            Email = p1.Email,
            UserName = p1.UserName
        };
        public UserDto MapToDto(User p3)
        {
            return p3 == null ? null : new UserDto()
            {
                Id = p3.Id,
                Advertisements = p3.Advertisements == null ? null : p3.Advertisements.Select<Advertisement, AdvertisementDto>(funcMain1),
                Email = p3.Email,
                UserName = p3.UserName
            };
        }
        public User MapToExisting(UserDto p5, User p6)
        {
            if (p5 == null)
            {
                return null;
            }
            User result = p6 ?? new User();
            
            result.Advertisements = p5.Advertisements == null ? null : p5.Advertisements.Select<AdvertisementDto, Advertisement>(funcMain2);
            result.Id = p5.Id;
            result.UserName = p5.UserName;
            result.Email = p5.Email;
            return result;
            
        }
        
        private AdvertisementDto funcMain1(Advertisement p4)
        {
            return p4 == null ? null : new AdvertisementDto()
            {
                AdvertisementId = p4.AdvertisementId,
                Title = p4.Title,
                Description = p4.Description,
                Price = p4.Price,
                Location = p4.Location,
                CreatedAt = p4.CreatedAt,
                Ends = p4.Ends,
                UserId = p4.UserId,
                Car = p4.Car == null ? null : new CarDto()
                {
                    CarId = p4.Car.CarId,
                    Type = p4.Car.Type,
                    Mark = p4.Car.Mark,
                    Model = p4.Car.Model,
                    Color = p4.Car.Color,
                    EngineCapacity = p4.Car.EngineCapacity,
                    HorsePower = p4.Car.HorsePower,
                    ProductionYear = p4.Car.ProductionYear,
                    MileageKm = p4.Car.MileageKm,
                    MileageMl = p4.Car.MileageMl,
                    Doors = p4.Car.Doors,
                    GearboxType = p4.Car.GearboxType,
                    AdvertisementId = p4.Car.AdvertisementId
                }
            };
        }
        
        private Advertisement funcMain2(AdvertisementDto p7)
        {
            return p7 == null ? null : new Advertisement()
            {
                AdvertisementId = p7.AdvertisementId,
                Title = p7.Title,
                Description = p7.Description,
                Price = p7.Price,
                Location = p7.Location,
                CreatedAt = p7.CreatedAt,
                Ends = p7.Ends,
                UserId = p7.UserId,
                Car = p7.Car == null ? null : new Car()
                {
                    CarId = p7.Car.CarId,
                    Type = p7.Car.Type,
                    Mark = p7.Car.Mark,
                    Model = p7.Car.Model,
                    Color = p7.Car.Color,
                    EngineCapacity = p7.Car.EngineCapacity,
                    HorsePower = p7.Car.HorsePower,
                    ProductionYear = p7.Car.ProductionYear,
                    MileageKm = p7.Car.MileageKm,
                    MileageMl = p7.Car.MileageMl,
                    Doors = p7.Car.Doors,
                    GearboxType = p7.Car.GearboxType,
                    AdvertisementId = p7.Car.AdvertisementId
                }
            };
        }
    }
}