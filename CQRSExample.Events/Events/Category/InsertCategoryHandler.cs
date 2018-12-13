using System.Threading.Tasks;
using CQRSExample.Domain.Base;
using CQRSExample.Domain.Events;
using CQRSExample.Domain.Interfaces;

namespace CQRSExample.Events.Events.Category
{
    public class InsertCategoryHandler : BaseHandler, IAsyncEventHandler<InsertCategory>
    {
        public InsertCategoryHandler(IEventBus eventBus) : base(eventBus)
        {
        }

        public Task HandleAsync(InsertCategory @event)
        {
            throw new System.NotImplementedException();
        }
    }
}