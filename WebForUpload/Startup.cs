using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WebForUpload.Startup))]
namespace WebForUpload
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
