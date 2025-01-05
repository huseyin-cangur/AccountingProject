

using AccountingProject.Domain.App.Entities.Identity;
 

namespace AccountingProject.Application.Features.RoleFeatures.Queries.GetAllRoles
{
  
    public class GetAllRolesResponse
    {
        public IList<AppRole> Roles { get; set; }
    }
}