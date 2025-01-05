 
using AccountingProject.Application.Features.RoleFeatures.Commands.UpdateRole;
using AccountingProject.Application.Features.RoleFeatures.CreateRole;
using AccountingProject.Application.Services.AppServices;
using AccountingProject.Domain.App.Entities.Identity;
using AutoMapper;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace AccountingProject.Persistance.Services.AppsServices
{
    public class RoleService : IRoleService
    {
        private readonly RoleManager<AppRole> _roleManager;

        public RoleService(RoleManager<AppRole> roleManager)
        {
            _roleManager = roleManager;
        }

        public async Task AddAsync(AppRole role)
        {
            

            await _roleManager.CreateAsync(role);
        }

        public async Task DeleteByIdAsync(AppRole role)
        {
        
            await _roleManager.DeleteAsync(role);
        }

        public async Task<IList<AppRole>> GetAllRolesAsync()
        {
           return  await _roleManager.Roles.ToListAsync();
        }

        public async Task<AppRole> GetByCode(string Code)
        {
          return  await _roleManager.Roles.FirstOrDefaultAsync(p=>p.Code==Code);
        }

        public async Task<AppRole> GetById(string Id)
        {
          return  await _roleManager.FindByIdAsync(Id);
        }

        public async Task UpdateAsync(AppRole role)
        {          
            await _roleManager.UpdateAsync(role);
        }
    }
}