using CQRSExample.Domain.Interfaces;
using CQRSExample.Domain.Models;
using System;

namespace CQRSExample.Domain.Commands
{
    public class CreateCategory : ICommand
    {
        private readonly Category _category;

        public CreateCategory(Category category)
        {
            category.Guid = Guid.NewGuid();

            _category = category;
        }
    }

    public class UpdateCategory : ICommand
    {
        private readonly long _id;
        private readonly Category _category;

        public UpdateCategory(long id, Category category)
        {
            _id = id;
            _category = category;
        }
    }

    public class RemoveCategory : ICommand
    {
        private readonly Category _category;

        public RemoveCategory(Category category)
        {
            _category = category;
        }
    }
}
