using CQRSExample.Domain.Interfaces;
using CQRSExample.Domain.Models;

namespace CQRSExample.Domain.Events
{
    public class ValidateCategory : IEvent
    {
        public Category Category { get; }

        public ValidateCategory(Category category)
        {
            Category = category;
        }
    }

    public class InsertCategory : IEvent
    {
        public Category Category { get; }

        public InsertCategory(Category category)
        {
            Category = category;
        }
    }

    public class UpdateCategory : IEvent
    {
        public Category Category { get; }

        public UpdateCategory(Category category)
        {
            Category = category;
        }
    }

    public class RemoveCategory : IEvent
    {
        public long Id { get; }

        public RemoveCategory(long id)
        {
            Id = id;
        }
    }
}
