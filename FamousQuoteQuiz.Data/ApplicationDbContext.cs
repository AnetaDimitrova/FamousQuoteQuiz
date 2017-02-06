
using System.Data.Entity;
using FamousQuoteQuiz.Data;
using FamousQuoteQuiz.Models;
using Microsoft.AspNet.Identity.EntityFramework;

namespace FamousQuoteQuiz.Models
{
    public class ApplicationDbContext : IdentityDbContext<User>
    {
        public ApplicationDbContext()
            : base("DefaultConnection", throwIfV1Schema: false)
        {
        }
        public virtual DbSet<Quotes> Quotes { get; set; }
        public virtual DbSet<Author> Authors { get; set; }

        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }
    }
}
