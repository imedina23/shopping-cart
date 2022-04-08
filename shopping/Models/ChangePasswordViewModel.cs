using System.ComponentModel.DataAnnotations;

namespace shopping.Models
{
    public class ChangePasswordViewModel
    {
        [DataType(DataType.Password)]
        [Display(Name = "Current password")]
        [StringLength(20, MinimumLength = 6, ErrorMessage = "The {0} field must be between {2} and {1} characters.")]
        [Required(ErrorMessage = "The field {0} is mandatory.")]
        public string OldPassword { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "New password")]
        [StringLength(20, MinimumLength = 6, ErrorMessage = "The {0} field must be between {2} and {1} characters.")]
        [Required(ErrorMessage = "The field {0} is mandatory.")]
        public string NewPassword { get; set; }

        [Compare("NewPassword", ErrorMessage = "The new password and the confirmation are not the same.")]
        [DataType(DataType.Password)]
        [Display(Name = "Confirm new password")]
        [StringLength(20, MinimumLength = 6, ErrorMessage = "The {0} field must be between {2} and {1} characters.")]
        [Required(ErrorMessage = "The field {0} is mandatory.")]
        public string Confirm { get; set; }

    }
}
