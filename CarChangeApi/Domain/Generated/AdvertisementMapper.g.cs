using System.Linq;
using CarChangeApi.Domain.Generated;
using CarChangeApi.Domain.Models;
using Mapster;

namespace CarChangeApi.Domain.Generated
{
    public static partial class AdvertisementMapper
    {
        private static TypeAdapterConfig TypeAdapterConfig1;
        private static TypeAdapterConfig TypeAdapterConfig2;
        
        public static AdvertisementDto AdaptToDto(this Advertisement p1)
        {
            return p1 == null ? null : new AdvertisementDto()
            {
                AdvertisementId = p1.AdvertisementId,
                Title = p1.Title,
                Description = p1.Description,
                Price = p1.Price,
                Location = p1.Location,
                CreatedAt = p1.CreatedAt,
                Ends = p1.Ends,
                UserId = p1.UserId,
                Car = p1.Car == null ? null : new Car()
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
                    AdvertisementId = p1.Car.AdvertisementId,
                    Advertisement = p1.Car.Advertisement == null ? null : new Advertisement()
                    {
                        AdvertisementId = p1.Car.Advertisement.AdvertisementId,
                        Title = p1.Car.Advertisement.Title,
                        Description = p1.Car.Advertisement.Description,
                        Price = p1.Car.Advertisement.Price,
                        Location = p1.Car.Advertisement.Location,
                        CreatedAt = p1.Car.Advertisement.CreatedAt,
                        Ends = p1.Car.Advertisement.Ends,
                        UserId = p1.Car.Advertisement.UserId,
                        User = p1.Car.Advertisement.User == null ? null : new User()
                        {
                            Advertisements = p1.Car.Advertisement.User.Advertisements == null ? null : p1.Car.Advertisement.User.Advertisements.Select<Advertisement, Advertisement>(funcMain1),
                            Id = p1.Car.Advertisement.User.Id,
                            UserName = p1.Car.Advertisement.User.UserName,
                            NormalizedUserName = p1.Car.Advertisement.User.NormalizedUserName,
                            Email = p1.Car.Advertisement.User.Email,
                            NormalizedEmail = p1.Car.Advertisement.User.NormalizedEmail,
                            EmailConfirmed = p1.Car.Advertisement.User.EmailConfirmed,
                            PasswordHash = p1.Car.Advertisement.User.PasswordHash,
                            SecurityStamp = p1.Car.Advertisement.User.SecurityStamp,
                            ConcurrencyStamp = p1.Car.Advertisement.User.ConcurrencyStamp,
                            PhoneNumber = p1.Car.Advertisement.User.PhoneNumber,
                            PhoneNumberConfirmed = p1.Car.Advertisement.User.PhoneNumberConfirmed,
                            TwoFactorEnabled = p1.Car.Advertisement.User.TwoFactorEnabled,
                            LockoutEnd = p1.Car.Advertisement.User.LockoutEnd,
                            LockoutEnabled = p1.Car.Advertisement.User.LockoutEnabled,
                            AccessFailedCount = p1.Car.Advertisement.User.AccessFailedCount
                        },
                        Car = TypeAdapterConfig1.GetMapFunction<Car, Car>().Invoke(p1.Car.Advertisement.Car)
                    }
                }
            };
        }
        public static AdvertisementDto AdaptTo(this Advertisement p3, AdvertisementDto p4)
        {
            if (p3 == null)
            {
                return null;
            }
            AdvertisementDto result = p4 ?? new AdvertisementDto();
            
            result.AdvertisementId = p3.AdvertisementId;
            result.Title = p3.Title;
            result.Description = p3.Description;
            result.Price = p3.Price;
            result.Location = p3.Location;
            result.CreatedAt = p3.CreatedAt;
            result.Ends = p3.Ends;
            result.UserId = p3.UserId;
            result.Car = funcMain2(p3.Car, result.Car);
            return result;
            
        }
        public static AdvertisementDto AdaptToDto(this Advertisement p12)
        {
            return p12 == null ? null : new AdvertisementDto()
            {
                AdvertisementId = p12.AdvertisementId,
                Title = p12.Title,
                Description = p12.Description,
                Price = p12.Price,
                Location = p12.Location,
                CreatedAt = p12.CreatedAt,
                Ends = p12.Ends,
                UserId = p12.UserId,
                Car = p12.Car == null ? null : new Car()
                {
                    CarId = p12.Car.CarId,
                    Type = p12.Car.Type,
                    Mark = p12.Car.Mark,
                    Model = p12.Car.Model,
                    Color = p12.Car.Color,
                    EngineCapacity = p12.Car.EngineCapacity,
                    HorsePower = p12.Car.HorsePower,
                    ProductionYear = p12.Car.ProductionYear,
                    MileageKm = p12.Car.MileageKm,
                    MileageMl = p12.Car.MileageMl,
                    Doors = p12.Car.Doors,
                    GearboxType = p12.Car.GearboxType,
                    AdvertisementId = p12.Car.AdvertisementId,
                    Advertisement = p12.Car.Advertisement == null ? null : new Advertisement()
                    {
                        AdvertisementId = p12.Car.Advertisement.AdvertisementId,
                        Title = p12.Car.Advertisement.Title,
                        Description = p12.Car.Advertisement.Description,
                        Price = p12.Car.Advertisement.Price,
                        Location = p12.Car.Advertisement.Location,
                        CreatedAt = p12.Car.Advertisement.CreatedAt,
                        Ends = p12.Car.Advertisement.Ends,
                        UserId = p12.Car.Advertisement.UserId,
                        User = p12.Car.Advertisement.User == null ? null : new User()
                        {
                            Advertisements = p12.Car.Advertisement.User.Advertisements == null ? null : p12.Car.Advertisement.User.Advertisements.Select<Advertisement, Advertisement>(funcMain6),
                            Id = p12.Car.Advertisement.User.Id,
                            UserName = p12.Car.Advertisement.User.UserName,
                            NormalizedUserName = p12.Car.Advertisement.User.NormalizedUserName,
                            Email = p12.Car.Advertisement.User.Email,
                            NormalizedEmail = p12.Car.Advertisement.User.NormalizedEmail,
                            EmailConfirmed = p12.Car.Advertisement.User.EmailConfirmed,
                            PasswordHash = p12.Car.Advertisement.User.PasswordHash,
                            SecurityStamp = p12.Car.Advertisement.User.SecurityStamp,
                            ConcurrencyStamp = p12.Car.Advertisement.User.ConcurrencyStamp,
                            PhoneNumber = p12.Car.Advertisement.User.PhoneNumber,
                            PhoneNumberConfirmed = p12.Car.Advertisement.User.PhoneNumberConfirmed,
                            TwoFactorEnabled = p12.Car.Advertisement.User.TwoFactorEnabled,
                            LockoutEnd = p12.Car.Advertisement.User.LockoutEnd,
                            LockoutEnabled = p12.Car.Advertisement.User.LockoutEnabled,
                            AccessFailedCount = p12.Car.Advertisement.User.AccessFailedCount
                        },
                        Car = TypeAdapterConfig2.GetMapFunction<Car, Car>().Invoke(p12.Car.Advertisement.Car)
                    }
                }
            };
        }
        public static AdvertisementDto AdaptTo(this Advertisement p14, AdvertisementDto p15)
        {
            if (p14 == null)
            {
                return null;
            }
            AdvertisementDto result = p15 ?? new AdvertisementDto();
            
            result.AdvertisementId = p14.AdvertisementId;
            result.Title = p14.Title;
            result.Description = p14.Description;
            result.Price = p14.Price;
            result.Location = p14.Location;
            result.CreatedAt = p14.CreatedAt;
            result.Ends = p14.Ends;
            result.UserId = p14.UserId;
            result.Car = funcMain7(p14.Car, result.Car);
            return result;
            
        }
        
        private static Advertisement funcMain1(Advertisement p2)
        {
            return TypeAdapterConfig1.GetMapFunction<Advertisement, Advertisement>().Invoke(p2);
        }
        
        private static Car funcMain2(Car p5, Car p6)
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
            result.Advertisement = funcMain3(p5.Advertisement, result.Advertisement);
            return result;
            
        }
        
        private static Advertisement funcMain6(Advertisement p13)
        {
            return TypeAdapterConfig2.GetMapFunction<Advertisement, Advertisement>().Invoke(p13);
        }
        
        private static Car funcMain7(Car p16, Car p17)
        {
            if (p16 == null)
            {
                return null;
            }
            Car result = p17 ?? new Car();
            
            result.CarId = p16.CarId;
            result.Type = p16.Type;
            result.Mark = p16.Mark;
            result.Model = p16.Model;
            result.Color = p16.Color;
            result.EngineCapacity = p16.EngineCapacity;
            result.HorsePower = p16.HorsePower;
            result.ProductionYear = p16.ProductionYear;
            result.MileageKm = p16.MileageKm;
            result.MileageMl = p16.MileageMl;
            result.Doors = p16.Doors;
            result.GearboxType = p16.GearboxType;
            result.AdvertisementId = p16.AdvertisementId;
            result.Advertisement = funcMain8(p16.Advertisement, result.Advertisement);
            return result;
            
        }
        
        private static Advertisement funcMain3(Advertisement p7, Advertisement p8)
        {
            if (p7 == null)
            {
                return null;
            }
            Advertisement result = p8 ?? new Advertisement();
            
            result.AdvertisementId = p7.AdvertisementId;
            result.Title = p7.Title;
            result.Description = p7.Description;
            result.Price = p7.Price;
            result.Location = p7.Location;
            result.CreatedAt = p7.CreatedAt;
            result.Ends = p7.Ends;
            result.UserId = p7.UserId;
            result.User = funcMain4(p7.User, result.User);
            result.Car = TypeAdapterConfig1.GetMapToTargetFunction<Car, Car>().Invoke(p7.Car, result.Car);
            return result;
            
        }
        
        private static Advertisement funcMain8(Advertisement p18, Advertisement p19)
        {
            if (p18 == null)
            {
                return null;
            }
            Advertisement result = p19 ?? new Advertisement();
            
            result.AdvertisementId = p18.AdvertisementId;
            result.Title = p18.Title;
            result.Description = p18.Description;
            result.Price = p18.Price;
            result.Location = p18.Location;
            result.CreatedAt = p18.CreatedAt;
            result.Ends = p18.Ends;
            result.UserId = p18.UserId;
            result.User = funcMain9(p18.User, result.User);
            result.Car = TypeAdapterConfig2.GetMapToTargetFunction<Car, Car>().Invoke(p18.Car, result.Car);
            return result;
            
        }
        
        private static User funcMain4(User p9, User p10)
        {
            if (p9 == null)
            {
                return null;
            }
            User result = p10 ?? new User();
            
            result.Advertisements = p9.Advertisements == null ? null : p9.Advertisements.Select<Advertisement, Advertisement>(funcMain5);
            result.Id = p9.Id;
            result.UserName = p9.UserName;
            result.NormalizedUserName = p9.NormalizedUserName;
            result.Email = p9.Email;
            result.NormalizedEmail = p9.NormalizedEmail;
            result.EmailConfirmed = p9.EmailConfirmed;
            result.PasswordHash = p9.PasswordHash;
            result.SecurityStamp = p9.SecurityStamp;
            result.ConcurrencyStamp = p9.ConcurrencyStamp;
            result.PhoneNumber = p9.PhoneNumber;
            result.PhoneNumberConfirmed = p9.PhoneNumberConfirmed;
            result.TwoFactorEnabled = p9.TwoFactorEnabled;
            result.LockoutEnd = p9.LockoutEnd;
            result.LockoutEnabled = p9.LockoutEnabled;
            result.AccessFailedCount = p9.AccessFailedCount;
            return result;
            
        }
        
        private static User funcMain9(User p20, User p21)
        {
            if (p20 == null)
            {
                return null;
            }
            User result = p21 ?? new User();
            
            result.Advertisements = p20.Advertisements == null ? null : p20.Advertisements.Select<Advertisement, Advertisement>(funcMain10);
            result.Id = p20.Id;
            result.UserName = p20.UserName;
            result.NormalizedUserName = p20.NormalizedUserName;
            result.Email = p20.Email;
            result.NormalizedEmail = p20.NormalizedEmail;
            result.EmailConfirmed = p20.EmailConfirmed;
            result.PasswordHash = p20.PasswordHash;
            result.SecurityStamp = p20.SecurityStamp;
            result.ConcurrencyStamp = p20.ConcurrencyStamp;
            result.PhoneNumber = p20.PhoneNumber;
            result.PhoneNumberConfirmed = p20.PhoneNumberConfirmed;
            result.TwoFactorEnabled = p20.TwoFactorEnabled;
            result.LockoutEnd = p20.LockoutEnd;
            result.LockoutEnabled = p20.LockoutEnabled;
            result.AccessFailedCount = p20.AccessFailedCount;
            return result;
            
        }
        
        private static Advertisement funcMain5(Advertisement p11)
        {
            return TypeAdapterConfig1.GetMapFunction<Advertisement, Advertisement>().Invoke(p11);
        }
        
        private static Advertisement funcMain10(Advertisement p22)
        {
            return TypeAdapterConfig2.GetMapFunction<Advertisement, Advertisement>().Invoke(p22);
        }
    }
}