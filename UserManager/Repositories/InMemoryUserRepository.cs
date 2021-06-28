using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UserManager.Abstractions;
using UserManager.Models;

namespace UserManager.Repositories
{
    public class InMemoryUserRepository : IUserRepository
    {
        private readonly List<User> _users;

        public InMemoryUserRepository()
        {
            _users = new List<User>();
        }

        public Task AddAsync(User user)
        {
            var highestUserId = _users.OrderBy(user => user.Id).FirstOrDefault();
            user.Id = highestUserId?.Id ?? 1;
            _users.Add(user);
            return Task.CompletedTask;
        }

        public Task<List<User>> GetAllAsync()
        {
            return Task.FromResult(_users);
        }
    }
}