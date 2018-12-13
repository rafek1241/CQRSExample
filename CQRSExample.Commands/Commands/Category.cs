using System;
using System.Threading.Tasks;
using CQRSExample.Domain.Base;
using CQRSExample.Domain.Commands;
using CQRSExample.Domain.Interfaces;

namespace CQRSExample.Commands.Commands
{
    public class CreateCategoryHandler : BaseHandler, IAsyncCommandHandler<CreateCategory>
    {
        public CreateCategoryHandler(IEventBus eventBus) : base(eventBus)
        {
        }

        public Task HandleAsync(CreateCategory command)
        {
            throw new NotImplementedException();
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