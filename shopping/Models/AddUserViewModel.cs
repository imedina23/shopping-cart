using shopping.Enums;
using System.ComponentModel.DataAnnotations;

namespace shopping.Models
{
    public class AddUserViewModel : EditUserViewModel
    {
        [Display(Name = "Email")]
        [EmailAddress(ErrorMessage = "You must enter a valid email address.")]
        [MaxLength(100, ErrorMessage = "The field {0} must have a maximum of {1} characters.")]
        [Required(ErrorMessage = "The field {0} is required")]
        public string Username { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        [Required(ErrorMessage = "The field {0} is required")]
        [StringLength(20, MinimumLength = 6, ErrorMessage = "The {0} field must be between {2} and {1} characters.")]
        public string Password { get; set; }

        [Compare("Password", ErrorMessage = "Password and confirmation are not the same.")]
        [Display(Name = "Password confirmation")]
        [DataType(DataType.Password)]
        [Required(ErrorMessage = "The field {0} is required")]
        [StringLength(20, MinimumLength = 6, ErrorMessage = "The {0} field must be between {2} and {1} characters.")]
        public string PasswordConfirm { get; set; }

        [Display(Name = "Type of User")]
        public UserType UserType { get; set; }

    }
}
