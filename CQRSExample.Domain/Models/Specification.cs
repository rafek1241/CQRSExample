using System.Collections.Generic;
using CQRSExample.Domain.Extensions.Swagger;

namespace CQRSExample.Domain.Models
{
    public class Specification : Entity
    {
        public string Name { get; set; }

        public long CategoryId { get; set; }

        [SwaggerExclude] public virtual ICollection<ProductSpecification> ProductSpecification { get; set; }

        [SwaggerExclude] public virtual Category Category { get; set; }
    }
}