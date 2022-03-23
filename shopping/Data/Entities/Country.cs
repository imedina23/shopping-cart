using System.ComponentModel.DataAnnotations;

namespace shopping.Data.Entities
{
    public class Country
    {
        public int Id { get; set; }

        [Display(Name ="COUNTRY")]
        [MaxLength(50, ErrorMessage ="The field {0} must not have maximum {1} characters")]
        [Required(ErrorMessage ="The Field {0} is Required")]
        public string Name { get; set; }    
    }
}
