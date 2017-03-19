using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(GospelPark.Membership.Startup))]
namespace GospelPark.Membership
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
