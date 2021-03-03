using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AngularCrudWithModal.Startup))]
namespace AngularCrudWithModal
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
