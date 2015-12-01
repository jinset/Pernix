using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(OlympusWeb.Startup))]
namespace OlympusWeb
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
