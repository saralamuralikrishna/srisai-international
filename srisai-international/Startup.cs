using Microsoft.Owin;
using Owin;
using srisai_international;

[assembly: OwinStartup(typeof(Startup))]

namespace srisai_international
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
