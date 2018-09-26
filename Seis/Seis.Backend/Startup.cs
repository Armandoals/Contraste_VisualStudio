using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Seis.Backend.Startup))]
namespace Seis.Backend
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
