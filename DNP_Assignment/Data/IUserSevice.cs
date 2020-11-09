using DNP_Assignment.Models;

namespace DNP_Assignment.Data
{
    public interface IUserService {
        User ValidateUser(string userName, string password);
    }
}