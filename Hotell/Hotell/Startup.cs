using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Hotell.Startup))]
namespace Hotell
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
