using AtuliaRestauruntv2.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace AtuliaRestauruntv2.Data;

public class AtuliaRestauruntv2Context : IdentityDbContext<IdentityUser>
{
    public AtuliaRestauruntv2Context(DbContextOptions<AtuliaRestauruntv2Context> options)
        : base(options)
    {
    }

    public DbSet<Product> Products { get; set; }
    public DbSet<Category> Categories { get; set; }
    public DbSet<Order> Orders { get; set; }
    public DbSet<OrderItem> OrderItems { get; set; }
    public DbSet<Ingredient> Ingredients { get; set; }
    public DbSet<ProductIngredient> ProductIngredients { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        // Define composite key and relationships for ProductIngredient
        modelBuilder.Entity<ProductIngredient>()
            .HasKey(pi => new { pi.ProductId, pi.IngredientId });

        modelBuilder.Entity<ProductIngredient>()
            .HasOne(pi => pi.Product)
            .WithMany(p => p.ProductIngredients)
            .HasForeignKey(pi => pi.ProductId);

        modelBuilder.Entity<ProductIngredient>()
            .HasOne(pi => pi.Ingredient)
            .WithMany(i => i.ProductIngredients)
            .HasForeignKey(pi => pi.IngredientId);

        //Seed Data
        modelBuilder.Entity<Category>().HasData(
           new Category { CategoryId = 1, Name = "Appetizer" },
           new Category { CategoryId = 2, Name = "Main" },
           new Category { CategoryId = 3, Name = "Dessert" },
           new Category { CategoryId = 4, Name = "Beverage" }
       );

        modelBuilder.Entity<Ingredient>().HasData(
         //add indian restaurant ingredients here
         new Ingredient { IngredientId = 1, Name = "Potato" },
         new Ingredient { IngredientId = 2, Name = "Chicken" },
         new Ingredient { IngredientId = 3, Name = "Fish" },
         new Ingredient { IngredientId = 4, Name = "Naan" },
         new Ingredient { IngredientId = 5, Name = "Spinach" },
         new Ingredient { IngredientId = 6, Name = "Tomato" },
         new Ingredient { IngredientId = 7, Name = "White Rice" },
         new Ingredient { IngredientId = 8, Name = "Peas" },
         new Ingredient { IngredientId = 9, Name = "Coriander" },
         new Ingredient { IngredientId = 10, Name = "Lentils" },
         new Ingredient { IngredientId = 11, Name = "Gulab Jamun" },
         new Ingredient { IngredientId = 12, Name = "Ice Cream" },
         new Ingredient { IngredientId = 13, Name = "Water" },
         new Ingredient { IngredientId = 14, Name = "Mango Lassi" },
         new Ingredient { IngredientId = 15, Name = "Coke" }


     );
       modelBuilder.Entity<Product>().HasData(
            //add indian restaurant offering here
            new Product
            {
                ProductId = 1,
                Name = "Naan",
                Description = "A fluffy bread popular in North India",
                Price = 7.99m,
                Stock = 25,
                CategoryId = 2
            },
            new Product
            {
                ProductId = 2,
                Name = "Fried Rice",
                Description = "Mild yummy rice with peas",
                Price = 10.99m,
                Stock = 40,
                CategoryId = 2
            },
            new Product
            {
                ProductId = 3,
                Name = "Aloo Fry",
                Description = "Fried Potato Curry served with Naan and Rice",
                Price = 8.50m,
                Stock = 10,
                CategoryId = 2
            },
            new Product
            {
                ProductId = 4,
                Name = "Coke",
                Description = "Chilled Fizzy Beverage",
                Price = 2.99m,
                Stock = 50,
                CategoryId = 4
            },
            new Product
            {
                ProductId = 5,
                Name = "Water",
                Description = "Beverage",
                Price = 3.99m,
                Stock = 50,
                CategoryId = 4
            },
            new Product
            {
                ProductId = 6,
                Name = "Mango Lassi",
                Description = "Cool Mango drink",
                Price = 5.00m,
                Stock = 20,
                CategoryId = 3
            },
            new Product
            {
                ProductId = 7,
                Name = "Gulab Jamun",
                Description = "Indian sweet made with milk powder",
                Price = 4.99m,
                Stock = 30,
                CategoryId = 3
            },
            new Product
            {
                ProductId = 8,
                Name = "Ice Cream",
                Description = "Frozen dessert",
                Price = 2.99m,
                Stock = 60,
                CategoryId = 3
            },
            new Product
            {
                ProductId = 9,
                Name = "Butter Chicken",
                Description = "Chiken flavoured lightly in spices and served with rice",
                Price = 20.99m,
                Stock = 30,
                CategoryId = 2
            },
            new Product
            {
                ProductId = 10,
                Name = "Fish Madrasi",
                Description = "Fish curry served with rice",
                Price = 19.99m,
                Stock = 20,
                CategoryId = 2
            },
            new Product
            {
                ProductId = 11,
                Name = "Palak Fritters",
                Description = "Spinach deepfried coated in batter",
                Price = 6.99m,
                Stock = 30,
                CategoryId = 1
            },
            new Product
            {
                ProductId = 12,
                Name = "Chicken Lollipops",
                Description = "Chicken lightly coated in spices and fried",
                Price = 8.9m,
                Stock = 30,
                CategoryId = 1
            },
            new Product
            {
                ProductId = 13,
                Name = "Daal Fry",
                Description = "Lentil cooked with tomato and garnished with coriander.",
                Price = 7.99m,
                Stock = 20,
                CategoryId = 2

            }
            );

        modelBuilder.Entity<ProductIngredient>().HasData(
            new { ProductId = 1, IngredientId = 4 },
            new { ProductId = 2, IngredientId = 7 },
            new { ProductId = 2, IngredientId = 8 },
            new { ProductId = 3, IngredientId = 1 },
            new { ProductId = 3, IngredientId = 4 },
            new { ProductId = 3, IngredientId = 7 },
            new { ProductId = 4, IngredientId = 15 },
            new { ProductId = 5, IngredientId = 13 },
            new { ProductId = 6, IngredientId = 14 },
            new { ProductId = 7, IngredientId = 11 },
            new { ProductId = 8, IngredientId = 12 },
            new { ProductId = 9, IngredientId = 2 },
            new { ProductId = 9, IngredientId = 7 },
            new { ProductId = 10, IngredientId = 3 },
            new { ProductId = 10, IngredientId = 7 },
            new { ProductId = 11, IngredientId = 5 },
            new { ProductId = 12, IngredientId = 2 },
            new { ProductId = 13, IngredientId = 10 },
            new { ProductId = 13, IngredientId = 9 },
            new { ProductId = 13, IngredientId = 6 }
            );
    }
}
