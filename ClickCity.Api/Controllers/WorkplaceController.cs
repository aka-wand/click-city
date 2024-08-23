using ClickCity.Application.Operation.Commands.CreateWorksplace;
using ClickCity.Infra.Repository.Postgres.Migrations;
using MediatR;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ClickCity.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WorkplaceController : ControllerBase
    {
        private readonly IMediator _mediator;

        public WorkplaceController(IMediator mediator)
        {
            _mediator=mediator;
        }

        [HttpPost]
        public async Task<CreateWorkplaceResponse> CreateWorkplace(CreateWorkplaceCommand command) => await _mediator.Send(command);
    }
}