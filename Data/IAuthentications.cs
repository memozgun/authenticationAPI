using System.Threading.Tasks;
using AuthenticationAPI.Models;

namespace AuthenticationAPI.Data
{
    public interface IAuthentications
    {
         Task<User> Register(User user, string password);
         Task<User> Login(string username, string password);
         Task<bool> UserExists(string username);
    }
}