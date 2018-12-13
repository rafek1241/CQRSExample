using CQRSExample.Domain.Interfaces;

namespace CQRSExample.Domain.Commands
{
    public class RemoveProduct : ICommand
    {
        public RemoveProduct(long productId)
        {
            ProductId = productId;
        }

        public long ProductId { get; }
    }
}