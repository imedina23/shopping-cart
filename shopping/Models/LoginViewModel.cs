using System.ComponentModel.DataAnnotations;

namespace shopping.Models
{
    public class LoginViewModel
    {
        [Display(Name = "Email")]
        [Required(ErrorMessage = "The {0} field is required.")]
        [EmailAddress(ErrorMessage = "You must enter a valid email address.")]
        public string Username { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        [Required(ErrorMessage = "The {0} field is required.")]
        [MinLength(6, ErrorMessage = "The {0} field must have at least {1} characters.")]
        public string Password { get; set; }

        [Display(Name = "Remember me in this browser")]
        public bool RememberMe { get; set; }

    }
}
