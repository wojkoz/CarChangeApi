using CarChangeApi.Domain.Dtos;
using CarChangeApi.Domain.Models;
using Mapster;

namespace CarChangeApi.Domain.Mapster
{
    public class MyRegister : IRegister
    {
        public void Register(TypeAdapterConfig config)
        {
            config.NewConfig<Advertisement, AdvertisementDto>();
            config.NewConfig<Car, CarDto>();
            config.NewConfig<User, UserDto>();
        }
    }
}
