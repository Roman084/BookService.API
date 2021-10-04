using System;
using System.Linq;
using System.Threading.Tasks;

namespace BookService.DAL.Interfaces
{
    public interface IRepository<TEntity> where TEntity : class
    {
        void Create(TEntity entity);
        Task CreateAsync(TEntity entity);

        void Update(TEntity entity);
        Task UpdateAsync(TEntity entity);
        
        IQueryable<TEntity> GetAll();
        Task<IQueryable<TEntity>> GetAllAsync();
        
        void Delete(Guid id);
        Task DeleteAsync(Guid id);

        TEntity GetById(Guid id);
    }
}