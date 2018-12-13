using CQRSExample.Domain.Extensions.Swagger;

namespace CQRSExample.Domain.Models
{
    public class ProductSpecification : Entity
    {
        public long ProductId { get; set; }

        public long SpecificationId { get; set; }

        public string ValueAsJson { get; set; }

        public string TypeOfSerializedJson { get; set; }

        [SwaggerExclude] public virtual Product Product { get; set; }

        [SwaggerExclude] public virtual Specification Specification { get; set; }
    }
}