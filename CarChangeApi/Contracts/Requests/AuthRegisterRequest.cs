namespace CarChangeApi.Contracts.Requests
{
    public class AuthRegisterRequest
    {
        public string Email { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
    }
}
