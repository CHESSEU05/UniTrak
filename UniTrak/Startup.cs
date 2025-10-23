using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(UniTrak.Startup))]
namespace UniTrak
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
