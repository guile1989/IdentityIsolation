using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TT.Presentation.UI.MVC.Startup))]
namespace TT.Presentation.UI.MVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
