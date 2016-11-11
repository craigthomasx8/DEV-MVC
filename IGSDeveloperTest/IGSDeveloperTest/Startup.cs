using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(IGSDeveloperTest.Startup))]
namespace IGSDeveloperTest
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
