using Microsoft.EntityFrameworkCore;
using Internet_shop.Models;

namespace Internet_shop.Models
{
    public class ShirtContext : DbContext
    {
        public DbSet<Shirt> Shirts { get; set; }
        public ShirtContext(DbContextOptions<ShirtContext> options)
            : base(options)
        {
            Database.EnsureCreated();
        }
    }
}