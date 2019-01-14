using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CQRSExample.Database;
using CQRSExample.Database.Extensions;
using CQRSExample.Domain.Base;
using CQRSExample.Domain.Events;
using CQRSExample.Domain.Interfaces;

namespace CQRSExample.Events.Events.Category
{
    public class RemoveCategoryHandler : BaseHandler, IAsyncEventHandler<RemoveCategory>
    {
        private readonly CqrsExampleContext _context;

        public RemoveCategoryHandler(IEventBus eventBus, CqrsExampleContext context) : base(eventBus)
        {
            _context = context;
        }

        public async Task HandleAsync(RemoveCategory @event)
        {
            await _context.Categories.RemoveByIdAsync(@event.Id);
            await _context.SaveChangesAsync();
        }
    }
}
