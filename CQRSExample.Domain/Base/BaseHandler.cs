using CQRSExample.Domain.Interfaces;

namespace CQRSExample.Domain.Base
{
    public abstract class BaseHandler 
    {
        protected readonly IEventBus _eventBus;

        protected BaseHandler(IEventBus eventBus)
        {
            _eventBus = eventBus;
        }
    }
}