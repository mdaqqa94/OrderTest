using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(OrderNewMVC.Startup))]
namespace OrderNewMVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);

        }
    }
}
