using E_Commerce.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace E_Commerce.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        { }
            public DbSet<Customer> Customer { get; set; }
            public DbSet<Vendor> Vendor { get; set; }
            public DbSet<Product> Product { get; set; }
            public DbSet<Category> Category { get; set; }
            public DbSet<Order> Order { get; set; }
        
    }
}
