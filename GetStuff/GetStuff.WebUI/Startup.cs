using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(GetStuff.WebUI.Startup))]
namespace GetStuff.WebUI
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
