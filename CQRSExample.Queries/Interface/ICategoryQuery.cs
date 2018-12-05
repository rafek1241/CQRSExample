using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CQRSExample.Domain.Models;

namespace CQRSExample.Queries.Interface
{
    public interface ICategoryQuery
    {
        Task<IEnumerable<Category>> GetCategories();

        Task<Category> GetCategory(long id);

        Task<Category> GetCategory(Guid guid);
    }
}
