using System;
using System.Threading.Tasks;
using CQRSExample.Domain.Interfaces;
using LightInject;

namespace CQRSExample.Infrastructure
{
    public class CommandBus : ICommandBus
    {
        private readonly IServiceFactory _factory;

        public CommandBus(IServiceFactory factory)
        {
            _factory = factory;
        }

        public void Send<TCommand>(TCommand command) where TCommand : ICommand
        {
            var handler = GetHandler<ICommandHandler<TCommand>>();

            handler.Handle(command);
        }

        private TCommandHandler GetHandler<TCommandHandler>()
        {
            var handler = _factory.TryGetInstance<TCommandHandler>();

            if (handler == null)
            {
                throw new ArgumentNullException(nameof(TCommandHandler),
                    $"Command handler of type {nameof(TCommandHandler)} must be registered in the factory.");
            }

            return handler;
        }

        public async Task SendAsync<TCommand>(TCommand command) where TCommand : ICommand
        {
            var handler = GetHandler<IAsyncCommandHandler<TCommand>>();

            await handler.HandleAsync(command);
        }
    }
}
