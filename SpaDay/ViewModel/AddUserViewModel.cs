using System.ComponentModel.DataAnnotations;

namespace SpaDay.ViewModel
{
    public class AddUserViewModel
    {
        [Required(ErrorMessage = "Need a username.")]
        [StringLength(15, MinimumLength = 5, ErrorMessage = "Username must be between 5-15 characters.")]
        public string Username { get; set; }

        [EmailAddress]
        public string Email { get; set; }
        
        [Required(ErrorMessage = "Need a password.")]
        [StringLength(20, MinimumLength = 6, ErrorMessage = "Password must be between 6-20 characters.")]

        public string Password { get; set; }
        
        [Required(ErrorMessage = "Enter the password again.")]
        [StringLength(20, MinimumLength = 6, ErrorMessage = "Password must be between 6-20 characters.")]
        public string VerifyPassword { get; set; }
    }
}
