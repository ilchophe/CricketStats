using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CricketStats.Startup))]
namespace CricketStats
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
