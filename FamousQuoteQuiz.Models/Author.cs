using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FamousQuoteQuiz.Data
{
   public class Author
    {
        public Author()
        {
            this.Quotes = new HashSet<Quotes>();
        }

        [Key]
        public  int Id { get; set; }

        [Required]
        [MaxLength(450)]
        [Index(IsUnique = true)]
        public string Name { get; set; }

        public virtual ICollection<Quotes> Quotes { get; set; }

    }
}
