using CQRSExample.Domain.Interfaces;
using CQRSExample.Domain.Models;

namespace CQRSExample.Domain.Events.ProductEvents
{
    public class FetchedProducts : IEvent
    {

    }

    public class FetchedProduct : IEvent
    {

    }

    public class InsertProduct : IEvent
    {
        public InsertProduct(Product product)
        {
            Product = product;
        }

        public Product Product { get; }
    }

    public class SavedProduct : IEvent
    {
        public SavedProduct(long productId)
        {
            ProductId = productId;
        }

        public long ProductId { get; }
    }

    public class UpdatedProduct : IEvent
    {

    }

    public class ProductRemoved : IEvent
    {

    }
}
