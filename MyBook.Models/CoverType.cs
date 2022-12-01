using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBook.Models
{
    public class CoverType
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [DisplayName("Cover Type")]
        [MaxLength(50, ErrorMessage = "Too long")]
        public string Name { get; set; }
    }
}
