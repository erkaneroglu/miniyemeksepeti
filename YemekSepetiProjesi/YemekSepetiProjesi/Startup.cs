using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(YemekSepetiProjesi.Startup))]
namespace YemekSepetiProjesi
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
