using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CSSamlShibExample.Startup))]
namespace CSSamlShibExample
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
