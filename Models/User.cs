using System.ComponentModel.DataAnnotations;

namespace user_management.Models
{
    public class User
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        public string FirstName { get; set; } = string.Empty;

        [Required]
        [StringLength(100)]
        public string Surname { get; set; } = string.Empty;

        public DateTime BirthDate { get; set; }

        public int Age { get; set; }

        public string Address { get; set; } = string.Empty;
    }
}
