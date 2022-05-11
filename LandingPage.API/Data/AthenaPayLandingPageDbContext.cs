using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace LandingPage.API.Data
{
    public partial class AthenaPayLandingPageDbContext : DbContext
    {
        public AthenaPayLandingPageDbContext()
        {
        }

        public AthenaPayLandingPageDbContext(DbContextOptions<AthenaPayLandingPageDbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Group> Groups { get; set; }
        public virtual DbSet<Tenant> Tenants { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            OnModelCreatingPartial(modelBuilder);

            modelBuilder.Entity<Group>(entity =>
            {
                entity.Property(e => e.GroupName).HasMaxLength(50);
            });

            modelBuilder.Entity<Tenant>(entity =>
            {
                entity.Property(e => e.TenantName).HasMaxLength(50);
                entity.Property(e => e.Url).HasMaxLength(250);

                entity.HasOne(d => d.Group)
                        .WithMany(p => p.Tenants)
                        .HasForeignKey(d => d.GroupId)
                        .HasConstraintName("FK_Tenants_Groups_GroupId");
            });
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
