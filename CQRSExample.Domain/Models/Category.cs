using System.Collections.Generic;
using CQRSExample.Domain.Extensions.Swagger;

namespace CQRSExample.Domain.Models
{
    public class Category : Entity
    {
        public string Name { get; set; }

        [SwaggerExclude]
        public virtual ICollection<Product> Products { get; set; }

        [SwaggerExclude]
        public virtual ICollection<Specification> Specifications { get; set; }
    }
}
