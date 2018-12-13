using System.Threading.Tasks;
using CQRSExample.Domain.Base;
using CQRSExample.Domain.Commands;
using CQRSExample.Domain.Events;
using CQRSExample.Domain.Interfaces;

namespace CQRSExample.Commands.Commands
{
    public class CreateProductHandler : BaseHandler, ICommandHandler<CreateProduct>, IAsyncCommandHandler<CreateProduct>
    {
        public CreateProductHandler(IEventBus eventBus) : base(eventBus)
        {
        }

        public void Handle(CreateProduct command)
        {
            _eventBus.PublishAsync(new InsertProduct(command.Product));
        }

        public async Task HandleAsync(CreateProduct command)
        {
            await _eventBus.PublishAsync(new InsertProduct(command.Product));
        }
    }
}