using Microsoft.EntityFrameworkCore;
using TouristRoutes.Models;

namespace TouristRoutes
{
    /// <summary>
    /// Класс контекста базы данных
    /// </summary>
    public class AppDbContext : DbContext
    {
        /// <summary>
        /// Таблица пользователей
        /// </summary>
        public DbSet<AppUser> Users { get; set; }

        /// <summary>
        /// Таблица тегов
        /// </summary>
        public DbSet<Tag> Tags { get; set; }

        /// <summary>
        /// Таблица тегов пользователей
        /// </summary>
        public DbSet<AppUserTag> UserInfoTags { get; set; }

        /// <summary>
        /// Таблица тегов маршрутов
        /// </summary>
        public DbSet<RouteTag> RouteInfoTags { get; set; }

        /// <summary>
        /// Таблица маршрутов
        /// </summary>
        public DbSet<Route> Routes { get; set; }

        /// <summary>
        /// Таблица избранных маршрутов пользователей
        /// </summary>
        public DbSet<UserFavoriteRoute> UserInfoFavoriteRoutes { get; set; }



        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {        
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

            modelBuilder.Entity<RouteTag>()
            .HasKey(rt => new { rt.RouteId, rt.TagId });

            modelBuilder.Entity<RouteTag>()
                .HasOne(rt => rt.Route)
                .WithMany(r => r.RouteTags)
                .HasForeignKey(rt => rt.RouteId);

            modelBuilder.Entity<RouteTag>()
                .HasOne(rt => rt.Tag)
                .WithMany()
                .HasForeignKey(rt => rt.TagId);

            modelBuilder.Entity<UserFavoriteRoute>()
                .HasKey(ufr => new { ufr.AppUserId, ufr.RouteId });

            modelBuilder.Entity<UserFavoriteRoute>()
                .HasOne(ufr => ufr.AppUser)
                .WithMany(u => u.UserFavoriteRoutes)
                .HasForeignKey(ufr => ufr.AppUserId);

            modelBuilder.Entity<UserFavoriteRoute>()
                .HasOne(ufr => ufr.Route)
                .WithMany()
                .HasForeignKey(ufr => ufr.RouteId);

            base.OnModelCreating(modelBuilder);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("Host=localhost;Port=5432;Database=tourist_routes;Username=postgres;Password=4286");
        }
    }
}
