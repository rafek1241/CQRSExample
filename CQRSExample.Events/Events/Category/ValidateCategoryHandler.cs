using System.Threading.Tasks;
using CQRSExample.Domain.Base;
using CQRSExample.Domain.Events;
using CQRSExample.Domain.Interfaces;

namespace CQRSExample.Events.Events.Category
{
    public class ValidateCategoryHandler : BaseHandler, IAsyncEventHandler<InsertCategory>
    {
        public ValidateCategoryHandler(IEventBus eventBus) : base(eventBus)
        {
        }

        public Task HandleAsync(InsertCategory @event)
        {
            throw new System.NotImplementedException();
        }
    }
}