using System;
using System.Threading.Tasks;
using UserManager.Factories;
using UserManager.Repositories;
using UserManager.Services;

namespace UserManager
{
    class Program
    {
        static async Task Main(string[] args)
        {
            await BasicVersion();
        }

        private static async Task BasicVersion()
        {
            var factory = new UserFactory();
            var repository = new InMemoryUserRepository();
            var userService = new UserService(repository, factory);

            await userService.SignUpAsync("joe.bloggs@hotmail.com", "Joe Bloggs");
            await userService.SignUpAsync("mary.bloggs@hotmail.com", "Mary Bloggs");

            var users = await repository.GetAllAsync();

            foreach (var user in users)
            {
                Console.WriteLine($"Id: {user.Id} Name: {user.Name} Email: {user.EmailAddress}");
            }
        }
    }
}
