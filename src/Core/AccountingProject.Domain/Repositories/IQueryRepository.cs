
using System.Linq.Expressions;
using AccountingProject.Domain.Abstraction;

namespace AccountingProject.Domain.Repositories
{
    public interface IQueryRepository<T> : IRepository<T> where T : Entity
    {
        IQueryable<T> GetAll(bool isTracking = true);
        IQueryable<T> GetWhere(Expression<Func<T, bool>> predicate,bool isTracking = true);
        Task<T> GetByIdAsync(string id,bool isTracking = true);
        Task<T> GetFirstByExpressionAsync(Expression<Func<T, bool>> predicate,bool isTracking = true);
        Task<T> GetFirst(bool isTracking = true);
    }
}