using Microsoft.AspNetCore.Identity;
using System.Collections.Generic;

namespace CarChangeApi.Contracts.Responses
{
    public abstract class GeneralResponse
    {
        public bool Succeded { get; set; }
        public IEnumerable<IdentityError> Errors { get; set; }
    }
}
