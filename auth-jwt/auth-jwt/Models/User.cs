using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace auth_jwt.Models
{
    [Table("User")]
    public class User
    {
        [Column("user-id")]
        public int userId { get; set; }

        [Required]
        [Column("username")]
        public string Username { get; set; }

        [EmailAddress]
        [Required]
        [Column("email")]
        public string Email { get; set; }

        [Required]
        public byte[] PasswordHash { get; set; }

        [Required]
        public byte[] PasswordSalt { get; set; }

        [Required]
        public string Designation { get; set; }
    }
}
