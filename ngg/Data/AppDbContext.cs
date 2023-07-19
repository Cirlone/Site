using Microsoft.EntityFrameworkCore;
using ngg.Models;

namespace ngg.Data
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
            
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Street_House>().HasKey(sh => new
            {
                sh.StreetId,
                sh.HouseId
            });
            modelBuilder.Entity<Street_House>().HasOne(h => h.House).WithMany(sh => sh.Streets_Houses).HasForeignKey(h => h.HouseId);
            modelBuilder.Entity<Street_House>().HasOne(h => h.Street).WithMany(sh => sh.Streets_Houses).HasForeignKey(h => h.StreetId);
            base.OnModelCreating(modelBuilder);
        }
        public DbSet<Street> Streets{ get; set; }
        public DbSet<House> Houses { get; set; }

        public DbSet<Agent> Agents { get; set; }

        public DbSet<Shaorma> Shaormas { get; set; }



    }
}
