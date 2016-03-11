using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(W1HW.Startup))]
namespace W1HW
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
