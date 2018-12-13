using System;
using System.Threading.Tasks;
using CQRSExample.Domain.Base;
using CQRSExample.Domain.Commands;
using CQRSExample.Domain.Interfaces;

namespace CQRSExample.Commands.Commands
{
    public class RemoveProductHandler : BaseHandler, ICommandHandler<RemoveProduct>, IAsyncCommandHandler<RemoveProduct>
    {
        public RemoveProductHandler(IEventBus eventBus) : base(eventBus)
        {
        }

        public void Handle(RemoveProduct command)
        {
            throw new NotImplementedException();
        }

        public Task HandleAsync(RemoveProduct command)
        {
            throw new NotImplementedException();
        }
    }
}