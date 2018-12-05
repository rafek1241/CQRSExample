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

            serviceRegistry.RegisterAssembly(typeof(CreateProductHandler).Assembly);
        }

        public static void RegisterCommandHandlers(IServiceRegistry serviceRegistry)
        {
            serviceRegistry.Register<ICommandHandler<ICommand>, CommandHandler<ICommand>>();
        }

        public static void RegisterAsyncCommandHandlers(IServiceRegistry serviceRegistry)
        {
            serviceRegistry.Register<IAsyncCommandHandler<ICommand>, CommandHandler<ICommand>>();
        }
    }
}
