
using MediatR;

namespace AccountingProject.Application.Features.RoleFeatures.CreateRole
{
    public class CreateRoleRequest:IRequest<CreateRoleResponse>
    {
        public string Name { get; set; }
        public string Code { get; set; }
    }
}