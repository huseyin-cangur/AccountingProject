using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace AccountingProject.Presentation.Abstraction
{
    [ApiController]
    [Route("api/[controller]/[action]")]
    public abstract class ApiContoller :ControllerBase
    {
         protected readonly IMediator _mediator;

        protected ApiContoller(IMediator mediator)
        {
            _mediator = mediator;
        }
    }
}