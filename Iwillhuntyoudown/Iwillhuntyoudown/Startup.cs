using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Iwillhuntyoudown.Startup))]
namespace Iwillhuntyoudown
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
