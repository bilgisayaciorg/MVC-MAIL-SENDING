using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MVC_MAIL_SENDING.Startup))]
namespace MVC_MAIL_SENDING
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
