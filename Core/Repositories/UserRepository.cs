using Core.Interfaces;
using Data;
using Entities;
using Microsoft.EntityFrameworkCore;

namespace Core.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly ApplicationDbContext _dbContext;

        public UserRepository(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task Create(User user, CancellationToken cancellationToken = default)
        {
            await _dbContext.Users.AddAsync(user);
            await _dbContext.SaveChangesAsync(cancellationToken);
        }

        public async Task Delete(User user)
        {
            _dbContext.Entry(user).State = EntityState.Deleted;
            await _dbContext.SaveChangesAsync();
        }

        public async Task<List<User>> GetAll()
        {
            return await _dbContext.Users.ToListAsync();
        }

        public async Task<User> GetById(int id)
        {
            return await _dbContext.Users.Where(x => x.Id == id).FirstOrDefaultAsync();
        }

        public async Task Update(User user)
        {
            _dbContext.Entry(user).State = EntityState.Modified;
            await _dbContext.SaveChangesAsync();
        }
    }
}
