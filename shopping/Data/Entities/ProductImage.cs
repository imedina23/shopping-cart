using System.ComponentModel.DataAnnotations;

namespace shopping.Data.Entities
{
    public class ProductImage
    {
        public int Id { get; set; }

        public Product Product { get; set; }

        [Display(Name = "Photo")]
        public Guid ImageId { get; set; }

        //TODO: Pending to change to the correct path
        [Display(Name = "Photo")]
        public string ImageFullPath => ImageId == Guid.Empty
            ? $"https://localhost:7288/images/noimage.png"
            : $"https://shopping23.blob.core.windows.net/products/{ImageId}";

    }
}
