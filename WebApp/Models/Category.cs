
using System.ComponentModel.DataAnnotations;

namespace WebApp.Models
{
    public class Category
    {
        public int CategoryId { get; set; }

        // validation needed,  name shall not be empty
        [Required] 
        public string Name { get; set; } = string.Empty; 
        public string? Description { get; set; } = string.Empty;
    }
}