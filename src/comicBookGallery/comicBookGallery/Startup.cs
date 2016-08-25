using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(comicBookGallery.Startup))]
namespace comicBookGallery
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
