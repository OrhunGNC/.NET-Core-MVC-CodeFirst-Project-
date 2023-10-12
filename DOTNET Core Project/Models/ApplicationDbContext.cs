using Microsoft.EntityFrameworkCore;

namespace DOTNET_Core_Project.Models
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> dbcontext) : base(dbcontext)
        {
            
        }
        public DbSet<Hastaneler> hastanelers { get; set; }
        public DbSet<Veterinerler> veterinerlers { get; set; }
        public DbSet<Turler> turlers { get; set; }
        public DbSet<Randevular> randevulars { get; set; }
        public DbSet<Musteriler> musterilers { get; set; }
        public DbSet<Pets> petss { get; set; }
    }
}
