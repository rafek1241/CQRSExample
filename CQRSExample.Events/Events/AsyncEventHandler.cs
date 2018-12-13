using System;
using CQRSExample.Domain.Interfaces;

namespace CQRSExample.Events.Events
{
    public abstract class AsyncEventHandler<T> : EventHandler<T> where T : IEvent
    {
        protected AsyncEventHandler(IEventBus eventBus) : base(eventBus)
        {
        }

        public sealed override void Handle(T @event)
        {
            throw new NotSupportedException();
        }
    }
}