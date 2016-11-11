using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DemoSemantic.Startup))]
namespace DemoSemantic
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
