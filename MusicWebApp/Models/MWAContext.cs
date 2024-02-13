using Microsoft.EntityFrameworkCore;

namespace MusicWebApp.Models
{
    public class MWAContext : DbContext
    {
        public DbSet<Music> Music { get; set; }
        public MWAContext(DbContextOptions<MWAContext> options) : base(options) { }
    }
}
