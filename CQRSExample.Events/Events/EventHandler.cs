using System.Threading.Tasks;
using CQRSExample.Domain.Interfaces;

namespace CQRSExample.Events.Events
{
    public abstract class EventHandler<T> : IEventHandler<T>, IAsyncEventHandler<T> where T : IEvent
    {
        protected readonly IEventBus _eventBus;

        protected EventHandler(IEventBus eventBus)
        {
            _eventBus = eventBus;
        }

        public abstract void Handle(T @event);

        public abstract Task HandleAsync(T @event);
    }
}
