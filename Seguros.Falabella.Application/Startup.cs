using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Seguros.Falabella.Application.Startup))]
namespace Seguros.Falabella.Application
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
