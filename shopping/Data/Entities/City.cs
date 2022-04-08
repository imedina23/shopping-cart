using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace shopping.Data.Entities
{
    public class City
    {
        public int Id { get; set; }

        [Display(Name = "City")]
        [MaxLength(50, ErrorMessage = "The field {0} must not have maximum {1} characters")]
        [Required(ErrorMessage = "The Field {0} is Required")]
        public string Name { get; set; }
        [JsonIgnore]
        public State State { get; set; }

        public ICollection<User> Users { get; set; }



    }
}
