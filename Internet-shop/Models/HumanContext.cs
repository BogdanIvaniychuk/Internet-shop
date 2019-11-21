using Microsoft.EntityFrameworkCore;
using Internet_shop.Models;

namespace Internet_shop.Models
{
    public class HumanContext : DbContext
    {
        public DbSet<Human> Humen { get; set; }
        public HumanContext(DbContextOptions<HumanContext> options)
        : base(options)
        {
            Database.EnsureCreated();
        }
}

}
