

using AccountingProject.Domain.Abstraction;

namespace AccountingProject.Domain.Repositories
{
    public interface ICommandRepository<T>:IRepository<T>  where T : Entity
    {
        Task AddAsync(T entity);
        Task AddRangeAsync(IEnumerable<T> entities);
        void Update(T entity);
        void UpdateRange(IEnumerable<T> entities);
        Task RemoveByIdAsync(string id);
        void Remove(T entity);
        void RemoveRange(IEnumerable<T> entities);
    }
}