using System;
using CQRSExample.Domain.Interfaces;
using CQRSExample.Domain.Models;

namespace CQRSExample.Domain.Commands
{
    public class CreateProduct : ICommand
    {
        public CreateProduct(Product product)
        {
            Product = product;

            Product.Guid = Guid.NewGuid();
        }

        public Product Product { get; }
    }
}