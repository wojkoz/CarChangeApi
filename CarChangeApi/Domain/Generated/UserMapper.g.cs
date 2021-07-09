using System.Collections.Generic;
using System.Linq;
using CarChangeApi.Domain.Generated;
using CarChangeApi.Domain.Models;
using Mapster;

namespace CarChangeApi.Domain.Generated
{
    public static partial class UserMapper
    {
        private static TypeAdapterConfig TypeAdapterConfig1;
        private static TypeAdapterConfig TypeAdapterConfig2;
        
        public static UserDto AdaptToDto(this User p1)
        {
            return p1 == null ? null : new UserDto()
            {
                Advertisements = p1.Advertisements == null ? null : p1.Advertisements.Select<Advertisement, Advertisement>(funcMain1),
                Id = p1.Id,
                UserName = p1.UserName,
                Email = p1.Email
            };
        }
        public static UserDto AdaptTo(this User p3, UserDto p4)
        {
            if (p3 == null)
            {
                return null;
            }
            UserDto result = p4 ?? new UserDto();
            
            result.Advertisements = p3.Advertisements == null ? null : p3.Advertisements.Select<Advertisement, Advertisement>(funcMain2);
            result.Id = p3.Id;
            result.UserName = p3.UserName;
            result.Email = p3.Email;
            return result;
            
        }
        public static UserDto AdaptToDto(this User p6)
        {
            return p6 == null ? null : new UserDto()
            {
                Advertisements = p6.Advertisements == null ? null : p6.Advertisements.Select<Advertisement, Advertisement>(funcMain3),
                Id = p6.Id,
                UserName = p6.UserName,
                Email = p6.Email
            };
        }
        public static UserDto AdaptTo(this User p8, UserDto p9)
        {
            if (p8 == null)
            {
                return null;
            }
            UserDto result = p9 ?? new UserDto();
            
            result.Advertisements = p8.Advertisements == null ? null : p8.Advertisements.Select<Advertisement, Advertisement>(funcMain4);
            result.Id = p8.Id;
            result.UserName = p8.UserName;
            result.Email = p8.Email;
            return result;
            
        }
        
        private static Advertisement funcMain1(Advertisement p2)
        {
            return p2 == null ? null : new Advertisement()
            {
                AdvertisementId = p2.AdvertisementId,
                Title = p2.Title,
                Description = p2.Description,
                Price = p2.Price,
                Location = p2.Location,
                CreatedAt = p2.CreatedAt,
                Ends = p2.Ends,
                UserId = p2.UserId,
                User = p2.User == null ? null : new User()
                {
                    Advertisements = TypeAdapterConfig1.GetMapFunction<IEnumerable<Advertisement>, IEnumerable<Advertisement>>().Invoke(p2.User.Advertisements),
                    Id = p2.User.Id,
                    UserName = p2.User.UserName,
                    NormalizedUserName = p2.User.NormalizedUserName,
                    Email = p2.User.Email,
                    NormalizedEmail = p2.User.NormalizedEmail,
                    EmailConfirmed = p2.User.EmailConfirmed,
                    PasswordHash = p2.User.PasswordHash,
                    SecurityStamp = p2.User.SecurityStamp,
                    ConcurrencyStamp = p2.User.ConcurrencyStamp,
                    PhoneNumber = p2.User.PhoneNumber,
                    PhoneNumberConfirmed = p2.User.PhoneNumberConfirmed,
                    TwoFactorEnabled = p2.User.TwoFactorEnabled,
                    LockoutEnd = p2.User.LockoutEnd,
                    LockoutEnabled = p2.User.LockoutEnabled,
                    AccessFailedCount = p2.User.AccessFailedCount
                },
                Car = p2.Car == null ? null : new Car()
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
                    AdvertisementId = p2.Car.AdvertisementId,
                    Advertisement = TypeAdapterConfig1.GetMapFunction<Advertisement, Advertisement>().Invoke(p2.Car.Advertisement)
                }
            };
        }
        
        private static Advertisement funcMain2(Advertisement p5)
        {
            return p5 == null ? null : new Advertisement()
            {
                AdvertisementId = p5.AdvertisementId,
                Title = p5.Title,
                Description = p5.Description,
                Price = p5.Price,
                Location = p5.Location,
                CreatedAt = p5.CreatedAt,
                Ends = p5.Ends,
                UserId = p5.UserId,
                User = p5.User == null ? null : new User()
                {
                    Advertisements = TypeAdapterConfig1.GetMapFunction<IEnumerable<Advertisement>, IEnumerable<Advertisement>>().Invoke(p5.User.Advertisements),
                    Id = p5.User.Id,
                    UserName = p5.User.UserName,
                    NormalizedUserName = p5.User.NormalizedUserName,
                    Email = p5.User.Email,
                    NormalizedEmail = p5.User.NormalizedEmail,
                    EmailConfirmed = p5.User.EmailConfirmed,
                    PasswordHash = p5.User.PasswordHash,
                    SecurityStamp = p5.User.SecurityStamp,
                    ConcurrencyStamp = p5.User.ConcurrencyStamp,
                    PhoneNumber = p5.User.PhoneNumber,
                    PhoneNumberConfirmed = p5.User.PhoneNumberConfirmed,
                    TwoFactorEnabled = p5.User.TwoFactorEnabled,
                    LockoutEnd = p5.User.LockoutEnd,
                    LockoutEnabled = p5.User.LockoutEnabled,
                    AccessFailedCount = p5.User.AccessFailedCount
                },
                Car = p5.Car == null ? null : new Car()
                {
                    CarId = p5.Car.CarId,
                    Type = p5.Car.Type,
                    Mark = p5.Car.Mark,
                    Model = p5.Car.Model,
                    Color = p5.Car.Color,
                    EngineCapacity = p5.Car.EngineCapacity,
                    HorsePower = p5.Car.HorsePower,
                    ProductionYear = p5.Car.ProductionYear,
                    MileageKm = p5.Car.MileageKm,
                    MileageMl = p5.Car.MileageMl,
                    Doors = p5.Car.Doors,
                    GearboxType = p5.Car.GearboxType,
                    AdvertisementId = p5.Car.AdvertisementId,
                    Advertisement = TypeAdapterConfig1.GetMapFunction<Advertisement, Advertisement>().Invoke(p5.Car.Advertisement)
                }
            };
        }
        
        private static Advertisement funcMain3(Advertisement p7)
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
                User = p7.User == null ? null : new User()
                {
                    Advertisements = TypeAdapterConfig2.GetMapFunction<IEnumerable<Advertisement>, IEnumerable<Advertisement>>().Invoke(p7.User.Advertisements),
                    Id = p7.User.Id,
                    UserName = p7.User.UserName,
                    NormalizedUserName = p7.User.NormalizedUserName,
                    Email = p7.User.Email,
                    NormalizedEmail = p7.User.NormalizedEmail,
                    EmailConfirmed = p7.User.EmailConfirmed,
                    PasswordHash = p7.User.PasswordHash,
                    SecurityStamp = p7.User.SecurityStamp,
                    ConcurrencyStamp = p7.User.ConcurrencyStamp,
                    PhoneNumber = p7.User.PhoneNumber,
                    PhoneNumberConfirmed = p7.User.PhoneNumberConfirmed,
                    TwoFactorEnabled = p7.User.TwoFactorEnabled,
                    LockoutEnd = p7.User.LockoutEnd,
                    LockoutEnabled = p7.User.LockoutEnabled,
                    AccessFailedCount = p7.User.AccessFailedCount
                },
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
                    AdvertisementId = p7.Car.AdvertisementId,
                    Advertisement = TypeAdapterConfig2.GetMapFunction<Advertisement, Advertisement>().Invoke(p7.Car.Advertisement)
                }
            };
        }
        
        private static Advertisement funcMain4(Advertisement p10)
        {
            return p10 == null ? null : new Advertisement()
            {
                AdvertisementId = p10.AdvertisementId,
                Title = p10.Title,
                Description = p10.Description,
                Price = p10.Price,
                Location = p10.Location,
                CreatedAt = p10.CreatedAt,
                Ends = p10.Ends,
                UserId = p10.UserId,
                User = p10.User == null ? null : new User()
                {
                    Advertisements = TypeAdapterConfig2.GetMapFunction<IEnumerable<Advertisement>, IEnumerable<Advertisement>>().Invoke(p10.User.Advertisements),
                    Id = p10.User.Id,
                    UserName = p10.User.UserName,
                    NormalizedUserName = p10.User.NormalizedUserName,
                    Email = p10.User.Email,
                    NormalizedEmail = p10.User.NormalizedEmail,
                    EmailConfirmed = p10.User.EmailConfirmed,
                    PasswordHash = p10.User.PasswordHash,
                    SecurityStamp = p10.User.SecurityStamp,
                    ConcurrencyStamp = p10.User.ConcurrencyStamp,
                    PhoneNumber = p10.User.PhoneNumber,
                    PhoneNumberConfirmed = p10.User.PhoneNumberConfirmed,
                    TwoFactorEnabled = p10.User.TwoFactorEnabled,
                    LockoutEnd = p10.User.LockoutEnd,
                    LockoutEnabled = p10.User.LockoutEnabled,
                    AccessFailedCount = p10.User.AccessFailedCount
                },
                Car = p10.Car == null ? null : new Car()
                {
                    CarId = p10.Car.CarId,
                    Type = p10.Car.Type,
                    Mark = p10.Car.Mark,
                    Model = p10.Car.Model,
                    Color = p10.Car.Color,
                    EngineCapacity = p10.Car.EngineCapacity,
                    HorsePower = p10.Car.HorsePower,
                    ProductionYear = p10.Car.ProductionYear,
                    MileageKm = p10.Car.MileageKm,
                    MileageMl = p10.Car.MileageMl,
                    Doors = p10.Car.Doors,
                    GearboxType = p10.Car.GearboxType,
                    AdvertisementId = p10.Car.AdvertisementId,
                    Advertisement = TypeAdapterConfig2.GetMapFunction<Advertisement, Advertisement>().Invoke(p10.Car.Advertisement)
                }
            };
        }
    }
}