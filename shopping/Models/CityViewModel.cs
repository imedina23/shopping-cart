using System.ComponentModel.DataAnnotations;

namespace shopping.Models
{
    public class CityViewModel
    {
        public int Id { get; set; }

        [Display(Name = "City")]
        [MaxLength(50, ErrorMessage = "The field {0} must not have maximum {1} characters")]
        [Required(ErrorMessage = "The Field {0} is Required")]
        public string Name { get; set; }

        public int StateId { get; set; }

    }
}
