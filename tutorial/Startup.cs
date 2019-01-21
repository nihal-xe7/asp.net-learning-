using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(tutorial.Startup))]
namespace tutorial
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
