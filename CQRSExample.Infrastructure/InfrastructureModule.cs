using System.Configuration;
using CQRSExample.Commands;
using CQRSExample.Database;
using CQRSExample.Domain.Enums;
using CQRSExample.Domain.Interfaces;
using CQRSExample.Events;
using CQRSExample.Infrastructure;
using LightInject;
using Microsoft.EntityFrameworkCore;

[assembly: CompositionRootType(typeof(InfrastructureModule))]

namespace CQRSExample.Infrastructure
{
    public class InfrastructureModule : ICompositionRoot
    {
        public void Compose(IServiceRegistry serviceRegistry)
        {
            serviceRegistry.RegisterFrom<CommandsModule>();
            serviceRegistry.RegisterFrom<EventsModule>();
            serviceRegistry.RegisterSingleton<ICommandBus>(factory => new CommandBus(factory));
            serviceRegistry.RegisterSingleton<IEventBus>(factory => new EventBus(factory));
            serviceRegistry.Register<CqrsExampleContext>();
            serviceRegistry.Register<DbContextOptions<CqrsExampleContext>>();
            serviceRegistry.RegisterSingleton(
                factory => ConfigurationManager.ConnectionStrings[ConnectionStrings.WriteDatabase].ConnectionString,
                ConnectionStrings.WriteDatabase);
        }
    }
}