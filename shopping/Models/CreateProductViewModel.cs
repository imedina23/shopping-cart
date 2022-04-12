﻿using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel.DataAnnotations;

namespace shopping.Models
{
    public class CreateProductViewModel : EditProductViewModel
    {
        [Display(Name = "Category")]
        [Range(1, int.MaxValue, ErrorMessage = "You must select a category.")]
        [Required(ErrorMessage = "The field {0} is mandatory.")]
        public int CategoryId { get; set; }

        public IEnumerable<SelectListItem> Categories { get; set; }

        [Display(Name = "Photo")]
        public IFormFile? ImageFile { get; set; }
    }

}
