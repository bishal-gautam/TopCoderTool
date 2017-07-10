using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TopCoderTool.Startup))]
namespace TopCoderTool
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
