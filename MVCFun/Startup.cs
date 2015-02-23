using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MVCFun.Startup))]
namespace MVCFun
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
