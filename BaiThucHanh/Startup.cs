using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(BaiThucHanh.Startup))]
namespace BaiThucHanh
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
