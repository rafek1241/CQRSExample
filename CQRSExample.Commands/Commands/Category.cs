using System;
using System.Threading.Tasks;
using CQRSExample.Domain.Base;
using CQRSExample.Domain.Commands;
using CQRSExample.Domain.Events;
using CQRSExample.Domain.Interfaces;
using RemoveCategory = CQRSExample.Domain.Commands.RemoveCategory;
using UpdateCategory = CQRSExample.Domain.Commands.UpdateCategory;

namespace CQRSExample.Commands.Commands
{
    public class CreateCategoryHandler : BaseHandler, IAsyncCommandHandler<CreateCategory>
    {
        public CreateCategoryHandler(IEventBus eventBus) : base(eventBus)
        {
        }

        public async Task HandleAsync(CreateCategory command)
        {
            await _eventBus.PublishAsync(new ValidateCategory(command.Category));
        }
    }

    public class UpdateCategoryHandler : BaseHandler, IAsyncCommandHandler<UpdateCategory>
    {
        public UpdateCategoryHandler(IEventBus eventBus) : base(eventBus)
        {
        }

        public Task HandleAsync(UpdateCategory command)
        {
            throw new NotImplementedException();
        }
    }

    public class RemoveCategoryHandler : BaseHandler, IAsyncCommandHandler<RemoveCategory>
    {
        public RemoveCategoryHandler(IEventBus eventBus) : base(eventBus)
        {
        }

        public Task HandleAsync(RemoveCategory command)
        {
            throw new NotImplementedException();
        }
    }
}