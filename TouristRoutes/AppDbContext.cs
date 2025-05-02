using Microsoft.EntityFrameworkCore;
using System.Data.Common;
using System.Reflection.Emit;
using TouristRoutes.Models;

namespace TouristRoutes
{
    public class AppDbContext : DbContext
    {
        public DbSet<AppUser> Users { get; set; }
        public DbSet<Tag> Tags { get; set; }
        public DbSet<AppUserTag> UserInfoTags { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.Entity<AppUser>()
            //    .HasOne(u => u.AppUserInfo)
            //    .WithOne(ui => ui.AppUser)
            //    .HasForeignKey<AppUserInfo>(ui => ui.AppUserId);

            modelBuilder.Entity<Tag>()
                .Property(t => t.TagType)
                .HasConversion<int>();

            modelBuilder.Entity<AppUserTag>()
            .HasKey(ut => new { ut.AppUserId, ut.TagId });

            modelBuilder.Entity<AppUserTag>()
                .HasOne(ut => ut.AppUser)
                .WithMany(u => u.UserTags)
                .HasForeignKey(ut => ut.AppUserId);

            modelBuilder.Entity<AppUserTag>()
                .HasOne(ut => ut.Tag)
                .WithMany()
                .HasForeignKey(ut => ut.TagId);

            base.OnModelCreating(modelBuilder);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("Host=localhost;Port=5432;Database=tourist_routes;Username=postgres;Password=postgres");
        }
    }
}
