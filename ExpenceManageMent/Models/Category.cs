using System.ComponentModel.DataAnnotations;

namespace ExpenceManageMent.Models
{
    public class Category : BaseClass
    {
        [Key]
        public  int CategoryId { get; set; }
        [Required]
        public string? CategoryName { get; set; }
        
    }
}
