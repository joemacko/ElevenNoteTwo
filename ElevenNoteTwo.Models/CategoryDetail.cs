﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElevenNoteTwo.Models
{
    public class CategoryDetail
    {
        public int CategoryId { get; set; }

        [Display(Name="Category")]
        public string Name { get; set; }
    }
}
