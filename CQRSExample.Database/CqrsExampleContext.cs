using System;
using System.Collections.Generic;
using System.Configuration;
using CQRSExample.Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace CQRSExample.Database
{
    public class CqrsExampleContext : DbContext
    {
        public DbSet<Product> Products { get; set; }

        public DbSet<ProductSpecification> ProductSpecifications { get; set; }

        public DbSet<Category> Categories { get; set; }

        public DbSet<Specification> Specifications { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string writeDatabaseConnectionString;

            try
            {
                writeDatabaseConnectionString = ConfigurationManager.ConnectionStrings["writeDatabase"].ConnectionString;
            }
            catch (Exception error)
            {
                throw new KeyNotFoundException("Connection string with name \"writeDatabase\" was not found", error);
            }

            optionsBuilder.UseSqlServer(writeDatabaseConnectionString);
        }
    }
}
