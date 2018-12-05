using System.Collections.Generic;

namespace CQRSExample.Domain.Models
{
    public class Specification : Entity
    {
        public string Name { get; set; }

        public long CategoryId { get; set; }

        public virtual ICollection<ProductSpecification> ProductSpecification { get; set; }

        public virtual Category Category { get; set; }

    }
}