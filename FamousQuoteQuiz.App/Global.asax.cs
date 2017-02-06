

using Microsoft.Web.Infrastructure;

namespace FamousQuoteQuiz.App
{
    using System.Web.Mvc;
    using System.Web.Optimization;
    using System.Web.Routing;

    using FamousQuoteQuiz.Data.Migrations;
    using System.Data.Entity;
    using System.Reflection;
    using FamousQuoteQuiz.App.App_Start;
    using FamousQuoteQuiz.Models;
   

    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            Database.SetInitializer(
                   new MigrateDatabaseToLatestVersion<ApplicationDbContext, Configuration>());

            MapperConfig.ConfigureMappings();
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);

        }
    }
}
