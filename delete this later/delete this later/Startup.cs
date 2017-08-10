using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(delete_this_later.Startup))]
namespace delete_this_later
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
