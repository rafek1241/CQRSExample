using System.Collections.Generic;
using System.Threading.Tasks;
using CQRSExample.Domain.Models;

namespace CQRSExample.Queries.Interface
{
    public interface IProductQuery : IQuery
    {
        Task<IEnumerable<Product>> GetProducts();

        Task<Product> GetProduct(long id);
    }
}
