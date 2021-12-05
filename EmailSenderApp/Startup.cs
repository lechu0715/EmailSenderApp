using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(EmailSenderApp.Startup))]
namespace EmailSenderApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
