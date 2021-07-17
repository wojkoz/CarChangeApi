using Microsoft.AspNetCore.Identity;
using System.Collections.Generic;

namespace CarChangeApi.Contracts.Responses
{
    public class BaseResponse<T>
    {
        public bool Succeded { get; set; }
        public IEnumerable<IdentityError> Errors { get; set; }
        public T Data { get; set; }
    }
}
