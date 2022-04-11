using System.ComponentModel.DataAnnotations;

namespace shopping.Models
{
    public class ResetPasswordViewModel
    {
        [Display(Name = "Email")]
        [EmailAddress(ErrorMessage = "You must enter a valid email address.")]
        [Required(ErrorMessage = "The field {0} is mandatory.")]
        public string UserName { get; set; }

        [DataType(DataType.Password)]
        [Required(ErrorMessage = "The field {0} is mandatory.")]
        [StringLength(20, MinimumLength = 6, ErrorMessage = "The {0} field must be between {2} and {1} characters.")]
        public string Password { get; set; }

        [Compare("Password", ErrorMessage = "The new password and the confirmation are not the same.")]
        [DataType(DataType.Password)]
        [Required(ErrorMessage = "The field {0} is mandatory.")]
        [StringLength(20, MinimumLength = 6, ErrorMessage = "El campo {0} debe tener entre {2} y {1} carácteres.")]
        public string ConfirmPassword { get; set; }

        [Required(ErrorMessage = "The field {0} is mandatory.")]
        public string Token { get; set; }

    }
}
