using System.Web.Http;
using CQRSExample.Extensions;
using CQRSExample.Infrastructure;
using CQRSExample.Queries;
using LightInject;

namespace CQRSExample
{
    public class LightInjectConfig
    {
        public static void RegisterContainer(HttpConfiguration configuration)
        {
            var container = new ServiceContainer();

            container.RegisterApiControllers();

            //My registered services
            container.RegisterReadDatabase();

            container.RegisterFrom<InfrastructureModule>();
            container.RegisterFrom<QueriesModule>();

            container.EnableWebApi(configuration);
        }
    }
}
