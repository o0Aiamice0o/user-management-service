using user_management.Models;
using static user_management.Models.UserDto;

namespace user_management.Interfaces
{
    public interface IUser
    {
        Task<IEnumerable<User>> GetAllUsersAsync();
        Task<User?> GetUserByIdAsync(int id);
        Task<User> CreateUserAsync(CreateUserRequest userDto);
    }
}
