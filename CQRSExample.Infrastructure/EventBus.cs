using System.Threading.Tasks;
using CQRSExample.Domain.Interfaces;
using LightInject;

namespace CQRSExample.Infrastructure
{
    public class EventBus : IEventBus
    {
        private readonly IServiceFactory _factory;

        public EventBus(IServiceFactory factory)
        {
            _factory = factory;
        }

        public void Publish<TEvent>(TEvent @event) where TEvent : IEvent
        {
            var eventHandlers = _factory.GetAllInstances<IEventHandler<TEvent>>();

            foreach (var eventHandler in eventHandlers)
            {
                eventHandler.Handle(@event);
            }
        }

        public async Task PublishAsync<TEvent>(TEvent @event) where TEvent : IEvent
        {
            var eventHandlers = _factory.GetAllInstances<IAsyncEventHandler<TEvent>>();

            foreach (var asyncEventHandler in eventHandlers)
            {
                await asyncEventHandler.HandleAsync(@event);
            }
        }
    }
}
