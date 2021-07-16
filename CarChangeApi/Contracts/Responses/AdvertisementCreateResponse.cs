using CarChangeApi.Domain.Dtos;

namespace CarChangeApi.Contracts.Responses
{
    public class AdvertisementCreateResponse : BaseResponse
    {
        public AdvertisementDto Advertisement { get; set; }
    }
}
