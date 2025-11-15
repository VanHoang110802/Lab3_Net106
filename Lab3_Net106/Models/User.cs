using System.ComponentModel.DataAnnotations;

namespace Lab3_Net106.Models
{
    public class User
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(50)]
        public string Username { get; set; }

        [Required]
        [MaxLength(100)]
        public string Password { get; set; }

        [Required]
        [RegularExpression("^(Admin|User)$", ErrorMessage = "Role chỉ được là Admin hoặc User")]
        public string Role { get; set; }
    }
}
