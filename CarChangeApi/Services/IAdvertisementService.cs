using CarChangeApi.Contracts.Requests;
using CarChangeApi.Domain.Generated;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CarChangeApi.Services
{
    public interface IAdvertisementService
    {
        Task<AdvertisementDto> AddAdvertisementAsync(AdvertisementCreateRequest createRequest, string token);
        Task<IEnumerable<AdvertisementDto>> GetAdvertisementListByUserAsync(string token);
        Task<IEnumerable<AdvertisementDto>> GetAdvertisementListAsync();
        Task DeleteAdvertisementAsync(long todoId, string token);
        Task<AdvertisementDto> UpdateAdvertisementAsync(AdvertisementDto dto, string token);
    }
}
