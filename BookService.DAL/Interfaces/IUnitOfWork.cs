using System;
using System.Threading.Tasks;
using BookService.DAL.Entities;

namespace BookService.DAL.Interfaces
{
    public interface IUnitOfWork : IDisposable
    { 
        IRepository<Book> BooksRepo { get; } 
        IRepository<Genre> GenreRepo { get; } 
        IRepository<User> UserRepo { get; }
        Task<int> SaveAsync();
    }
}