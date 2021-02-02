using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElevenNoteTwo.Models
{
    public class CategoryEdit
    {
        public int CategoryId { get; set; }

        [Required]
        [Display(Name="Category")]
        public string Name { get; set; }
    }
}
