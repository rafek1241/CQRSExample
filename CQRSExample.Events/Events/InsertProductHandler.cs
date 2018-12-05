using System;
using System.Data;
using System.Data.Common;
using System.Threading.Tasks;
using CQRSExample.Database;
using CQRSExample.Domain.Events.ProductEvents;
using CQRSExample.Domain.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace CQRSExample.Events.Events
{
    public class InsertProductHandler : EventHandler<InsertProduct>
    {
        private readonly CqrsExampleContext _context;

        public InsertProductHandler(IEventBus eventBus, CqrsExampleContext context) : base(eventBus)
        {
            _context = context;
        }

        public override void Handle(InsertProduct @event)
        {
            _context.Products.Add(@event.Product);

            _context.SaveChanges();

            var savedProductEvent = new SavedProduct(@event.Product.Id);
            _eventBus.Publish(savedProductEvent);
        }

        public override async Task HandleAsync(InsertProduct @event)
        {
            _context.Products.Add(@event.Product);

            await _context.SaveChangesAsync();

            var savedProductEvent = new SavedProduct(@event.Product.Id);
            await _eventBus.PublishAsync(savedProductEvent);
        }
    }
}
