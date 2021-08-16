using Microsoft.EntityFrameworkCore;

namespace Data.Data
{
    public class SocialDbContext : DbContext
    {
        public SocialDbContext (DbContextOptions<SocialDbContext> options)
            : base(options)
        {
        }

        public DbSet<Domain.Model.Entities.Donation> Donation { get; set; }

        public DbSet<Domain.Model.Entities.Profile> Profile { get; set; }
    }
}
