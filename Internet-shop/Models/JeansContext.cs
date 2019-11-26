using Microsoft.EntityFrameworkCore;
using Internet_shop.Models;

namespace Internet_shop.Models
{
    public class JeansContext : DbContext
    {
        public DbSet<Jeans> jeans { get; set; }
        public JeansContext(DbContextOptions<JeansContext> options)
            :base(options)
        {
            Database.EnsureCreated();
        }
    }
}
