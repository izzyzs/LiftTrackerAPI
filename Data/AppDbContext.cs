using LiftTrackerAPI.Types;
using Microsoft.EntityFrameworkCore;

namespace LiftTrackerAPI.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

            public DbSet<User> Users => Set<User>();
    }
}