using System.Threading.Tasks;
using CQRSExample.Domain.Base;
using CQRSExample.Domain.Events;
using CQRSExample.Domain.Interfaces;

namespace CQRSExample.Events.Events.Category
{
    public class UpdateCategoryHandler : BaseHandler, IAsyncEventHandler<UpdateCategory>
    {
        public UpdateCategoryHandler(IEventBus eventBus) : base(eventBus)
        {
        }

        public Task HandleAsync(UpdateCategory @event)
        {
            throw new System.NotImplementedException();
        }
    }
}