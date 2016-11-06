using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Exercicio_03.Startup))]
namespace Exercicio_03
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
