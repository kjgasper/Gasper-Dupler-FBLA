using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(FBLA_Web.Startup))]
namespace FBLA_Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
