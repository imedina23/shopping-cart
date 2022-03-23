using System.ComponentModel.DataAnnotations;

namespace shopping.Data.Entities
{
    public class State
    {
        public int Id { get; set; }

        [Display(Name = "STATE")]
        [MaxLength(50, ErrorMessage = "The field {0} must not have maximum {1} characters")]
        [Required(ErrorMessage = "The Field {0} is Required")]
        public string Name { get; set; }

        public Country Country { get; set; }

        public ICollection<City> Cities { get; set; }

        [Display(Name = "Cities")]
        public int CitiesNumber => Cities == null ? 0 : Cities.Count;
    }
}
