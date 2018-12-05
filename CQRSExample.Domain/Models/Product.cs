using System.Collections.Generic;
using CQRSExample.Domain.Extensions.Swagger;

namespace CQRSExample.Domain.Models
{
    public class Product : Entity
    {
        public string Name { get; set; }

        public decimal Price { get; set; }

        public long CategoryId { get; set; }

        [SwaggerExclude]
        public virtual Category Category { get; set; }

        [SwaggerExclude]
        public virtual ICollection<ProductSpecification> ProductSpecifications { get; set; }
    }
}
