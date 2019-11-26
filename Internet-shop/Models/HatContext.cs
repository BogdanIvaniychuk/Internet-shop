using Microsoft.EntityFrameworkCore;
using Internet_shop.Models;

namespace Internet_shop.Models
{
    public class HatContext : DbContext
    {
        public DbSet<Hat> Hats { get; set; }
        public HatContext(DbContextOptions<HatContext> options)
            : base(options)
        {
            Database.EnsureCreated();
        }
    }
}
