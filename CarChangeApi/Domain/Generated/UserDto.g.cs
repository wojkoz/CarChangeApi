using System.Collections.Generic;
using CarChangeApi.Domain.Models;

namespace CarChangeApi.Domain.Generated
{
    public partial class UserDto
    {
        public IEnumerable<Advertisement> Advertisements { get; set; }
        public string Id { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
    }
}