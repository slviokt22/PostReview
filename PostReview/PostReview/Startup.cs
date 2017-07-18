using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PostReview.Startup))]
namespace PostReview
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
