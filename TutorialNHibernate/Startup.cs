using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TutorialNHibernate.Startup))]
namespace TutorialNHibernate
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
