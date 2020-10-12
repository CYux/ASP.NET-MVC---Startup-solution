using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Otthonbazar.Data.EntityTypeConfigurations;
using Otthonbazar.Data;

namespace Otthonbazar.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
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
            builder.Entity<City>().ToTable("City");
            builder.Entity<Advertisement>().ToTable("Advertisement");
            builder.Entity<Advertisement>()
                .HasOne(a => a.City)
                .WithMany(c => c.Advertisements)
                .HasForeignKey(a => a.CityId);
            builder.ApplyConfiguration(new CitySeedConfig());
            builder.ApplyConfiguration(new AdvertisementSeedConfig());
        }

        public DbSet<Otthonbazar.Data.Advertisement> Advertisement { get; set; }
    }
}
