using System.Collections.Generic;

namespace CQRSExample.Domain.Models
{
    public class Product : Entity
    {
        public string Name { get; set; }

        public decimal Price { get; set; }

        public virtual Category Category { get; set; }

        public virtual ICollection<ProductSpecification> Specifications { get; set; }
    }
}
