using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElevenNoteTwo.Models
{
    public class CategoryCreate
    {
        [Required]
        [StringLength(50, ErrorMessage = "Please use less than 50 characters")]
        [Display(Name="Category")]
        public string Name { get; set; }
    }
}
