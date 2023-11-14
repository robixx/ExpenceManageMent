using System.ComponentModel.DataAnnotations;

namespace ExpenceManageMent.Models
{
    public class ExpenceManagement :BaseClass
    {
        [Key]
        public int ExpenceId { get; set; }
        [Required]
        public string? ExpenceTitle { get; set; }
        public int CategoryId { get; set; }
        public Category? Category { get; set; }
        public Decimal? Amount { get; set; }


    }
}
