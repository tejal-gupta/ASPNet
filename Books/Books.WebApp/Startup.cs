using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Books.WebApp.Startup))]
namespace Books.WebApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
