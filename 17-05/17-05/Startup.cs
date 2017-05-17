using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(_17_05.Startup))]
namespace _17_05
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
