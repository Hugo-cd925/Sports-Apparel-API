using Microsoft.EntityFrameworkCore;
namespace Sports_Apparel_API.Models
{
    public class SportsApparelContext : DbContext
    {
        //constructor
        public SportsApparelContext(DbContextOptions<SportsApparelContext> options) : base(options) { }
        public DbSet<Product> Product { get; set; }
    }
}
