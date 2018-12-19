using System.Threading.Tasks;
using CQRSExample.Database;
using CQRSExample.Domain.Base;
using CQRSExample.Domain.Events;
using CQRSExample.Domain.Interfaces;

namespace CQRSExample.Events.Events.Category
{
    public class InsertCategoryHandler : BaseHandler, IAsyncEventHandler<InsertCategory>
    {
        private CqrsExampleContext _context;

        public InsertCategoryHandler(IEventBus eventBus, CqrsExampleContext context) : base(eventBus)
        {
            _context = context;
        }

        public async Task HandleAsync(InsertCategory @event)
        {
            _context.Categories.Add(@event.Category);
            await _context.SaveChangesAsync();
        }
    }
}