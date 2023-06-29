using System.ComponentModel.DataAnnotations;

namespace auth_jwt.Models
{
    public class User
    {
        public int userId { get; set; }

        [Required]
        public string Username { get; set; }

        [EmailAddress]
        [Required]
        public string Email { get; set; }

        [Required]
        public byte[] PasswordHash { get; set; }

        [Required]
        public byte[] PasswordSalt { get; set; }

        [Required]
        public string Designation { get; set; }
    }
}
