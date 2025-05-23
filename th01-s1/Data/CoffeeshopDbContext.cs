using th01_s1.Models;
using Microsoft.EntityFrameworkCore;
namespace th01_s1.Data
{
    public class CoffeeshopDbContext : DbContext
    {
        public CoffeeshopDbContext(DbContextOptions<CoffeeshopDbContext> options) :
       base(options)
        {
        }
        public DbSet<Product> Products { get; set; }
    }
}