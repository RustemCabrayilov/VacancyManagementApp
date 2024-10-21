using MediatR;
using Microsoft.AspNetCore.Mvc;
using VacancyManagementApp.Application.Features.Commands.AppUser.CreateUser;

namespace VacancyManagementApp.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UserController : ControllerBase
    {
        private readonly IMediator _mediator;

        public UserController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost]
        [Route("create")]
        public async Task<IActionResult> CreateUser([FromBody] CreateUserCommandRequest createUserCommand)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var response = await _mediator.Send(createUserCommand);

            if (response.Succeeded)
            {
                return Ok(response);
            }

            return BadRequest(response.Message);
        }
    }
}