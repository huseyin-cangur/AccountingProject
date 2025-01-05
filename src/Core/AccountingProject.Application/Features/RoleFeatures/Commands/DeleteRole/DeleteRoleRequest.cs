

using MediatR;

namespace AccountingProject.Application.Features.RoleFeatures.Commands.DeleteRole
{
    public class DeleteRoleRequest:IRequest<DeleteRoleResponse>
    {
         public string Id { get; set; }
    }
}