using System;
using System.Linq;
using System.Threading.Tasks;
using BookService.DAL.EF;
using BookService.DAL.Entities;
using BookService.DAL.Interfaces;

namespace BookService.DAL.Repositories
{
    public class GenreRepository : IRepository<Genre>
    {
        private readonly DataDbContext _dbContext;
        public GenreRepository(DataDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        
        public void Create(Genre entity)
        {
            _dbContext.Genres.Add(entity);
            _dbContext.SaveChanges();
        }

        public async Task CreateAsync(Genre entity)
        {
            _dbContext.Genres.Add(entity);
            await _dbContext.SaveChangesAsync();
        }


        public void Update(Genre entity)
        {
            _dbContext.Entry(entity).State = System.Data.Entity.EntityState.Modified;
            _dbContext.SaveChanges();
        }

        
        public async Task UpdateAsync(Genre entity)
        {
            _dbContext.Entry(entity).State = System.Data.Entity.EntityState.Modified;
            await _dbContext.SaveChangesAsync();
        }


        public IQueryable<Genre> GetAll()
        {
            var books = _dbContext.Genres;
            return books;
        }

        public Task<IQueryable<Genre>> GetAllAsync()
        {
            throw new NotImplementedException();
        }


        public void Delete(Guid id)
        {
            var book = _dbContext.Genres.Find(id);
            if (book != null) _dbContext.Genres.Remove(book);
            _dbContext.SaveChanges();
        }

        public async Task DeleteAsync(Guid id)
        {
            var book = await _dbContext.Genres.FindAsync(id);
            if (book != null) _dbContext.Genres.Remove(book);
            await _dbContext.SaveChangesAsync();
        }

        public Genre GetById(Guid id)
        {
            return _dbContext.Genres.Find(id);
        }
    }
}