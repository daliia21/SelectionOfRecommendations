using Microsoft.EntityFrameworkCore;
using System.Data.Common;
using System.Reflection.Emit;
using TouristRoutes.Models;

namespace TouristRoutes
{
    public class AppDbContext : DbContext
    {
        public DbSet<AppUser> Users { get; set; }
        public DbSet<AppUserInfo> UserInfos { get; set; }

        public DbSet<Tag> Tags { get; set; }
        

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AppUser>()
                .HasOne(u => u.AppUserInfo)
                .WithOne(ui => ui.AppUser)
                .HasForeignKey<AppUserInfo>(ui => ui.AppUserId);

            modelBuilder.Entity<Tag>()
                .Property(t => t.TagType)
                .HasConversion<int>();

            base.OnModelCreating(modelBuilder);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("Host=localhost;Port=5432;Database=tourist_routes;Username=postgres;Password=postgres");
        }
    }
}
