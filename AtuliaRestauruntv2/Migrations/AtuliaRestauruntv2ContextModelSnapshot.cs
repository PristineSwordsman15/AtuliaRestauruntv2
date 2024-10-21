﻿// <auto-generated />
using System;
using AtuliaRestauruntv2.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace AtuliaRestauruntv2.Migrations
{
    [DbContext(typeof(AtuliaRestauruntv2Context))]
    partial class AtuliaRestauruntv2ContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("AtuliaRestauruntv2.Models.Category", b =>
                {
                    b.Property<int>("CategoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CategoryId"));

                    b.Property<string>("CategoryName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("CategoryId");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            CategoryId = 1,
                            CategoryName = "Appetizer"
                        },
                        new
                        {
                            CategoryId = 2,
                            CategoryName = "Main"
                        },
                        new
                        {
                            CategoryId = 3,
                            CategoryName = "Dessert"
                        },
                        new
                        {
                            CategoryId = 4,
                            CategoryName = "Beverage"
                        });
                });

            modelBuilder.Entity("AtuliaRestauruntv2.Models.Ingredient", b =>
                {
                    b.Property<int>("IngredientId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IngredientId"));

                    b.Property<string>("IngredientName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("IngredientId");

                    b.ToTable("Ingredients");

                    b.HasData(
                        new
                        {
                            IngredientId = 1,
                            IngredientName = "Potato"
                        },
                        new
                        {
                            IngredientId = 2,
                            IngredientName = "Chicken"
                        },
                        new
                        {
                            IngredientId = 3,
                            IngredientName = "Fish"
                        },
                        new
                        {
                            IngredientId = 4,
                            IngredientName = "Naan"
                        },
                        new
                        {
                            IngredientId = 5,
                            IngredientName = "Spinach"
                        },
                        new
                        {
                            IngredientId = 6,
                            IngredientName = "Tomato"
                        },
                        new
                        {
                            IngredientId = 7,
                            IngredientName = "White Rice"
                        },
                        new
                        {
                            IngredientId = 8,
                            IngredientName = "Peas"
                        },
                        new
                        {
                            IngredientId = 9,
                            IngredientName = "Coriander"
                        },
                        new
                        {
                            IngredientId = 10,
                            IngredientName = "Lentils"
                        },
                        new
                        {
                            IngredientId = 11,
                            IngredientName = "Gulab Jamun"
                        },
                        new
                        {
                            IngredientId = 12,
                            IngredientName = "Ice Cream"
                        },
                        new
                        {
                            IngredientId = 13,
                            IngredientName = "Water"
                        },
                        new
                        {
                            IngredientId = 14,
                            IngredientName = "Mango Lassi"
                        },
                        new
                        {
                            IngredientId = 15,
                            IngredientName = "Coke"
                        });
                });

            modelBuilder.Entity("AtuliaRestauruntv2.Models.Order", b =>
                {
                    b.Property<int>("OrderId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("OrderId"));

                    b.Property<DateTime>("OrderDate")
                        .HasColumnType("datetime2");

                    b.Property<decimal>("TotalAmount")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("OrderId");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("AtuliaRestauruntv2.Models.Product", b =>
                {
                    b.Property<int>("ProductId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ProductId"));

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .HasMaxLength(2000)
                        .HasColumnType("nvarchar(2000)");

                    b.Property<string>("ImageUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("ProductName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<int>("Stock")
                        .HasColumnType("int");

                    b.HasKey("ProductId");

                    b.HasIndex("CategoryId");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            ProductId = 1,
                            CategoryId = 2,
                            Description = "A fluffy bread popular in North India",
                            ImageUrl = "https://via.placeholder.com/150",
                            Price = 7.99m,
                            ProductName = "Naan",
                            Stock = 25
                        },
                        new
                        {
                            ProductId = 2,
                            CategoryId = 2,
                            Description = "Mild yummy rice with peas",
                            ImageUrl = "https://via.placeholder.com/150",
                            Price = 10.99m,
                            ProductName = "Fried Rice",
                            Stock = 40
                        },
                        new
                        {
                            ProductId = 3,
                            CategoryId = 2,
                            Description = "Fried Potato Curry served with Naan and Rice",
                            ImageUrl = "https://via.placeholder.com/150",
                            Price = 8.50m,
                            ProductName = "Aloo Fry",
                            Stock = 10
                        },
                        new
                        {
                            ProductId = 4,
                            CategoryId = 4,
                            Description = "Chilled Fizzy Beverage",
                            ImageUrl = "https://via.placeholder.com/150",
                            Price = 2.99m,
                            ProductName = "Coke",
                            Stock = 50
                        },
                        new
                        {
                            ProductId = 5,
                            CategoryId = 4,
                            Description = "Beverage",
                            ImageUrl = "https://via.placeholder.com/150",
                            Price = 3.99m,
                            ProductName = "Water",
                            Stock = 50
                        },
                        new
                        {
                            ProductId = 6,
                            CategoryId = 3,
                            Description = "Cool Mango drink",
                            ImageUrl = "https://via.placeholder.com/150",
                            Price = 5.00m,
                            ProductName = "Mango Lassi",
                            Stock = 20
                        },
                        new
                        {
                            ProductId = 7,
                            CategoryId = 3,
                            Description = "Indian sweet made with milk powder",
                            ImageUrl = "https://via.placeholder.com/150",
                            Price = 4.99m,
                            ProductName = "Gulab Jamun",
                            Stock = 30
                        },
                        new
                        {
                            ProductId = 8,
                            CategoryId = 3,
                            Description = "Frozen dessert",
                            ImageUrl = "https://via.placeholder.com/150",
                            Price = 2.99m,
                            ProductName = "Ice Cream",
                            Stock = 60
                        },
                        new
                        {
                            ProductId = 9,
                            CategoryId = 2,
                            Description = "Chiken flavoured lightly in spices and served with rice",
                            ImageUrl = "https://via.placeholder.com/150",
                            Price = 20.99m,
                            ProductName = "Butter Chicken",
                            Stock = 30
                        },
                        new
                        {
                            ProductId = 10,
                            CategoryId = 2,
                            Description = "Fish curry served with rice",
                            ImageUrl = "https://via.placeholder.com/150",
                            Price = 19.99m,
                            ProductName = "Fish Madrasi",
                            Stock = 20
                        },
                        new
                        {
                            ProductId = 11,
                            CategoryId = 1,
                            Description = "Spinach deepfried coated in batter",
                            ImageUrl = "https://via.placeholder.com/150",
                            Price = 6.99m,
                            ProductName = "Palak Fritters",
                            Stock = 30
                        },
                        new
                        {
                            ProductId = 12,
                            CategoryId = 1,
                            Description = "Chicken lightly coated in spices and fried",
                            ImageUrl = "https://via.placeholder.com/150",
                            Price = 8.9m,
                            ProductName = "Chicken Lollipops",
                            Stock = 30
                        },
                        new
                        {
                            ProductId = 13,
                            CategoryId = 2,
                            Description = "Lentil cooked with tomato and garnished with coriander.",
                            ImageUrl = "https://via.placeholder.com/150",
                            Price = 7.99m,
                            ProductName = "Daal Fry",
                            Stock = 20
                        });
                });

            modelBuilder.Entity("AtuliaRestauruntv2.Models.ProductIngredient", b =>
                {
                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.Property<int>("IngredientId")
                        .HasColumnType("int");

                    b.HasKey("ProductId", "IngredientId");

                    b.HasIndex("IngredientId");

                    b.ToTable("ProductIngredients");

                    b.HasData(
                        new
                        {
                            ProductId = 1,
                            IngredientId = 4
                        },
                        new
                        {
                            ProductId = 2,
                            IngredientId = 7
                        },
                        new
                        {
                            ProductId = 2,
                            IngredientId = 8
                        },
                        new
                        {
                            ProductId = 3,
                            IngredientId = 1
                        },
                        new
                        {
                            ProductId = 3,
                            IngredientId = 4
                        },
                        new
                        {
                            ProductId = 3,
                            IngredientId = 7
                        },
                        new
                        {
                            ProductId = 4,
                            IngredientId = 15
                        },
                        new
                        {
                            ProductId = 5,
                            IngredientId = 13
                        },
                        new
                        {
                            ProductId = 6,
                            IngredientId = 14
                        },
                        new
                        {
                            ProductId = 7,
                            IngredientId = 11
                        },
                        new
                        {
                            ProductId = 8,
                            IngredientId = 12
                        },
                        new
                        {
                            ProductId = 9,
                            IngredientId = 2
                        },
                        new
                        {
                            ProductId = 9,
                            IngredientId = 7
                        },
                        new
                        {
                            ProductId = 10,
                            IngredientId = 3
                        },
                        new
                        {
                            ProductId = 10,
                            IngredientId = 7
                        },
                        new
                        {
                            ProductId = 11,
                            IngredientId = 5
                        },
                        new
                        {
                            ProductId = 12,
                            IngredientId = 2
                        },
                        new
                        {
                            ProductId = 13,
                            IngredientId = 10
                        },
                        new
                        {
                            ProductId = 13,
                            IngredientId = 9
                        },
                        new
                        {
                            ProductId = 13,
                            IngredientId = 6
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ProviderKey")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Name")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("AtuliaRestauruntv2.Models.Product", b =>
                {
                    b.HasOne("AtuliaRestauruntv2.Models.Category", "Category")
                        .WithMany("Products")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");
                });

            modelBuilder.Entity("AtuliaRestauruntv2.Models.ProductIngredient", b =>
                {
                    b.HasOne("AtuliaRestauruntv2.Models.Ingredient", "Ingredient")
                        .WithMany("ProductIngredients")
                        .HasForeignKey("IngredientId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("AtuliaRestauruntv2.Models.Product", "Product")
                        .WithMany("ProductIngredients")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Ingredient");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("AtuliaRestauruntv2.Models.Category", b =>
                {
                    b.Navigation("Products");
                });

            modelBuilder.Entity("AtuliaRestauruntv2.Models.Ingredient", b =>
                {
                    b.Navigation("ProductIngredients");
                });

            modelBuilder.Entity("AtuliaRestauruntv2.Models.Product", b =>
                {
                    b.Navigation("ProductIngredients");
                });
#pragma warning restore 612, 618
        }
    }
}
