using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Team_Up.Startup))]
namespace Team_Up
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
