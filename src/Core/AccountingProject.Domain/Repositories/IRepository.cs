

using AccountingProject.Domain.Abstraction;
using Microsoft.EntityFrameworkCore;

namespace AccountingProject.Domain.Repositories
{
    public interface IRepository<T> where T : Entity
    {
        void SetDbContextInstance(DbContext context);
        DbSet<T> Entity { get; }
    }
}