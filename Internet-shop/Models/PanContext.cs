using Microsoft.EntityFrameworkCore;
using Internet_shop.Models;

namespace Internet_shop.Models
{
    public class PanContext:DbContext
    {
        public DbSet<Pan> Pans { get; set; }
        public PanContext(DbContextOptions<PanContext> options)
            : base(options)
        {
            Database.EnsureCreated();
        }
    }
}
