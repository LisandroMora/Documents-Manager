using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CapaPresentacion2.Startup))]
namespace CapaPresentacion2
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
