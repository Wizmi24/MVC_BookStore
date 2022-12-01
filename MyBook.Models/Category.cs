using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace MyBook.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [DisplayName("Dispay Order")]
        [Range(1, 100, ErrorMessage = "Dispay Order must be between 1 and 100")]
        public int DisplayOrder { get; set; }
        public DateTime CreatedDateTime { get; set; } = DateTime.Now;
    }
}
