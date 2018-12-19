using System.Threading.Tasks;
using CQRSExample.Domain.Base;
using CQRSExample.Domain.Events;
using CQRSExample.Domain.Interfaces;
using FluentValidation;

namespace CQRSExample.Events.Events.Category
{
    public class ValidateCategoryHandler : BaseHandler, IAsyncEventHandler<ValidateCategory>
    {
        private IValidator<Domain.Models.Category> _categoryValidator;

        public ValidateCategoryHandler(IEventBus eventBus, IValidator<Domain.Models.Category> categoryValidator) : base(eventBus)
        {
            _categoryValidator = categoryValidator;
        }

        public async Task HandleAsync(ValidateCategory @event)
        {
            await _categoryValidator.ValidateAndThrowAsync(@event.Category);
            await _eventBus.PublishAsync(new InsertCategory(@event.Category));
        }
    }
}