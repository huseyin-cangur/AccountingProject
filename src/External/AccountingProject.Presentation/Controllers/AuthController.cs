

using AccountingProject.Application.Features.AppFeatures.AppUserFeatures.Login;
using AccountingProject.Presentation.Abstraction;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace AccountingProject.Presentation.Controllers
{
     
    public class AuthController : ApiContoller
    {
        public AuthController(IMediator mediator) : base(mediator)
        {
        }

        public async Task<IActionResult> Login(LoginRequest request)
        {
            LoginResponse response = await _mediator.Send(request);

            return Ok(response);
        }
 
    }
}