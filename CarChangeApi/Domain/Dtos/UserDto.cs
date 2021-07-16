using System.Collections.Generic;

namespace CarChangeApi.Domain.Dtos
{
    public class UserDto
    {
        public string Id { get; set; }
        public IEnumerable<AdvertisementDto> Advertisements { get; set; }
        public string Email { get; set; }
        public string UserName { get; set; }
    }
}
