﻿using CarChangeApi.Contracts.Requests;
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

            // return CreatedAtAction(nameof(CreateAdvertisement), new { id = 5 }, product);
            return await Task.FromResult(Ok());
        }
    }
}