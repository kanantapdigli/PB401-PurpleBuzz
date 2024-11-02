using Microsoft.EntityFrameworkCore;
using PB401_PurpleBuzz.Entities;

namespace PB401_PurpleBuzz.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        public DbSet<TeamMember> TeamMembers { get; set; }
        public DbSet<WorkCategory> WorkCategories { get; set; }
        public DbSet<Work> Works { get; set; }
    }
}
