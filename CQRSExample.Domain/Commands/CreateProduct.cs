using CQRSExample.Domain.Interfaces;
using CQRSExample.Domain.Models;

namespace CQRSExample.Domain.Commands
{
    public class CreateProduct : ICommand
    {
        public Product Product { get; }

        public CreateProduct(Product product)
        {
            Product = product;
        }
    }
}
