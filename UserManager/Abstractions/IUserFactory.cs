using UserManager.Models;

namespace UserManager.Abstractions
{
    public interface IUserFactory
    {
        User Create(string emailAddress, string name);
    }
}