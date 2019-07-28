using System.Threading.Tasks;
using SocialNetworkingApp.API.Models;

namespace SocialNetworkingApp.API.Data
{
    public interface IAuthRepository
    {
        Task<User> RegisterAsync(User user, string passowrd);
        Task<User> Login(string username, string passowrd);
        Task<bool> UserExists(string username);
    }
}