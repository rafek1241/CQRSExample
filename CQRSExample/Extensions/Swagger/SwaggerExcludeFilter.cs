using System;
using System.Linq;
using System.Reflection;
using CQRSExample.Domain.Extensions.Swagger;
using Swashbuckle.Swagger;

namespace CQRSExample.Extensions.Swagger
{
    public class SwaggerExcludeFilter : ISchemaFilter
    {
        #region ISchemaFilter Members

        public void Apply(Schema schema, SchemaRegistry schemaRegistry, Type type)
        {
            if (schema.properties == null || type == null)
                return;

            var excludedProperties = type.GetProperties()
                .Where(t =>
                    t.GetCustomAttribute<SwaggerExcludeAttribute>()
                    != null);

            foreach (var excludedProperty in excludedProperties)
            {
                if (!string.IsNullOrWhiteSpace(schema.properties.Keys.FirstOrDefault(x =>
                    string.Equals(x, excludedProperty.Name, StringComparison.CurrentCultureIgnoreCase))))
                    schema.properties.Remove(excludedProperty.Name);
            }
        }

        #endregion
    }
}
