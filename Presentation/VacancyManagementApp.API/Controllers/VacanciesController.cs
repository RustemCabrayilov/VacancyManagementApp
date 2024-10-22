using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using VacancyManagementApp.Application.Features.Commands.Vacancy.CreateVacancy;

namespace VacancyManagementApp.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VacanciesController : ControllerBase
    {
        private readonly IMediator _mediator;

        public VacanciesController(IMediator mediator)
        {
            this._mediator = mediator;
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody]CreateVacancyCommandRequest request)
        {
            var res = await _mediator.Send(request);
            return Ok(res);
        }
    }
}
