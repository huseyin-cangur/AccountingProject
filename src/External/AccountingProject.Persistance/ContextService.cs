

using AccountingProject.Domain;
using AccountingProject.Domain.App.Entities;
using AccountingProject.Persistance.Context;
using Microsoft.EntityFrameworkCore;

namespace AccountingProject.Persistance
{
    public class ContextService : IContextService
    {
        private readonly AppDbContext _appDbContext;

        public ContextService(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public DbContext CreateDbContextInstance(string companyId)
        {
            Company company =  _appDbContext.Set<Company>().FirstOrDefault(p=>p.Id == companyId);
            return new CompanyDbContext(company);
        }
    }
}