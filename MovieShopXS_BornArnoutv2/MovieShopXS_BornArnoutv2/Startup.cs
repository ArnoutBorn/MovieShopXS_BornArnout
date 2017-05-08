using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MovieShopXS_BornArnoutv2.Startup))]
namespace MovieShopXS_BornArnoutv2
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
