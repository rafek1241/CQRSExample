using System;
using System.Threading.Tasks;
using CQRSExample.Domain.Commands;
using CQRSExample.Domain.Interfaces;

namespace CQRSExample.Commands.Commands
{
    public class RemoveProductHandler : CommandHandler<RemoveProduct>
    {
        public RemoveProductHandler(IEventBus eventBus) : base(eventBus)
        {
        }

        public override void Handle(RemoveProduct command)
        {
            throw new NotImplementedException();
        }

        public override Task HandleAsync(RemoveProduct command)
        {
            throw new NotImplementedException();
        }
    }
}