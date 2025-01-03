

using Microsoft.EntityFrameworkCore;

namespace AccountingProject.Domain
{
    public interface IUnitOfWork
    {
         void SetDbContextInstance(DbContext context);
         Task<int> SaveChangesAsync();
    }
}