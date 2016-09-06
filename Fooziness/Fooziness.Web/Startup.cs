using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Fooziness.Web.Startup))]
namespace Fooziness.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
