using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace LandingPage.API.Data
{
    public class AthenaPayLandingPageDbContext : IdentityDbContext<ApplicationUser, ApplicationRole, string, IdentityUserClaim<string>,
ApplicationUserRole, IdentityUserLogin<string>,
IdentityRoleClaim<string>, IdentityUserToken<string>>
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
        public virtual DbSet<GroupTenant> GroupTenants { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<ApplicationUserRole>(userRole =>
            {
                userRole.HasKey(ur => new { ur.UserId, ur.RoleId });

                userRole.HasOne(ur => ur.Role)
                    .WithMany(r => r.UserRoles)
                    .HasForeignKey(ur => ur.RoleId);

                userRole.HasOne(ur => ur.User)
                    .WithMany(r => r.UserRoles)
                    .HasForeignKey(ur => ur.UserId);
            });

            modelBuilder.Entity<ApplicationUser>()
                        .Property(e => e.Id)
                        .ValueGeneratedOnAdd();

            modelBuilder.Entity<Group>(entity =>
            {
                entity.Property(e => e.GroupName).HasMaxLength(50);
            });

            modelBuilder.Entity<Tenant>(entity =>
            {
                entity.Property(e => e.TenantName).HasMaxLength(50);
                entity.Property(e => e.Url).HasMaxLength(250);

            });

            modelBuilder.Entity<GroupTenant>()
                .HasKey (gt => new { gt.GroupId, gt.TenantId });

            modelBuilder.Entity<GroupTenant>()
                .HasOne(gt => gt.Group)
                .WithMany(g => g.GroupTenants)
                .HasForeignKey(gt => gt.GroupId);

            modelBuilder.Entity<GroupTenant>()
                  .HasOne(gt => gt.Tenant)
                  .WithMany(t => t.GroupTenants)
                  .HasForeignKey(gt => gt.TenantId);

            modelBuilder.Entity<ApplicationRole>().HasData(
                new ApplicationRole
                {
                    Name = "Admin",
                    NormalizedName = "ADMIN",
                    Id = "a998f9ea-d2ef-4835-8744-590e2f4157eb"
                },
                new ApplicationRole
                {
                    Name = "Merchant",
                    NormalizedName = "MERCHANT",
                    Id = "a5c6115c-a79d-444a-b92a-2f4496e2f175"
                },
                new ApplicationRole
                {
                    Name = "Tenant",
                    NormalizedName = "TENANT",
                    Id = "ebef473b-b328-426b-b5b7-40008974384c"
                },
                new ApplicationRole
                {
                    Name = "NewTenant",
                    NormalizedName = "NEWTENANT",
                    Id = "9e229e60-a76b-4088-a262-bfa9d8e1a6cd"
                }
                );

            var hasher = new PasswordHasher<ApplicationUser>();

            modelBuilder.Entity<ApplicationUser>().HasData(
                new ApplicationUser
                {
                    Id = "e9caf277-b4f7-48d9-a97f-c2533e6adbe3",
                    Email = "admin@admin.no",
                    NormalizedEmail = "ADMIN@ADMIN.NO",
                    UserName = "admin@admin.no",
                    NormalizedUserName = "ADMIN@ADMIN.NO",
                    FirstName = "Admin",
                    LastName = "Bruker",
                    PasswordHash = hasher.HashPassword(null, "Test123."),
                    IsActive = true
                },
                new ApplicationUser
                {
                    Id = "b575d83e-27e5-4f5e-8a3d-a607a5bdc0fb",
                    Email = "merchant@merchant.com",
                    NormalizedEmail = "MERCHANT@MERCHANT.COM",
                    UserName = "merchant@merchant.com",
                    NormalizedUserName = "MERCHANT@MERCHANT.COM",
                    FirstName = "Forhandler",
                    LastName = "Bruker",
                    PasswordHash = hasher.HashPassword(null, "Test123."),
                    IsActive = true
                },
                new ApplicationUser
                {
                    Id = "e20119f7-b5cb-43b3-8183-3f814334b160",
                    Email = "tenant@tenant.no",
                    NormalizedEmail = "TENANT@TENANT.NO",
                    UserName = "tenant@tenant.no",
                    NormalizedUserName = "TENANT@TENANT.NO",
                    FirstName = "Tenant",
                    LastName = "Bruker",
                    PasswordHash = hasher.HashPassword(null, "Test123."),
                    IsActive = true
                }
                );

            modelBuilder.Entity<ApplicationUserRole>().HasData(
                new ApplicationUserRole
                {
                    RoleId = "a998f9ea-d2ef-4835-8744-590e2f4157eb",
                    UserId = "e9caf277-b4f7-48d9-a97f-c2533e6adbe3"
                },
                new ApplicationUserRole
                {
                    RoleId = "a5c6115c-a79d-444a-b92a-2f4496e2f175",
                    UserId = "b575d83e-27e5-4f5e-8a3d-a607a5bdc0fb"
                },
                new ApplicationUserRole
                {
                    RoleId = "ebef473b-b328-426b-b5b7-40008974384c",
                    UserId = "e20119f7-b5cb-43b3-8183-3f814334b160"
                }
                );

            modelBuilder.Entity<Tenant>().HasData(
                new Tenant
                {
                    TenantName = "Tenant1",
                    Url = "tenant1url.no/activate",
                    IsActive = true,
                    TenantId = 1
                },
                new Tenant
                {
                    TenantName = "Tenant2",
                    Url = "tenant2url.no/activate",
                    IsActive = true,
                    TenantId = 2
                },
                new Tenant
                {
                    TenantName = "Tenant3",
                    Url = "tenant3url.no/activate",
                    IsActive = true,
                    TenantId = 3
                }
             );

            modelBuilder.Entity<Group>().HasData(
                new Group
                {
                    GroupName = "Group1",
                    IsActiveGroup = true,
                    GroupId = 1
                },
                new Group
                {
                    GroupName = "Group2",
                    IsActiveGroup = true,
                    GroupId = 2
                },
                new Group
                {
                    GroupName = "Group3",
                    IsActiveGroup = true,
                    GroupId = 3
                }  
             );

            modelBuilder.Entity<GroupTenant>().HasData(
                new GroupTenant
                {
                    TenantId = 1,
                    GroupId = 3
                },
                new GroupTenant
                {
                    TenantId = 2,
                    GroupId = 3
                },
                new GroupTenant
                {
                    TenantId = 3,
                    GroupId = 1
                }

            );
        }
    }
}
