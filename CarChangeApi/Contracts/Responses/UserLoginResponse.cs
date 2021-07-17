using System;

namespace CarChangeApi.Contracts.Responses
{
    public class UserLoginResponse : BaseResponse<string>
    {
        public string Token { get; set; }
        public DateTime TokenValidTo { get; set; }
    }
}
