

using AccountingProject.Application.Features.RoleFeatures.Commands.DeleteRole;
using AccountingProject.Application.Features.RoleFeatures.Commands.UpdateRole;
using AccountingProject.Application.Features.RoleFeatures.CreateRole;
using AccountingProject.Application.Features.RoleFeatures.Queries;
using AccountingProject.Presentation.Abstraction;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace AccountingProject.Presentation.Controllers
{
    public class RoleController : ApiContoller
    {
        public RoleController(IMediator mediator) : base(mediator)
        {
        }

        [HttpPost]
        public async Task<IActionResult> Create(CreateRoleRequest request)
        {
            CreateRoleResponse response = await _mediator.Send(request);

            return Ok(response);                
        }
        [HttpGet]
        public async Task<IActionResult> GetAllRoles()
        {
            GetAllRolesRequest request = new();
            var response = await _mediator.Send(request);
            return Ok(response);
        }
        [HttpPost]
        public async Task<IActionResult> Update(UpdateRoleRequest request)
        {
            UpdateRoleResponse response = await _mediator.Send(request);

            return Ok(response);                
        }
         [HttpGet]
        public async Task<IActionResult> Delete(DeleteRoleRequest request)
        {
            DeleteRoleResponse response = await _mediator.Send(request);

            return Ok(response);                
        }
    }
}