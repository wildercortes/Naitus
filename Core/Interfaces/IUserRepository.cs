using Entities;

namespace Core.Interfaces
{
    public  interface IUserRepository
    {
        Task<User> GetById(int id);

        Task<List<User>> GetAll();

        Task Create(User user, CancellationToken cancellationToken = default(CancellationToken));

        Task Update(User user);

        Task Delete(User user);
    }
}
