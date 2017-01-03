using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ProfileSearchApp.Startup))]
namespace ProfileSearchApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
