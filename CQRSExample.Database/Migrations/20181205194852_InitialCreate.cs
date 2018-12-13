using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CQRSExample.Database.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                "Categories",
                table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy",
                            SqlServerValueGenerationStrategy.IdentityColumn),
                    Guid = table.Column<Guid>(nullable: false),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table => { table.PrimaryKey("PK_Categories", x => x.Id); });

            migrationBuilder.CreateTable(
                "Products",
                table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy",
                            SqlServerValueGenerationStrategy.IdentityColumn),
                    Guid = table.Column<Guid>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    Price = table.Column<decimal>(nullable: false),
                    CategoryId = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                    table.ForeignKey(
                        "FK_Products_Categories_CategoryId",
                        x => x.CategoryId,
                        "Categories",
                        "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                "Specifications",
                table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy",
                            SqlServerValueGenerationStrategy.IdentityColumn),
                    Guid = table.Column<Guid>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    CategoryId = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Specifications", x => x.Id);
                    table.ForeignKey(
                        "FK_Specifications_Categories_CategoryId",
                        x => x.CategoryId,
                        "Categories",
                        "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                "ProductSpecifications",
                table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy",
                            SqlServerValueGenerationStrategy.IdentityColumn),
                    Guid = table.Column<Guid>(nullable: false),
                    ProductId = table.Column<long>(nullable: false),
                    SpecificationId = table.Column<long>(nullable: false),
                    ValueAsJson = table.Column<string>(nullable: true),
                    TypeOfSerializedJson = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductSpecifications", x => x.Id);
                    table.ForeignKey(
                        "FK_ProductSpecifications_Products_ProductId",
                        x => x.ProductId,
                        "Products",
                        "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        "FK_ProductSpecifications_Specifications_SpecificationId",
                        x => x.SpecificationId,
                        "Specifications",
                        "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateIndex(
                "IX_Products_CategoryId",
                "Products",
                "CategoryId");

            migrationBuilder.CreateIndex(
                "IX_ProductSpecifications_ProductId",
                "ProductSpecifications",
                "ProductId");

            migrationBuilder.CreateIndex(
                "IX_ProductSpecifications_SpecificationId",
                "ProductSpecifications",
                "SpecificationId");

            migrationBuilder.CreateIndex(
                "IX_Specifications_CategoryId",
                "Specifications",
                "CategoryId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                "ProductSpecifications");

            migrationBuilder.DropTable(
                "Products");

            migrationBuilder.DropTable(
                "Specifications");

            migrationBuilder.DropTable(
                "Categories");
        }
    }
}