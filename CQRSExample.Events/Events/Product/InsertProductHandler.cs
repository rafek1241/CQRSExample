using System.Threading.Tasks;
using CQRSExample.Database;
using CQRSExample.Domain.Base;
using CQRSExample.Domain.Events;
using CQRSExample.Domain.Interfaces;

namespace CQRSExample.Events.Events.Product
{
    public class InsertProductHandler : BaseHandler, IEventHandler<InsertProduct>, IAsyncEventHandler<InsertProduct>
    {
        private readonly CqrsExampleContext _context;

        public InsertProductHandler(IEventBus eventBus, CqrsExampleContext context) : base(eventBus)
        {
            _context = context;
        }

        public void Handle(InsertProduct @event)
        {
            _context.Products.Add(@event.Product);

            _context.SaveChanges();

            var savedProductEvent = new SavedProduct(@event.Product.Id);
            _eventBus.Publish(savedProductEvent);
        }

        public async Task HandleAsync(InsertProduct @event)
        {
            _context.Products.Add(@event.Product);

            await _context.SaveChangesAsync();

            var savedProductEvent = new SavedProduct(@event.Product.Id);
            await _eventBus.PublishAsync(savedProductEvent);
        }
    }
}