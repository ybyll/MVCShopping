using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MVCShopping.Web.Startup))]
namespace MVCShopping.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
