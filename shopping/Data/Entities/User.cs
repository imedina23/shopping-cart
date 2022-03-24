using Microsoft.AspNetCore.Identity;
using shopping.Enums;
using System.ComponentModel.DataAnnotations;

namespace shopping.Data.Entities
{
    public class User : IdentityUser
    {

        [Display(Name = "Document")]
        [MaxLength(20, ErrorMessage = "The field {0} must have a maximum of {1} characters.")]
        [Required(ErrorMessage = "The field {0} is required.")]
        public string Document { get; set; }

        [Display(Name = "Names")]
        [MaxLength(50, ErrorMessage = "The field {0} must have a maximum of {1} characters.")]
        [Required(ErrorMessage = "The field {0} is mandatory.")]
        public string FirstName { get; set; }

        [Display(Name = "LastName")]
        [MaxLength(50, ErrorMessage = "The field {0} must have a maximum of {1} characters.")]
        [Required(ErrorMessage = "The field {0} is mandatory.")]
        public string LastName { get; set; }

        [Display(Name = "City")]
        public City City { get; set; }

        [Display(Name = "Dirección")]
        [MaxLength(200, ErrorMessage = "The field {0} must have a maximum of {1} characters.")]
        [Required(ErrorMessage = "The field {0} is mandatory.")]
        public string Address { get; set; }

        [Display(Name = "Picture")]
        public Guid ImageId { get; set; }

        //TODO: Pending to put the correct paths
        [Display(Name = "Picture")]
        public string ImageFullPath => ImageId == Guid.Empty
            ? $"https://localhost:7288/images/noimage.png"
            : $"https://shoppingprep.blob.core.windows.net/users/{ImageId}";

        [Display(Name = "UserType")]
        public UserType UserType { get; set; }

        
        [Display(Name = "User")]
        public string FullName => $"{FirstName} {LastName}";

        [Display(Name = "User")]
        public string FullNameWithDocument => $"{FirstName} {LastName} - {Document}";


    }
}
