using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AgencySite.Startup))]
namespace AgencySite
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
