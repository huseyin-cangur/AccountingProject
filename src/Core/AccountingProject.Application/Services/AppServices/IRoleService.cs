
using AccountingProject.Domain.App.Entities.Identity;

namespace AccountingProject.Application.Services.AppServices
{
    public interface IRoleService
    {
        Task AddAsync(AppRole role);
        Task UpdateAsync(AppRole role);
        Task DeleteByIdAsync(AppRole appRole);
        Task <IList<AppRole>> GetAllRolesAsync();
        Task<AppRole> GetById(string Id);
        Task<AppRole> GetByCode(string Code);
        
        
    }
}