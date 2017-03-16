using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Web.Transport.Startup))]
namespace Web.Transport
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
