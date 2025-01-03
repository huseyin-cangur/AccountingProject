

using AccountingProject.Domain.App.Entities.Identity;

namespace AccountingProject.Application.Abstraction
{
    public interface IJwtProvider
    {
        Task<string> CreateTokenAsync(AppUser user,List<string> roles);
        
    }
}