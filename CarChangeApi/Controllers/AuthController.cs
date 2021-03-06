using CarChangeApi.Commands;
using CarChangeApi.Contracts.Requests;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System.IO;
using System.Threading.Tasks;

namespace CarChangeApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AuthController : ControllerBase
    {
        private readonly IMediator _mediator;

        public AuthController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost("register")]
        public async Task<IActionResult> Register([FromBody] AuthRegisterRequest authRegisterRequest)
        {
            var result = await await _mediator.Send(new RegisterUserCommand.Command
            {
                RegisterRequest = authRegisterRequest
            }
             );

            return result.Succeded ? Ok(result) : Conflict(result);
        }

        [HttpPost("login")]
        public async Task<IActionResult> Login([FromBody] AuthLoginRequest authLoginRequest)
        {
            var result = await await _mediator.Send(new LoginUserCommand.Command
            {
                LoginRequest = authLoginRequest
            }
             );

            return result.Succeded ? Ok(result) : Unauthorized(result);
        }
        [HttpGet("video")]
        public IActionResult SampleVideoStream()
        {
            var pathToVideos = "video/";
            //var pathToVideos = "F:\\CSharp Net\\StreamAppWebApi\\StreamApp\\StreamAppWebApi\\video\\";
            var path = Path.Combine(pathToVideos, "film2.mp4");
            return File(System.IO.File.OpenRead(path), "video/mp4");
            //return PhysicalFile(path, "application/octet-stream", enableRangeProcessing: true);
        }
    }
}
