using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Fury.Startup))]
namespace Fury
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
