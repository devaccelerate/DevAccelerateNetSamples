using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Ejyle.DevAccelerate.Samples.AspNetMvc.Startup))]
namespace Ejyle.DevAccelerate.Samples.AspNetMvc
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
