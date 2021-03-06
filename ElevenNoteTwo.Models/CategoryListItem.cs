﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElevenNoteTwo.Models
{
    class CategoryListItem
    {
        public int CategoryId { get; set; }

        [Required]
        [Display(Name="Category")]
        public string Name { get; set; }
    }
}
