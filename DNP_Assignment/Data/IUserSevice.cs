using System.Threading.Tasks;
using DNP_Assignment.Models;

namespace DNP_Assignment.Data
{
    public interface IUserService {
        Task<User> ValidateUser(string userName, string password);
    }
}