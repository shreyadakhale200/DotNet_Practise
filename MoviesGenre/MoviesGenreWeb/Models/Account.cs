using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace MoviesGenreWeb.Models
{
    public class Account
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Compare("Password", ErrorMessage = "The password and confirmation password do not match.")]
        [DisplayName("Confirm Password")]
        public string ConfirmPassword { get; set; }

        [Required]
        public string Email { get; set; }
        public DateTime GetRecentDateTime { get; set; } = DateTime.Now;
    }
}
