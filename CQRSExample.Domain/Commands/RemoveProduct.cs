using CQRSExample.Domain.Interfaces;

namespace CQRSExample.Domain.Commands
{
    public class RemoveProduct : ICommand
    {
        public long ProductId { get; }

        public RemoveProduct(long productId)
        {
            ProductId = productId;
        }
    }
}
