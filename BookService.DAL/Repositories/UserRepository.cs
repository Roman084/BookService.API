using System;
using System.Linq;
using System.Threading.Tasks;
using BookService.DAL.EF;
using BookService.DAL.Entities;
using BookService.DAL.Interfaces;

namespace BookService.DAL.Repositories
{
    public class UserRepository : IRepository<User>
    {
        private readonly DataDbContext _dbContext;
        public UserRepository(DataDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        
        public void Create(User entity)
        {
            _dbContext.Users.Add(entity);
            _dbContext.SaveChanges();
        }

        public async Task CreateAsync(User entity)
        {
            _dbContext.Users.Add(entity);
            await _dbContext.SaveChangesAsync();
        }


        public void Update(User entity)
        {
            _dbContext.Entry(entity).State = System.Data.Entity.EntityState.Modified;
            _dbContext.SaveChanges();
        }

        
        public async Task UpdateAsync(User entity)
        {
            _dbContext.Entry(entity).State = System.Data.Entity.EntityState.Modified;
            await _dbContext.SaveChangesAsync();
        }


        public IQueryable<User> GetAll()
        {
            var users = _dbContext.Users;
            return users;
        }

        public Task<IQueryable<User>> GetAllAsync()
        {
            throw new NotImplementedException();
        }


        public void Delete(Guid id)
        {
            var user = _dbContext.Users.Find(id);
            if (user != null) _dbContext.Users.Remove(user);
            _dbContext.SaveChanges();
        }

        public async Task DeleteAsync(Guid id)
        {
            var user = await _dbContext.Users.FindAsync(id);
            if (user != null) _dbContext.Users.Remove(user);
            await _dbContext.SaveChangesAsync();
        }

        public User GetById(Guid id)
        {
            var user = _dbContext.Users.Find(id);
            return user;
        }
    }
}