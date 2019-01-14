using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CQRSExample.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace CQRSExample.Database.Extensions
{
    public static class ContextExtensions
    {
        public static async Task<EntityEntry<T>> RemoveByIdAsync<T>(this DbSet<T> entitySet, long id) where T : Entity
        {
            var entity = await entitySet.SingleAsync(w => w.Id == id);
            return entitySet.Remove(entity);
        }

        public static EntityEntry<T> RemoveById<T>(this DbSet<T> entitySet, long id) where T : Entity
        {
            var entity = entitySet.Single(w => w.Id == id);
            return entitySet.Remove(entity);
        }
    }
}
