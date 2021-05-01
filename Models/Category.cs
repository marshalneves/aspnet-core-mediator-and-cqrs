using System.ComponentModel.DataAnnotations;

namespace api.Models
{

    public class Category
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Title is required")]
        [MaxLength(60, ErrorMessage = "Max length must be 60.")]
        [MinLength(3, ErrorMessage = "Min length must be 3.")]
        public string Title { get; set; }

    }
}