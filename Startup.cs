using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Courselee.Startup))]
namespace Courselee
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
