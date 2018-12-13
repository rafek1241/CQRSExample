using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Threading.Tasks;
using CQRSExample.Domain.Models;
using CQRSExample.Queries.Interface;
using Dapper;

namespace CQRSExample.Queries.Implementation
{
    public class CategoryQuery : Query, ICategoryQuery
    {
        public CategoryQuery(string connection) : base(connection)
        {
        }

        public async Task<IEnumerable<Category>> GetCategories()
        {
            var sql = "select * from dbo.categories";

            using (var connection = new SqlConnection(Connection))
            {
                return await connection.QueryAsync<Category>(sql);
            }
        }

        public async Task<Category> GetCategory(long id)
        {
            var sql = "select * from dbo.categories where Id = @CategoryId";

            using (var conn = new SqlConnection(Connection))
            {
                return await conn.QuerySingleOrDefaultAsync<Category>(sql, new {CategoryId = id});
            }
        }

        public async Task<Category> GetCategory(Guid guid)
        {
            var sql = "select * from dbo.categories where Guid = @CategoryId";

            using (var conn = new SqlConnection(Connection))
            {
                return await conn.QuerySingleOrDefaultAsync<Category>(sql, new {CategoryId = guid});
            }
        }
    }
}