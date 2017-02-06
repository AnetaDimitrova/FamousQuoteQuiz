using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FamousQuoteQuiz.Data;
using Microsoft.AspNet.Identity;
using System.Web.Configuration;
using FamousQuoteQuiz.Data.Repositories;
using Microsoft.AspNet.Identity.EntityFramework;

namespace FamousQuoteQuiz.Data
{
    public class FamousQuoteQuizData : IFamousQuoteQuizData
    {
        private readonly DbContext context;

        private readonly Dictionary<Type, object> repositories = new Dictionary<Type, object>();
        public FamousQuoteQuizData(DbContext context)
        {
            this.context = context;
        }
        public DbContext Context
        {
            get
            {
                return this.context;
            }
        }

        public IRepository<User> Users
        {

            get
            {
                return this.GetRepository<User>();
            }
        }

        public IRepository<Quotes> Quotes
        {
            get
            {
                return this.GetRepository<Quotes>();
            }
        }

        public IRepository<Author> Authors
        {
            get
            {
                return this.GetRepository<Author>();
            }
        }

        public void Dispose()
        {
            this.Dispose(true);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (this.context != null)
                {
                    this.context.Dispose();
                }
            }
        }

        public int SaveChanges()
        {
            return this.context.SaveChanges();
        }

        private IRepository<T> GetRepository<T>() where T : class
        {
            if (!this.repositories.ContainsKey(typeof(T)))
            {
                var type = typeof(GenericEfRepository<T>);

                this.repositories.Add(typeof(T), Activator.CreateInstance(type, this.context));
            }

            return (IRepository<T>)this.repositories[typeof(T)];
        }

    }
}


