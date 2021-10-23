using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(NKSLK.Startup))]
namespace NKSLK
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
