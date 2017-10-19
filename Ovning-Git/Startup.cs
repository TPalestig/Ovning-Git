using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Ovning_Git.Startup))]
namespace Ovning_Git
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
