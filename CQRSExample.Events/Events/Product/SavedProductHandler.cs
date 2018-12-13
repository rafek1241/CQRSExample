using System.Threading.Tasks;
using CQRSExample.Domain.Base;
using CQRSExample.Domain.Events;
using CQRSExample.Domain.Interfaces;

namespace CQRSExample.Events.Events.Product
{
    public class SavedProductHandler : BaseHandler, IEventHandler<SavedProduct>, IAsyncEventHandler<SavedProduct>
    {
        public SavedProductHandler(IEventBus eventBus) : base(eventBus)
        {
        }

        public void Handle(SavedProduct @event)
        {
            //The end of sync insert event
        }

        public Task HandleAsync(SavedProduct @event)
        {
            //The end of async insert event

            return Task.CompletedTask;
        }
    }
}