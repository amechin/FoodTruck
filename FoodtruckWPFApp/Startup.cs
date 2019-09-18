using Microsoft.Owin;
using Owin;

[assembly: OwinStartup(typeof(FoodtruckWPFApp.StartupOwin))]

namespace FoodtruckWPFApp
{
    public partial class StartupOwin
    {
        public void Configuration(IAppBuilder app)
        {
            //AuthStartup.ConfigureAuth(app);
        }
    }
}
