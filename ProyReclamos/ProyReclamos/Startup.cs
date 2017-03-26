using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ProyReclamos.Startup))]
namespace ProyReclamos
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
