

using AccountingProject.Domain;
using AccountingProject.Persistance.Context;
using Microsoft.EntityFrameworkCore;

namespace AccountingProject.Persistance
{
    public class UnitOfWork : IUnitOfWork
    {
        private CompanyDbContext _context;


        public void SetDbContextInstance(DbContext context)
        {
            _context = (CompanyDbContext)context;
        }

        public Task<int> SaveChangesAsync()
        {
           return _context.SaveChangesAsync();
        }
    }
}