using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TestMVCTechnology.Startup))]
namespace TestMVCTechnology
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
