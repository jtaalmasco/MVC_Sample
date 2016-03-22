using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Information_Database_Sample.Startup))]
namespace Information_Database_Sample
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
        }
    }
}
