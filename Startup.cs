using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AzureAppserviceTesting.Startup))]
namespace AzureAppserviceTesting
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
