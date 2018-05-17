using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(proyectoFacturacion.Startup))]
namespace proyectoFacturacion
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
