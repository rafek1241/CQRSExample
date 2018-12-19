using System.Threading.Tasks;
using CQRSExample.Domain.Base;
using CQRSExample.Domain.Events;
using CQRSExample.Domain.Interfaces;

namespace CQRSExample.Events.Events.Category
{
    public class ValidateCategoryHandler : BaseHandler, IAsyncEventHandler<ValidateCategory>
    {
        public ValidateCategoryHandler(IEventBus eventBus) : base(eventBus)
        {
        }

        public async Task HandleAsync(ValidateCategory @event)
        {
            Validate(@event.Category);
            await _eventBus.PublishAsync(new InsertCategory(@event.Category));
        }

        private void Validate(Domain.Models.Category eventCategory)
        {
            //There will be validation of category before insert to the database.
        }
    }
}