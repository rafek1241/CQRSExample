using System;
using System.Threading.Tasks;
using CQRSExample.Domain.Commands;
using CQRSExample.Domain.Interfaces;

namespace CQRSExample.Commands.Commands
{
    public class CreateCategoryHandler : AsyncCommandHandler<CreateCategory>
    {
        public CreateCategoryHandler(IEventBus eventBus) : base(eventBus)
        {
        }

        public override Task HandleAsync(CreateCategory command)
        {
            throw new NotImplementedException();
        }
    }

    public class UpdateCategoryHandler : AsyncCommandHandler<UpdateCategory>
    {
        public UpdateCategoryHandler(IEventBus eventBus) : base(eventBus)
        {
        }

        public override Task HandleAsync(UpdateCategory command)
        {
            throw new NotImplementedException();
        }
    }

    public class RemoveCategoryHandler : AsyncCommandHandler<RemoveCategory>
    {
        public RemoveCategoryHandler(IEventBus eventBus) : base(eventBus)
        {
        }

        public override Task HandleAsync(RemoveCategory command)
        {
            throw new NotImplementedException();
        }
    }
}