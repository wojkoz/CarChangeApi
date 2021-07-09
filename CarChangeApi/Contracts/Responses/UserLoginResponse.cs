using System;

namespace CarChangeApi.Contracts.Responses
{
    public class UserLoginResponse : BaseResponse
    {
        public string Token { get; set; }
        public DateTime TokenValidTo { get; set; }
    }
}
