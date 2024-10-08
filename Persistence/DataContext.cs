
using Microsoft.EntityFrameworkCore;
using Domain;

namespace Persistence
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions options) : base(options)
        {
        }
        // uses the activity table
        public DbSet<Activity> Activities { get; set; } // table name = Activities
    }
}