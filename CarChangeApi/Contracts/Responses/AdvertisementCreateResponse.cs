using CarChangeApi.Domain.Generated;

namespace CarChangeApi.Contracts.Responses
{
    public class AdvertisementCreateResponse : BaseResponse
    {
        public AdvertisementDto Advertisement { get; set; }
    }
}
