namespace CQRSExample.Domain.Interfaces
{
    public interface IEventHandler<TEvent> where TEvent : IEvent
    {
        void Handle(TEvent @event);
    }
}
