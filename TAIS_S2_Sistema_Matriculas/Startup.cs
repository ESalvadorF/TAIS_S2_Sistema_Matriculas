using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TAIS_S2_Sistema_Matriculas.Startup))]
namespace TAIS_S2_Sistema_Matriculas
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
