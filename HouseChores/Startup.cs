using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(HouseChores.Startup))]
namespace HouseChores
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
