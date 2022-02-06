using System.Linq.Expressions;

namespace NLayer.Core.Repository
{
    public interface IGenericRepository<T> where T : class
    {
        Task<T> GetByIdAsync(int id);
        IQueryable<T> GetAll();
        IQueryable<T> Where(Expression<Func<T, bool>> expression);  // productRepository.Where(x=>x.id>5) 
        Task<bool> AnyAsync(Expression<Func<T, bool>> expression);
        Task AddAsync(T entity);
        Task AddRangeAsync(IEnumerable<T> entities);
        void Update(T entity);// EfCore da Async Methodları yok.
        void Remove(T entity); // EfCore da Async Methodları yok.
        void RemoveRange(IEnumerable<T> entities);

    }
}
