using System;
using System.Data.Entity;

namespace ProjectFiveSix.Models
{
    public class Product
    {
        public int productID { get; set; }
        public String productName { get; set; }
        public String manufactorer { get; set; }
        public String category { get; set; }
        public decimal price { get; set; }
    }
    public class ProductDBContext : DbContext
    {
        public DbSet<Product> products { get; set; }
    }
}