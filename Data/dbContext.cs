using Microsoft.EntityFrameworkCore;
using wTickets.Models;
namespace wTickets.Data
{
    public class dbContext : DbContext
    {
        public dbContext(DbContextOptions<dbContext> options) : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Composite Key
            modelBuilder.Entity<Actor_Movie>().HasKey(
                am => new
                {
                    am.actorId,
                    am.movieId
                });

            // Relations
            modelBuilder.Entity<Actor_Movie>()
                .HasOne(am => am.Movie)
                .WithMany(m => m.Actor_Movie)
                .HasForeignKey(am => am.movieId);
            modelBuilder.Entity<Actor_Movie>()
                .HasOne(am => am.Actor)
                .WithMany(m => m.Actor_Movie)
                .HasForeignKey(am => am.actorId);
        }
        public DbSet<Actor> Actor { get; set; }
        public DbSet<Cinema> Cinema { get; set; }
        public DbSet<Movie> Movie { get; set; }
        public DbSet<Producer> Producer { get; set; }
        public DbSet<Actor_Movie> Actor_Movie { get; set; }
    }
}
