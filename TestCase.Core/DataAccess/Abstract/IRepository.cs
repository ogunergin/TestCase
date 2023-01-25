using System.Linq.Expressions;

namespace TestCase.Core.DataAccess.Abstract;

public interface IRepository<T> where T : class, new()
{
    IQueryable<T> Get(Expression<Func<T, bool>> predicate = null);
    Task<T> GetAsync(Expression<Func<T, bool>> predicate);
    Task<T> AddAsync(T entity);
    Task<T> UpdateAsync(T entity, Expression<Func<T, bool>> predicate);
    Task<T> DeleteAsync(Expression<Func<T, bool>> predicate);
}