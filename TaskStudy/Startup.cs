using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TaskStudy.Startup))]
namespace TaskStudy
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
