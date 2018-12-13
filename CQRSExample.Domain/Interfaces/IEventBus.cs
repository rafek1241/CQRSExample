using System.Threading.Tasks;

namespace CQRSExample.Domain.Interfaces
{
    public interface IEventBus
    {
        void Publish<TEvent>(TEvent @event) where TEvent : IEvent;

        Task PublishAsync<TEvent>(TEvent @event) where TEvent : IEvent;
    }
}