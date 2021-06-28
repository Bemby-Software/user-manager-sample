using UserManager.Abstractions;
using UserManager.Models;

namespace UserManager.Factories
{
    public class UserFactory : IUserFactory
    {
        public User Create(string emailAddress, string name)
        {
            return new User()
            {
                EmailAddress = emailAddress,
                Name = name
            };
        }
    }
}