using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;


namespace ExpenceManageMent.Models
{
    
    public class Category : BaseClass
    {
        [Key]
        public  int CategoryId { get; set; }
        [Required]
        public string? CategoryName { get; set; }
        [JsonIgnore]
        public List<ExpenceManagement>? ExpenceManagement { get; set; }
        
    }
}
