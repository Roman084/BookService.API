using BookService.DAL.Entities;

namespace BookService.DAL.EF
{
    using  System.Data.Entity;
    
    public class DataDbContext : DbContext
    {
        public DataDbContext(string options) : base(options)
        {
        }
        
        public virtual DbSet<Book> Books { get; set; }
        public virtual DbSet<Genre> Genres { get; set; }
        public virtual DbSet<User> Users { get; set; }
    }
}