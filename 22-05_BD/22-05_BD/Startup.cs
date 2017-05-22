using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(_22_05_BD.Startup))]
namespace _22_05_BD
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
