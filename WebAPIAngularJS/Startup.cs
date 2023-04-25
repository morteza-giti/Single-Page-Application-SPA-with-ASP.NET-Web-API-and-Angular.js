using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WebAPIAngularJS.Startup))]
namespace WebAPIAngularJS
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
