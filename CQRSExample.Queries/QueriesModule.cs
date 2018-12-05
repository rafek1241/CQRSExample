using CQRSExample.Queries;
using CQRSExample.Queries.Implementation;
using CQRSExample.Queries.Interface;
using LightInject;
using CQRSExample.Domain.Enums;

[assembly: CompositionRootType(typeof(QueriesModule))]
namespace CQRSExample.Queries
{
    public class QueriesModule : ICompositionRoot
    {
        public void Compose(IServiceRegistry serviceRegistry)
        {
            serviceRegistry.Register<IProductQuery>(
                (factory) => new ProductQuery(factory.GetInstance<string>(ConnectionStrings.ReadDatabase)));
        }
    }
}
