using CQRSExample.Domain.Interfaces;
using CQRSExample.Domain.Models;

namespace CQRSExample.Domain.Events
{
    public class ValidateCategory : IEvent
    {
        public ValidateCategory(Category category)
        {
            Category = category;
        }

        public Category Category { get; }
    }

    public class InsertCategory : IEvent
    {
        public InsertCategory(Category category)
        {
            Category = category;
        }

        public Category Category { get; }
    }

    public class UpdateCategory : IEvent
    {
        public UpdateCategory(Category category)
        {
            Category = category;
        }

        public Category Category { get; }
    }

    public class RemoveCategory : IEvent
    {
        public RemoveCategory(long id)
        {
            Id = id;
        }

        public long Id { get; }
    }
}