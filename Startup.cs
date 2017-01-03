using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Cassandra_Employee.Startup))]
namespace Cassandra_Employee
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
