using CarChangeApi.Domain.Models;
using System;

namespace CarChangeApi.Domain.Dtos
{
    public static class CreateAdvertismentDtoExtension
    {
        public static Advertisement ToAdvertisement(this CreateAdvertisementDto dto, User user)
        {
            return new()
            {
                Car = dto.Car.ToCar(),
                CreatedAt = DateTime.UtcNow,
                Description = dto.Description,
                Ends = dto.Ends,
                Location = dto.Location,
                Price = dto.Price,
                Title = dto.Title,
                User = user,
                UserId = user.Id
            };
        }
    }
}
