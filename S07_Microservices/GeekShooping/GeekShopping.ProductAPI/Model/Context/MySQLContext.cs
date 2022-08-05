using Microsoft.EntityFrameworkCore;

namespace GeekShopping.ProductAPI.Model.Context
{
    public class MySQLContext : DbContext
    {
        public MySQLContext() {}
        public MySQLContext(DbContextOptions<MySQLContext> options) : base(options) {}

        public DbSet<Product> Products { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 2,
                Name = "Name",
                Price = new decimal(69.9),
                Description = "Camiseta",
                ImageURL = "",
                CategoryName = "T-shirt"
            });

            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 3,
                Name = "Name 2",
                Price = new decimal(70),
                Description = "Camiseta",
                ImageURL = "",
                CategoryName = "T-shirt"
            });

            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 4,
                Name = "Name 3",
                Price = new decimal(69.5),
                Description = "Camiseta",
                ImageURL = "",
                CategoryName = "T-shirt"
            });

            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 5,
                Name = "Name 4",
                Price = new decimal(39.9),
                Description = "Camiseta",
                ImageURL = "",
                CategoryName = "T-shirt"
            });

            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 6,
                Name = "Name 5",
                Price = new decimal(49.9),
                Description = "Camiseta",
                ImageURL = "",
                CategoryName = "T-shirt"
            });

            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 7,
                Name = "Name 6",
                Price = new decimal(79.9),
                Description = "Camiseta",
                ImageURL = "",
                CategoryName = "T-shirt"
            });
        }
    }
}
