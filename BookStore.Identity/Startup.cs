using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(BookStore.Identity.Startup))]
namespace BookStore.Identity
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
