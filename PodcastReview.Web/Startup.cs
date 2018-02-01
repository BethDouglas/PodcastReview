using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PodcastReview.Web.Startup))]
namespace PodcastReview.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
