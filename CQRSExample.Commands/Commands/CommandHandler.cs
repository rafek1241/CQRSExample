using System.Threading.Tasks;
using CQRSExample.Domain.Interfaces;

namespace CQRSExample.Commands.Commands
{
    public abstract class CommandHandler<T> : ICommandHandler<T>, IAsyncCommandHandler<T> where T : ICommand
    {
        protected readonly IEventBus _eventBus;

        protected CommandHandler(IEventBus eventBus)
        {
            _eventBus = eventBus;
        }

        public abstract Task HandleAsync(T command);

        public abstract void Handle(T command);
    }
}