using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using FamousQuoteQuiz.Data;

namespace FamousQuoteQuiz.App.Controllers
{
    public class BaseController : Controller
    {
        public BaseController(IFamousQuoteQuizData data)
        {
            this.Data = data;
        }



        public BaseController(IFamousQuoteQuizData data, User user)
           : this(data)
        {
            this.UserProfile = user;
        }


        public IFamousQuoteQuizData Data { get; private set; }

        public User UserProfile { get; set; }




        protected override IAsyncResult BeginExecute(RequestContext requestContext, AsyncCallback callback, object state)
        {
            if (requestContext.HttpContext.User.Identity.IsAuthenticated)
            {
                var username = requestContext.HttpContext.User.Identity.Name;
                var user = this.Data.Users.All().FirstOrDefault(u => u.UserName == username);
                this.UserProfile = user;
            }

            return base.BeginExecute(requestContext, callback, state);
        }

    }
}