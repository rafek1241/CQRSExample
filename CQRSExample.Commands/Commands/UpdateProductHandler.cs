using System;
using System.Threading.Tasks;
using CQRSExample.Domain.Base;
using CQRSExample.Domain.Commands;
using CQRSExample.Domain.Interfaces;

namespace CQRSExample.Commands.Commands
{
    public class UpdateProductHandler : BaseHandler, ICommandHandler<UpdateProduct>, IAsyncCommandHandler<UpdateProduct>
    {
        public UpdateProductHandler(IEventBus eventBus) : base(eventBus)
        {
        }

        public void Handle(UpdateProduct command)
        {
            throw new NotImplementedException();
        }

        public Task HandleAsync(UpdateProduct command)
        {
            throw new NotImplementedException();
        }
    }
}