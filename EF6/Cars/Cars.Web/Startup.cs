using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Cars.Web.Startup))]
namespace Cars.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
