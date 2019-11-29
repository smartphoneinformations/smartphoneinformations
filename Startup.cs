using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SmartphoneInformations.Startup))]
namespace SmartphoneInformations
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
