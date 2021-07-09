using CarChangeApi.Contracts.Requests;
using CarChangeApi.Domain.Generated;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CarChangeApi.Services.impl
{
    public class AdvertisementService : IAdvertisementService
    {
        public Task<AdvertisementDto> AddTodoAsync(AdvertisementCreateRequest createRequest, string token)
        {
            throw new NotImplementedException();
        }

        public Task DeleteTodoAsync(long todoId, string token)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<AdvertisementDto>> GetUserTodoListAsync(string token)
        {
            throw new NotImplementedException();
        }

        public Task<AdvertisementDto> UpdateTodo(AdvertisementDto dto, string token)
        {
            throw new NotImplementedException();
        }
    }
}
