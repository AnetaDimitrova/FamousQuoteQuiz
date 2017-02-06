using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(FamousQuoteQuiz.App.Startup))]
namespace FamousQuoteQuiz.App
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
