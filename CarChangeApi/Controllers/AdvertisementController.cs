using CarChangeApi.Commands;
using CarChangeApi.Contracts.Requests;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace CarChangeApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AdvertisementController : ControllerBase
    {
        private readonly IMediator _mediator;

        public AdvertisementController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost]
        [Authorize]
        public async Task<IActionResult> CreateAdvertisement([FromBody] AdvertisementCreateRequest createRequest)
        {
            var advertisement = await _mediator.Send(new AdvertisementCreateCommand(createRequest));


            return CreatedAtAction(
                nameof(CreateAdvertisement),
                new { id = advertisement.Data.AdvertisementId },
                advertisement
                );

        }

        [HttpDelete("{id}")]
        [Authorize]
        public async Task<IActionResult> DeleteAdvertisement(long id)
        {
            var result = await _mediator.Send(new AdvertisementDeleteCommand(id));

            return result.Succeded ? Ok(result) : Conflict(result);

        }
    }
}
