namespace user_management.Models
{
    public class UserDto
    {
        public class CreateUserRequest
        {
            public string FirstName { get; set; } = string.Empty;
            public string Surname { get; set; } = string.Empty;
            public DateTime BirthDate { get; set; }
            public int Age { get; set; }
            public string Address { get; set; } = string.Empty;
        }
    }
}
