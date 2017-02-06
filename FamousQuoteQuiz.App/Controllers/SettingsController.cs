using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using FamousQuoteQuiz.Data;

namespace FamousQuoteQuiz.App.Controllers
{
    public class SettingsController : BaseController
    {
        
         public SettingsController(IFamousQuoteQuizData data)
            : base(data)
        {
        }
        public ActionResult Index()
        {
            return View();
        }
    }
}