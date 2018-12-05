using System.Reflection;
using CQRSExample.Commands;
using CQRSExample.Commands.Commands;
using CQRSExample.Domain.Commands;
using CQRSExample.Domain.Interfaces;
using LightInject;

[assembly: CompositionRootType(typeof(CommandsModule))]
namespace CQRSExample.Commands
{
    public class CommandsModule : ICompositionRoot
    {
        public void Compose(IServiceRegistry serviceRegistry)
        {
            RegisterCommandHandlers(serviceRegistry);
            RegisterAsyncCommandHandlers(serviceRegistry);
        }

        public static void RegisterCommandHandlers(IServiceRegistry serviceRegistry)
        {
            serviceRegistry.RegisterAssembly(typeof(CommandsModule).Assembly,
                (s, _) => s.IsGenericType && s.GetGenericTypeDefinition() == typeof(ICommandHandler<>));
        }

        public static void RegisterAsyncCommandHandlers(IServiceRegistry serviceRegistry)
        {
            serviceRegistry.RegisterAssembly(typeof(CommandsModule).Assembly,
                (s, _) => s.IsGenericType && s.GetGenericTypeDefinition() == typeof(IAsyncCommandHandler<>));
        }
    }
}
