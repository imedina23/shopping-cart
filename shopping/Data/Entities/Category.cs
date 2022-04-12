using System.ComponentModel.DataAnnotations;

namespace shopping.Data.Entities
{
    public class Category
    {
        public int Id { get; set; }

        [Display(Name = "CATEGORY")]
        [MaxLength(50, ErrorMessage = "The field {0} must not have maximum {1} characters")]
        [Required(ErrorMessage = "The Field {0} is Required")]
        public string Name { get; set; }

        public ICollection<ProductCategory> ProductCategories { get; set; }
    }
}
