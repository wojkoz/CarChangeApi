using CarChangeApi.Domain.Models;

namespace CarChangeApi.Domain.Dtos
{
    public static class AdvertisementDtoExtension
    {
        public static Advertisement MapToEntity(this AdvertisementDto dto)
        {
            return new()
            {
                AdvertisementId = dto.AdvertisementId,
                Car = dto.Car.MapToCar(),
                CreatedAt = dto.CreatedAt,
                Description = dto.Description,
                Ends = dto.Ends,
                Location = dto.Location,
                Price = dto.Price,
                Title = dto.Title,
                UserId = dto.UserId
            };
        }
    }
}
