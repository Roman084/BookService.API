using System;
using System.Linq;
using System.Threading.Tasks;
using BookService.DAL.EF;
using BookService.DAL.Entities;
using BookService.DAL.Interfaces;

namespace BookService.DAL.Repositories
{
    public class BookRepository : IRepository<Book>
    {
        private readonly DataDbContext _dbContext;
        public BookRepository(DataDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        
        public void Create(Book entity)
        {
            _dbContext.Books.Add(entity);
            _dbContext.SaveChanges();
        }

        public async Task CreateAsync(Book entity)
        {
            _dbContext.Books.Add(entity);
            await _dbContext.SaveChangesAsync();
        }


        public void Update(Book entity)
        {
            _dbContext.Entry(entity).State = System.Data.Entity.EntityState.Modified;
            _dbContext.SaveChanges();
        }

        
        public async Task UpdateAsync(Book entity)
        {
            _dbContext.Entry(entity).State = System.Data.Entity.EntityState.Modified;
            await _dbContext.SaveChangesAsync();
        }


        public IQueryable<Book> GetAll()
        {
            var books = _dbContext.Books;
            return books;
        }

        public Task<IQueryable<Book>> GetAllAsync()
        {
            throw new NotImplementedException();
        }


        public void Delete(Guid id)
        {
            var book = _dbContext.Books.Find(id);
            if (book != null) _dbContext.Books.Remove(book);
            _dbContext.SaveChanges();
        }

        public async Task DeleteAsync(Guid id)
        {
            var book = await _dbContext.Books.FindAsync(id);
            if (book != null) _dbContext.Books.Remove(book);
            await _dbContext.SaveChangesAsync();
        }

        public Book GetById(Guid id)
        {
            return _dbContext.Books.Find(id);
        }
    }
}