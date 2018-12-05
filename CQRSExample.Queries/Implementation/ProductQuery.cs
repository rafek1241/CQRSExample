using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using CQRSExample.Domain.Models;
using CQRSExample.Queries.Interface;
using Dapper;

namespace CQRSExample.Queries.Implementation
{
    public class ProductQuery : Query, IProductQuery
    {
        public ProductQuery(string connection) : base(connection)
        {
        }

        public async Task<IEnumerable<Product>> GetProducts()
        {
            var sql = "select * from dbo.Products";

            using (var connection = new SqlConnection(Connection))
            {
                return await connection.QueryAsync<Product>(sql);
            }
        }

        public async Task<Product> GetProduct(long id)
        {
            var sql = "select * from dbo.Products where id=@ProductId";

            using (var connection = new SqlConnection(Connection))
            {
                var result = await connection.QueryAsync<Product>(sql, new { ProductId = id });
                return result.SingleOrDefault() ?? throw new KeyNotFoundException();
            }
        }
    }
}
