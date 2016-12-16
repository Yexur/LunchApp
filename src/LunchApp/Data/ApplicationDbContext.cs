using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using LunchApp.Models;
using LunchApp.Models.ApplicationModels;

namespace LunchApp.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public DbSet<RestaurantModel> Restaurant { get; set; }
        public DbSet<LocationModel> Location { get; set; }
        public DbSet<RestaurantTypeModel> RestaurantType { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            // Customize the ASP.NET Identity model and override the defaults if needed.
            // For example, you can rename the ASP.NET Identity table names and more.
            // Add your customizations after calling base.OnModelCreating(builder);

            builder.Entity<RestaurantModel>()
                .Property(r => r.Name)
                .IsRequired();

            builder.Entity<RestaurantModel>()
                .HasOne(p => p.RestaurantType)
                .WithMany(p => p.Restaurants)
                .HasForeignKey(p => p.RestaurantTypeId);

            builder.Entity<RestaurantTypeModel>()
                .Property(r => r.FoodType)
                .IsRequired();

            builder.Entity<LocationModel>()
                .HasOne(p => p.Restaurant)
                .WithMany(p => p.Locations)
                .HasForeignKey(p => p.RestaurantId);               
        }
    }
}
