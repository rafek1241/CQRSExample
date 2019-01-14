using System.Threading.Tasks;
using CQRSExample.Database;
using CQRSExample.Domain.Base;
using CQRSExample.Domain.Events;
using CQRSExample.Domain.Interfaces;

namespace CQRSExample.Events.Events.Category
{
    public class UpdateCategoryHandler : BaseHandler, IAsyncEventHandler<UpdateCategory>
    {
        private readonly CqrsExampleContext _context;

        public UpdateCategoryHandler(IEventBus eventBus, CqrsExampleContext context) : base(eventBus)
        {
            _context = context;
        }

        public async Task HandleAsync(UpdateCategory @event)
        {
            _context.Categories.Update(@event.Category);
            await _context.SaveChangesAsync();
        }
    }
}