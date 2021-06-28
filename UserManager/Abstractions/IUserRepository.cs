using System.Collections.Generic;
using System.Threading.Tasks;
using UserManager.Models;

namespace UserManager.Abstractions
{
    public interface IUserRepository
    {
         Task AddAsync(User user);

         Task<List<User>> GetAllAsync();
    }
}