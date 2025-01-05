
using AccountingProject.Application.Services.AppServices;
using AccountingProject.Domain.App.Entities.Identity;
using MediatR;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace AccountingProject.Application.Features.RoleFeatures.Queries.GetAllRoles
{
    public class GetAllRolesHandler : IRequestHandler<GetAllRolesRequest, GetAllRolesResponse>
    {
        private readonly IRoleService roleService;

        public GetAllRolesHandler(IRoleService roleService)
        {
            this.roleService = roleService;
        }

        public async Task<GetAllRolesResponse> Handle(GetAllRolesRequest request, CancellationToken cancellationToken)
        {
            IList<AppRole> appRoles = await roleService.GetAllRolesAsync();

            return new GetAllRolesResponse { Roles = appRoles };
        }
    }
}