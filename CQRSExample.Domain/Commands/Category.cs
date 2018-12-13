using System;
using CQRSExample.Domain.Interfaces;
using CQRSExample.Domain.Models;

namespace CQRSExample.Domain.Commands
{
    public class CreateCategory : ICommand
    {
        public CreateCategory(Category category)
        {
            category.Guid = Guid.NewGuid();

            Category = category;
        }

        public Category Category { get; set; }
    }

    public class UpdateCategory : ICommand
    {
        public UpdateCategory(Category category) : this(0, category)
        {
        }

        public UpdateCategory(long id, Category category)
        {
            Id = id;
            Category = category;
        }

        public long Id { get; set; }
        public Category Category { get; set; }
    }

    public class RemoveCategory : ICommand
    {
        public RemoveCategory(long categoryId)
        {
            CategoryId = categoryId;
        }

        public long CategoryId { get; set; }
    }
}