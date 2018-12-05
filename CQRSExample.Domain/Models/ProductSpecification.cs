using System;

namespace CQRSExample.Domain.Models
{
    public class ProductSpecification : Entity
    {
        public long ProductId { get; set; }

        public long SpecificationId { get; set; }

        public string ValueAsJson { get; set; }

        public string TypeOfSerializedJson { get; set; }

        public virtual Product Product { get; set; }

        public virtual Specification Specification { get; set; }
    }
}
