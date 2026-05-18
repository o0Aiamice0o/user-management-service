using Microsoft.EntityFrameworkCore;
using user_management.Data;
using user_management.Interfaces;
using user_management.Models;
using static user_management.Models.UserDto;

namespace user_management.Services
{
    public class UserService : IUser
    {
        private readonly AppDbContext _context;

        public UserService(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<User>> GetAllUsersAsync()
        {
            return await _context.Users.ToListAsync();
        }

        public async Task<User?> GetUserByIdAsync(int id)
        {
            return await _context.Users.FindAsync(id);
        }

        public async Task<User> CreateUserAsync(CreateUserRequest request)
        {
            var user = new User
            {
                FirstName = request.FirstName,
                Surname = request.Surname,
                BirthDate = request.BirthDate,
                Age = request.Age,
                Address = request.Address
            };

            _context.Users.Add(user);
            await _context.SaveChangesAsync();
            return user;
        }
    }
}
