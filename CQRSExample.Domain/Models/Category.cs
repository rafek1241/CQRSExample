using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CQRSExample.Domain.Models
{
    public class Category : Entity
    {
        public string Name { get; set; }

        public virtual ICollection<Product> Products { get; set; }

        public virtual ICollection<Specification> Specifications { get; set; }
    }
}
