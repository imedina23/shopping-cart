using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel.DataAnnotations;

namespace shopping.Models
{
    public class EditUserViewModel
    {
        public string Id { get; set; }

        [Display(Name = "Document")]
        [MaxLength(20, ErrorMessage = "The field {0} must not have maximum {1} characters")]
        [Required(ErrorMessage = "The Field {0} is Required")]
        public string Document { get; set; }

        [Display(Name = "Name")]
        [MaxLength(50, ErrorMessage = "The field {0} must not have maximum {1} characters")]
        [Required(ErrorMessage = "The Field {0} is Required")]
        public string FirstName { get; set; }

        [Display(Name = "LastName")]
        [MaxLength(50, ErrorMessage = "The field {0} must not have maximum {1} characters")]
        [Required(ErrorMessage = "The Field {0} is Required")]
        public string LastName { get; set; }

        [Display(Name = "Address")]
        [MaxLength(200, ErrorMessage = "The field {0} must not have maximum {1} characters")]
        [Required(ErrorMessage = "The Field {0} is Required")]
        public string Address { get; set; }

        [Display(Name = "Phone")]
        [MaxLength(20, ErrorMessage = "The field {0} must not have maximum {1} characters")]
        [Required(ErrorMessage = "The Field {0} is Required")]
        public string PhoneNumber { get; set; }

        [Display(Name = "Photo")]
        public Guid ImageId { get; set; }

        //TODO: Pending to put the correct paths
        [Display(Name = "Photo")]
        public string ImageFullPath => ImageId == Guid.Empty
            ? $"https://localhost:7288/images/noimage.png"
            : $"https://shopping23.blob.core.windows.net/users/{ImageId}";

        [Display(Name = "Image")]
        public IFormFile ImageFile { get; set; }

        [Display(Name = "Country")]
        [Range(1, int.MaxValue, ErrorMessage = "Please select a Country")]
        [Required(ErrorMessage = "The Field {0} is Required")]
        public int CountryId { get; set; }

        public IEnumerable<SelectListItem> Countries { get; set; }

        [Display(Name = "State")]
        [Range(1, int.MaxValue, ErrorMessage = "Please select a State")]
        [Required(ErrorMessage = "The Field {0} is Required")]
        public int StateId { get; set; }

        public IEnumerable<SelectListItem> States { get; set; }

        [Display(Name = "Cities")]
        [Range(1, int.MaxValue, ErrorMessage = "Please select a City")]
        public int CityId { get; set; }

        public IEnumerable<SelectListItem> Cities { get; set; }




    }
}
