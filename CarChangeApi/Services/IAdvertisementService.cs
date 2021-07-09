using CarChangeApi.Contracts.Requests;
using CarChangeApi.Domain.Generated;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CarChangeApi.Services
{
    public interface IAdvertisementService
    {
        Task<AdvertisementDto> AddTodoAsync(AdvertisementCreateRequest createRequest, string token);
        Task<IEnumerable<AdvertisementDto>> GetUserTodoListAsync(string token);
        Task DeleteTodoAsync(long todoId, string token);
        Task<AdvertisementDto> UpdateTodo(AdvertisementDto dto, string token);
    }
}
