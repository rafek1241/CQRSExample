﻿// <auto-generated />
using System;
using CQRSExample.Database;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace CQRSExample.Database.Migrations
{
    [DbContext(typeof(CqrsExampleContext))]
    [Migration("20181205194852_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.4-rtm-31024")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("CQRSExample.Domain.Models.Category", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<Guid>("Guid");

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("Categories");
                });

            modelBuilder.Entity("CQRSExample.Domain.Models.Product", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<long>("CategoryId");

                    b.Property<Guid>("Guid");

                    b.Property<string>("Name");

                    b.Property<decimal>("Price");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("CQRSExample.Domain.Models.ProductSpecification", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<Guid>("Guid");

                    b.Property<long>("ProductId");

                    b.Property<long>("SpecificationId");

                    b.Property<string>("TypeOfSerializedJson");

                    b.Property<string>("ValueAsJson");

                    b.HasKey("Id");

                    b.HasIndex("ProductId");

                    b.HasIndex("SpecificationId");

                    b.ToTable("ProductSpecifications");
                });

            modelBuilder.Entity("CQRSExample.Domain.Models.Specification", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<long>("CategoryId");

                    b.Property<Guid>("Guid");

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.ToTable("Specifications");
                });

            modelBuilder.Entity("CQRSExample.Domain.Models.Product", b =>
                {
                    b.HasOne("CQRSExample.Domain.Models.Category", "Category")
                        .WithMany("Products")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("CQRSExample.Domain.Models.ProductSpecification", b =>
                {
                    b.HasOne("CQRSExample.Domain.Models.Product", "Product")
                        .WithMany("Specifications")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("CQRSExample.Domain.Models.Specification", "Specification")
                        .WithMany("ProductSpecification")
                        .HasForeignKey("SpecificationId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("CQRSExample.Domain.Models.Specification", b =>
                {
                    b.HasOne("CQRSExample.Domain.Models.Category", "Category")
                        .WithMany("Specifications")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}