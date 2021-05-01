using System.ComponentModel.DataAnnotations;

namespace api.Models
{
    public class Product
    {

        public int Id { get; set; }

        [Required(ErrorMessage = "Title is required")]
        [MaxLength(60, ErrorMessage = "Max length must be 60.")]
        [MinLength(10, ErrorMessage = "Min length must be 10.")]
        public string Title { get; set; }

        [Required(ErrorMessage = "Description is required")]
        [MinLength(10, ErrorMessage = "Min length must be 10.")]
        public string Description { get; set; }

        [Required(ErrorMessage = "Price is required.")]
        [Range(1, int.MaxValue, ErrorMessage = "Price must be greater than 0.")]
        public decimal Price { get; set; }
        
        [Required(ErrorMessage = "Category is required.")]
        [Range(1, int.MaxValue, ErrorMessage = "Category Id is invalid.")]
        public int CategoryId { get; set; }

        public Category Category { get; set; }

    }

}