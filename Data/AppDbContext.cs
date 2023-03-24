using Microsoft.EntityFrameworkCore;
using NumbersAPI.Models;

namespace NumbersAPI.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        public DbSet<NumItem> Numbers => Set<NumItem>();
    }
}