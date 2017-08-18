using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(EstudoWeb1.Startup))]
namespace EstudoWeb1
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
