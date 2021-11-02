using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AFPA.MVCUI.Startup))]
namespace AFPA.MVCUI
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
