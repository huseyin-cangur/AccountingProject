

using AccountingProject.Application.Services.AppServices;
using AccountingProject.Domain.App.Entities.Identity;
using MediatR;
using Microsoft.AspNetCore.Identity;

namespace AccountingProject.Application.Features.RoleFeatures.Commands.DeleteRole
{
    public class DeleteRoleHandler : IRequestHandler<DeleteRoleRequest, DeleteRoleResponse>
    {
        private readonly IRoleService _roleService;

        public DeleteRoleHandler(IRoleService roleService)
        {
            _roleService = roleService;
        }

        public async Task<DeleteRoleResponse> Handle(DeleteRoleRequest request, CancellationToken cancellationToken)
        {
            AppRole role = await _roleService.GetById(request.Id);
            if (role == null) throw new Exception("Role bulunamadı");

            await _roleService.DeleteByIdAsync(role);
            return new();
        }
    }
}