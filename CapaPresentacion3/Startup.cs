using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CapaPresentacion3.Startup))]
namespace CapaPresentacion3
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
