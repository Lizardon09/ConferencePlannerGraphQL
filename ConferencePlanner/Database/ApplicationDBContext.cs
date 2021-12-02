using ConferencePlanner.Database.Models;
using Microsoft.EntityFrameworkCore;

namespace ConferencePlanner.Database
{
    public class ApplicationDBContext : DbContext
    {
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options) : base(options)
        {
        }

        public DbSet<Speaker> Speakers { get; set; }
    }
}
