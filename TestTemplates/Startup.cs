using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TestTemplates.Startup))]
namespace TestTemplates
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
