using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WebFixShop.Web.Startup))]
namespace WebFixShop.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
