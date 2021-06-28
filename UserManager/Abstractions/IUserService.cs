using System.Threading.Tasks;

namespace UserManager.Abstractions
{
    public interface IUserService
    {
         Task SignUpAsync(string emailAddress, string name);
    }
}