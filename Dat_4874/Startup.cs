using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Dat_4874.Startup))]
namespace Dat_4874
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
