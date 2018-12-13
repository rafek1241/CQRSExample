using CQRSExample.Domain.Interfaces;
using CQRSExample.Domain.Models;
using System;

namespace CQRSExample.Domain.Commands
{
    public class CreateCategory : ICommand
    {
        public Category Category { get; set; }

        public CreateCategory(Category category)
        {
            category.Guid = Guid.NewGuid();

            Category = category;
        }
    }

    public class UpdateCategory : ICommand
    {
        public long Id { get; set; }
        public Category Category { get; set; }

        public UpdateCategory(Category category) : this(0, category)
        {
        }

        public UpdateCategory(long id, Category category)
        {
            Id = id;
            Category = category;
        }
    }

    public class RemoveCategory : ICommand
    {
        public long CategoryId { get; set; }

        public RemoveCategory(long categoryId)
        {
            CategoryId = categoryId;
        }
    }
}
