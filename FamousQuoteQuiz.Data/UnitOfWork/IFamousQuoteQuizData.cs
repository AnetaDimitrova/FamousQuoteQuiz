using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FamousQuoteQuiz.Data.Repositories;

namespace FamousQuoteQuiz.Data
{
    public interface IFamousQuoteQuizData
    {


        DbContext Context { get; }

        IRepository<User> Users { get; }

        IRepository<Quotes> Quotes { get; }

        IRepository<Author> Authors { get; }

        void Dispose();

        int SaveChanges();



    }
}
