using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SyncfusionMvcApplication1.Startup))]
namespace SyncfusionMvcApplication1
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
