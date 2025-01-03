
using AccountingProject.Application.Features.CompanyFeatures.CreateUCAF;
using AccountingProject.Presentation.Abstraction;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace AccountingProject.Presentation.Controllers
{
    public class UCAFController : ApiContoller
    {
        public UCAFController(IMediator mediator) : base(mediator)
        {
        }
       
       [HttpPost]
       public  async Task<IActionResult> Create(CreateUCAFRequest request)
       {
            
            CreateUCAFResponse response = await _mediator.Send(request);
            
            return Ok(response);

       }

    }
}