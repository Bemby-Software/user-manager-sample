using System.Threading.Tasks;
using System;
using UserManager.Abstractions;

namespace UserManager.Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;
        private readonly IUserFactory _userFactory;

        public UserService(IUserRepository userRepository, IUserFactory userFactory)
        {
            _userRepository = userRepository;
            _userFactory = userFactory;
        }

        public async Task SignUpAsync(string emailAddress, string name)
        {
            var user = _userFactory.Create(emailAddress, name);

            if(emailAddress.Contains("@") is false)
            {
                throw new Exception("The users email address is invalid");
            }

            await _userRepository.AddAsync(user);
        }
    }
}