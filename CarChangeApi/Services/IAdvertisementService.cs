using CarChangeApi.Contracts.Requests;
using CarChangeApi.Domain.Dtos;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CarChangeApi.Services
{
    public interface IAdvertisementService
    {
        Task<AdvertisementDto> AddAdvertisementAsync(AdvertisementCreateRequest createRequest, string userId);
        Task<IEnumerable<AdvertisementDto>> GetAdvertisementListByUserAsync(string userId);
        Task<IEnumerable<AdvertisementDto>> GetAdvertisementListAsync();
        Task DeleteAdvertisementAsync(long entityId, string userId);
        Task<AdvertisementDto> UpdateAdvertisementAsync(AdvertisementDto dto, string userId);
    }
}
