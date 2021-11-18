﻿// <auto-generated />
using Database.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Database.Migrations
{
    [DbContext(typeof(ShopContext))]
    partial class ShopContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.12")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Database.Entities.Category", b =>
                {
                    b.Property<int>("CategoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CategoryName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CategoryId");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            CategoryId = 1,
                            CategoryName = "Beverages",
                            Description = "Soft drinks, coffees, teas, beers, and ales"
                        },
                        new
                        {
                            CategoryId = 2,
                            CategoryName = "Condiments",
                            Description = "Sweet and savory sauces, relishes, spreads, and seasonings"
                        },
                        new
                        {
                            CategoryId = 3,
                            CategoryName = "Confections",
                            Description = "Desserts, candies, and sweet breads"
                        },
                        new
                        {
                            CategoryId = 4,
                            CategoryName = "Dairy Products",
                            Description = "Cheeses"
                        },
                        new
                        {
                            CategoryId = 5,
                            CategoryName = "Grains/Cereals",
                            Description = "Breads, crackers, pasta, and cereal"
                        });
                });

            modelBuilder.Entity("Database.Entities.Product", b =>
                {
                    b.Property<int>("ProductId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("ProductName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("SupplierId")
                        .HasColumnType("int");

                    b.HasKey("ProductId");

                    b.HasIndex("CategoryId");

                    b.HasIndex("SupplierId");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            ProductId = 1,
                            CategoryId = 1,
                            Price = 18.00m,
                            ProductName = "Chais",
                            SupplierId = 1
                        },
                        new
                        {
                            ProductId = 2,
                            CategoryId = 1,
                            Price = 19.00m,
                            ProductName = "Chang",
                            SupplierId = 1
                        },
                        new
                        {
                            ProductId = 3,
                            CategoryId = 2,
                            Price = 10.00m,
                            ProductName = "Aniseed ",
                            SupplierId = 1
                        },
                        new
                        {
                            ProductId = 4,
                            CategoryId = 2,
                            Price = 22.00m,
                            ProductName = "Chef Anton’s Cajun Seasoning",
                            SupplierId = 2
                        },
                        new
                        {
                            ProductId = 5,
                            CategoryId = 2,
                            Price = 21.35m,
                            ProductName = "Chef Anton’s Gumbo Mix",
                            SupplierId = 2
                        });
                });

            modelBuilder.Entity("Database.Entities.Supplier", b =>
                {
                    b.Property<int>("SupplierId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("City")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Country")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SupplierName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("SupplierId");

                    b.ToTable("Suppliers");

                    b.HasData(
                        new
                        {
                            SupplierId = 1,
                            City = "London",
                            Country = "UK",
                            SupplierName = "Exotic Liquid"
                        },
                        new
                        {
                            SupplierId = 2,
                            City = "New Orleans",
                            Country = "USA",
                            SupplierName = "New Orleans Cajun Delights"
                        },
                        new
                        {
                            SupplierId = 3,
                            City = "Ann Arbor",
                            Country = "USA",
                            SupplierName = "Grandma Kelly’s Homestead"
                        },
                        new
                        {
                            SupplierId = 4,
                            City = "Tokyo",
                            Country = "Japan",
                            SupplierName = "Tokyo Traders"
                        },
                        new
                        {
                            SupplierId = 5,
                            City = "Oviedo",
                            Country = "Spain",
                            SupplierName = "Cooperativa de Quesos ‘Las Cabras’"
                        });
                });

            modelBuilder.Entity("Database.Entities.Product", b =>
                {
                    b.HasOne("Database.Entities.Category", "Category")
                        .WithMany()
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Database.Entities.Supplier", "Supplier")
                        .WithMany()
                        .HasForeignKey("SupplierId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");

                    b.Navigation("Supplier");
                });
#pragma warning restore 612, 618
        }
    }
}