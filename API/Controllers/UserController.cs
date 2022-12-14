using Core.Mediatr.User.Create;
using Core.Mediatr.User.Delete;
using Core.Mediatr.User.GetAll;
using Core.Mediatr.User.GetById;
using Core.Mediatr.User.Update;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IMediator mediator;

        public UserController(IMediator mediator)
        {
            this.mediator = mediator;
        }

        [HttpGet("GetbyId")]
        public async Task<IActionResult> GetbyId([FromQuery] GetByIdUserRequest request, CancellationToken cancellationToken)
        {
            var response = await mediator.Send(request, cancellationToken);

            return Ok(response);
        }

        [HttpGet("GetAll")]
        public async Task<IActionResult> GetAll([FromQuery] GetAllUserRequest request, CancellationToken cancellationToken)
        {
            var response = await mediator.Send(request, cancellationToken);

            return Ok(response);
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromBody] CreateUserRequest request, CancellationToken cancellationToken)
        {
            var response = await mediator.Send(request, cancellationToken);

            return Ok(response);
        }

        [HttpPut]
        public async Task<IActionResult> Update([FromBody] UpdateUserRequest request, CancellationToken cancellationToken)
        {
            var response = await mediator.Send(request, cancellationToken);

            return Ok(response);
        }

        [HttpDelete]
        public async Task<IActionResult> Update([FromBody] DeleteUserRequest request, CancellationToken cancellationToken)
        {
            var response = await mediator.Send(request, cancellationToken);

            return Ok(response);
        }
    }
}
