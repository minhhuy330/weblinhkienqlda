using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Webbaocao.Startup))]
namespace Webbaocao
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
