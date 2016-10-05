using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(odev2.Startup))]
namespace odev2
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
