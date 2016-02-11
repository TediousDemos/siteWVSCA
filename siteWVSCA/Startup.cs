using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(siteWVSCA.Startup))]
namespace siteWVSCA
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
