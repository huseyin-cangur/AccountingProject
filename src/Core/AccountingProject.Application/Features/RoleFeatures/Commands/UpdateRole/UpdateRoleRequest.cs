

using MediatR;

namespace AccountingProject.Application.Features.RoleFeatures.Commands.UpdateRole
{
    public class UpdateRoleRequest:IRequest<UpdateRoleResponse>
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
    }
}