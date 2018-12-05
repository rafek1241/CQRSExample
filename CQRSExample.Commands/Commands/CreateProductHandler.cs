using System;
using System.Threading.Tasks;
using CQRSExample.Domain.Commands;
using CQRSExample.Domain.Events.ProductEvents;
using CQRSExample.Domain.Interfaces;

namespace CQRSExample.Commands.Commands
{
    public class CreateProductHandler : CommandHandler<CreateProduct>
    {
        public CreateProductHandler(IEventBus eventBus) : base(eventBus)
        {
        }

        public override void Handle(CreateProduct command)
        {
            _eventBus.PublishAsync(new InsertProduct(command.Product));
        }

        public override async Task HandleAsync(CreateProduct command)
        {
            await _eventBus.PublishAsync(new InsertProduct(command.Product));
        }
    }
}
