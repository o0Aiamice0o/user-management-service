using Microsoft.AspNetCore.Mvc;
using user_management.Interfaces;
using static user_management.Models.UserDto;

namespace user_management.Controllers
{
    [ApiController]
    [Route("api/users")]
    public class UsersTetsController : ControllerBase
    {
        private readonly IUser _user;

        // Inject Interface เข้ามาใช้งาน (Loose Coupling)
        public UsersTetsController(IUser user)
        {
            _user = user;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var users = await _user.GetAllUsersAsync();
            return Ok(users);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var user = await _user.GetUserByIdAsync(id);
            if (user == null) return NotFound(new { message = "User not found" });

            return Ok(user);
        }

        [HttpPost]
        public async Task<IActionResult> Create(CreateUserRequest userDto)
        {
            var createdUser = await _user.CreateUserAsync(userDto);
            return CreatedAtAction(nameof(GetById), new { id = createdUser.Id }, createdUser);
        }
    }
}
