using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AirScheduler.Startup))]
namespace AirScheduler
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
