using System.Configuration;
using CQRSExample.Domain.Enums;
using LightInject;

namespace CQRSExample.Extensions
{
    public static class ServiceContainerExtensions
    {
        public static void RegisterReadDatabase(this ServiceContainer container)
        {
            container.RegisterSingleton(
                (factory) => ConfigurationManager.ConnectionStrings[ConnectionStrings.ReadDatabase].ConnectionString,
                             ConnectionStrings.ReadDatabase);
        }
    }
}
