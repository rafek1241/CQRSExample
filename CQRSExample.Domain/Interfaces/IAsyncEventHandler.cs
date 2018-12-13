using System.Threading.Tasks;

namespace CQRSExample.Domain.Interfaces
{
    public interface IAsyncEventHandler<TEvent> where TEvent : IEvent
    {
        Task HandleAsync(TEvent @event);
    }
}