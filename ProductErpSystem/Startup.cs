using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ProductErpSystem.Startup))]
namespace ProductErpSystem
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
