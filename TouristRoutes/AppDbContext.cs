using Microsoft.EntityFrameworkCore;
using System.Data.Common;
using System.Reflection.Emit;
using TouristRoutes.Models;
using TouristRoutes.Models.TagModels;

namespace TouristRoutes
{
    public class AppDbContext : DbContext
    {
        public DbSet<AppUser> Users { get; set; }
        public DbSet<AppUserInfo> UserInfos { get; set; }

        public DbSet<AgeTag> AgeTags { get; set; }
        public DbSet<BudgetTag> BudgetTags { get; set; }
        public DbSet<DurationTag> DurationTags { get; set; }
        public DbSet<LevelOfTrainingTag> LevelOfTrainingTags { get; set; }
        public DbSet<LocationTag> LocationTags { get; set; }
        public DbSet<PurposeTag> PurposeTags { get; set; }
        public DbSet<SeasonTag> SeasonTags { get; set; }
        public DbSet<TypeOfTourismTag> TypeOfTourismTags { get; set; }






        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AppUser>()
                .HasOne(u => u.AppUserInfo)
                .WithOne(ui => ui.AppUser)
                .HasForeignKey<AppUserInfo>(ui => ui.AppUserId);

            base.OnModelCreating(modelBuilder);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("Host=localhost;Port=5432;Database=tourist_routes;Username=postgres;Password=postgres");
        }
    }
}
