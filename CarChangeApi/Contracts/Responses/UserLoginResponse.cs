using System;

namespace CarChangeApi.Contracts.Responses
{
    public class UserLoginResponse : GeneralResponse
    {
        public string Token { get; set; }
        public DateTime TokenValidTo { get; set; }
    }
}
