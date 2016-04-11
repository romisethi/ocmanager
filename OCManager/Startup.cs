using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(OCManager.Startup))]
namespace OCManager
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
