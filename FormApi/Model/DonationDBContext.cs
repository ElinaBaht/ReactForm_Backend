using Microsoft.EntityFrameworkCore;

namespace FormApi.Model
{
    public class DonationDBContext:DbContext
    {
        public DonationDBContext(DbContextOptions<DonationDBContext> options):base(options)
        {

        }

        public DbSet<DCandidate> Dandidates { get; set; }
    }
}
