using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SalesPlatform.WebUI.Startup))]
namespace SalesPlatform.WebUI
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
