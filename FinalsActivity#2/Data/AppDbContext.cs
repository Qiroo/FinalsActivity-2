using FinalsActivity_2.Models;
using Microsoft.EntityFrameworkCore;

namespace FinalsActivity_2.Data
{
    public class AppDbContext : DbContext
    {
        public DbSet<Brand> Brands { get; set; }
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
    }
}
