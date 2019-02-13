using System;
using System.Threading.Tasks;
using Microsoft.Owin;
using Owin;

[assembly: OwinStartup(typeof(User.Identity.Provider.Startup))]

namespace User.Identity.Provider
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
           
        }
    }
}
