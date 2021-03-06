﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FamousQuoteQuiz.Data
{
   public class Quotes
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Content { get; set; }
        [Required]
        public  int AuthorId { get; set; }

        public virtual Author Author { get; set; }
    }
}
