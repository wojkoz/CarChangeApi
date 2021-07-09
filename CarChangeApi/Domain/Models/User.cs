using Microsoft.AspNetCore.Identity;
using System.Collections.Generic;

namespace CarChangeApi.Domain.Models
{
    public class User : IdentityUser
    {
        public IEnumerable<Advertisement> Advertisements { get; set; }
    }
}
