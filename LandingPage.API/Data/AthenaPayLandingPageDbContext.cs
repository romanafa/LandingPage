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
                    Id = "10baaefa-d3f0-45a5-a348-ac991898e3fe",
                    Email = "kari@tenant.no",
                    NormalizedEmail = "KARI@TENANT.NO",
                    UserName = "kari@tenant.no",
                    NormalizedUserName = "KARI@TENANT.NO",
                    FirstName = "Kari",
                    LastName = "Nordmann",
                    PasswordHash = hasher.HashPassword(null, "Test123."),
                    IsActive = false
                },
                new ApplicationUser
                {
                    Id = "cdf19c52-c8f0-4207-a682-36bbc27930fd",
                    Email = "ola@forhandler.no",
                    NormalizedEmail = "OLA@FORHANDLER.NO",
                    SecurityStamp = Guid.NewGuid().ToString(),
                    UserName = "ola@forhandler.no",
                    NormalizedUserName = "OLA@FORHANDLER.NO",
                    FirstName = "Ola",
                    LastName = "Nordmann",
                    PasswordHash = hasher.HashPassword(null, "Test123."),
                    IsActive = true
                },
                new ApplicationUser
                {
                    Id = "0e3aef22-513f-4e24-90d8-c41beb1e8942",
                    Email = "tenant2@tenant.no",
                    NormalizedEmail = "TENANT2@TENANT.NO",
                    SecurityStamp = Guid.NewGuid().ToString(),
                    UserName = "tenant2@tenant.no",
                    NormalizedUserName = "TENANT2@TENANT.NO",
                    FirstName = "Tenant2",
                    LastName = "Bruker2",
                    PasswordHash = hasher.HashPassword(null, "Test123."),
                    IsActive = false
                },
                new ApplicationUser
                {
                    Id = "9a48960c-57c6-4577-a926-5cd8e0e7478c",
                    Email = "tenant3@tenant.no",
                    NormalizedEmail = "TENANT3@TENANT.NO",
                    SecurityStamp = Guid.NewGuid().ToString(),
                    UserName = "tenant3@tenant.no",
                    NormalizedUserName = "TENANT3@TENANT.NO",
                    FirstName = "Tenant3",
                    LastName = "Bruker3",
                    PasswordHash = hasher.HashPassword(null, "Test123."),
                    IsActive = true
                },
                new ApplicationUser
                {
                    Id = "3f391255-44a0-49d6-803c-555296633ed1",
                    Email = "tenant4@tenant.no",
                    NormalizedEmail = "TENANT4@TENANT.NO",
                    UserName = "tenant4@tenant.no",
                    NormalizedUserName = "TENANT4@TENANT.NO",
                    SecurityStamp = Guid.NewGuid().ToString(),
                    FirstName = "Tenant4",
                    LastName = "Bruker4",
                    PasswordHash = hasher.HashPassword(null, "Test123."),
                    IsActive = true
                },
                new ApplicationUser
                {
                    Id = "1273ff89-5875-4e1f-944c-dfc2223b06e9",
                    Email = "tenant5@tenant.no",
                    NormalizedEmail = "TENANT5@TENANT.NO",
                    SecurityStamp = Guid.NewGuid().ToString(),
                    UserName = "tenant5@tenant.no",
                    NormalizedUserName = "TENANT5@TENANT.NO",
                    FirstName = "Tenant5",
                    LastName = "Bruker5",
                    PasswordHash = hasher.HashPassword(null, "Test123."),
                    IsActive = true
                },
                new ApplicationUser
                {
                    Id = "2dd414a1-2be5-4896-ad64-d6012f06505d",
                    Email = "tenant6@tenant.no",
                    NormalizedEmail = "TENANT6@TENANT.NO",
                    SecurityStamp = Guid.NewGuid().ToString(),
                    UserName = "tenant6@tenant.no",
                    NormalizedUserName = "TENANT6@TENANT.NO",
                    FirstName = "Tenant6",
                    LastName = "Bruker6",
                    PasswordHash = hasher.HashPassword(null, "Test123."),
                    IsActive = true
                },
                new ApplicationUser
                {
                    Id = "20f6ed72-6071-4ca2-be2d-caff78a84edd",
                    Email = "tenant7@tenant.no",
                    NormalizedEmail = "TENANT7@TENANT.NO",
                    SecurityStamp = Guid.NewGuid().ToString(),
                    UserName = "tenant7@tenant.no",
                    NormalizedUserName = "TENANT7@TENANT.NO",
                    FirstName = "Tenant7",
                    LastName = "Bruker7",
                    PasswordHash = hasher.HashPassword(null, "Test123."),
                    IsActive = true
                },
                new ApplicationUser
                {
                    Id = "cc3eafff-5099-405e-b73e-b8a2da435e7d",
                    Email = "tenant8@tenant.no",
                    NormalizedEmail = "TENANT8@TENANT.NO",
                    SecurityStamp = Guid.NewGuid().ToString(),
                    UserName = "tenant8@tenant.no",
                    NormalizedUserName = "TENANT8@TENANT.NO",
                    FirstName = "Tenant8",
                    LastName = "Bruker8",
                    PasswordHash = hasher.HashPassword(null, "Test123."),
                    IsActive = true
                },
                new ApplicationUser
                {
                    Id = "ae4cf9c8-69fb-48fc-9845-e96402dc5647",
                    Email = "tenant9@tenant.no",
                    NormalizedEmail = "TENANT9@TENANT.NO",
                    SecurityStamp = Guid.NewGuid().ToString(),
                    UserName = "tenant9@tenant.no",
                    NormalizedUserName = "TENANT9@TENANT.NO",
                    FirstName = "Tenant9",
                    LastName = "Bruker9",
                    PasswordHash = hasher.HashPassword(null, "Test123."),
                    IsActive = true
                },
                new ApplicationUser
                {
                    Id = "b99dd035-d9b7-4fe6-ac8c-bdbfb94224d1",
                    Email = "tenant10@tenant.no",
                    NormalizedEmail = "TENANT10@TENANT.NO",
                    SecurityStamp = Guid.NewGuid().ToString(),
                    UserName = "tenant10@tenant.no",
                    NormalizedUserName = "TENANT10@TENANT.NO",
                    FirstName = "Tenant10",
                    LastName = "Bruker10",
                    PasswordHash = hasher.HashPassword(null, "Test123."),
                    IsActive = true
                },
                new ApplicationUser
                {
                    Id = "becb3779-8931-4068-ac03-28ccf509db3d",
                    Email = "tenant11@tenant.no",
                    NormalizedEmail = "TENANT11@TENANT.NO",
                    SecurityStamp = Guid.NewGuid().ToString(),
                    UserName = "tenant11@tenant.no",
                    NormalizedUserName = "TENANT11@TENANT.NO",
                    FirstName = "Tenant11",
                    LastName = "Bruker11",
                    PasswordHash = hasher.HashPassword(null, "Test123."),
                    IsActive = false
                },
                new ApplicationUser
                {
                    Id = "6c3ff3ae-f201-4189-a082-9e3bf7bb6e8b",
                    Email = "tenant12@tenant.no",
                    NormalizedEmail = "TENANT12@TENANT.NO",
                    SecurityStamp = Guid.NewGuid().ToString(),
                    UserName = "tenant12@tenant.no",
                    NormalizedUserName = "TENANT12@TENANT.NO",
                    FirstName = "Tenant12",
                    LastName = "Bruker12",
                    PasswordHash = hasher.HashPassword(null, "Test123."),
                    IsActive = false
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
                },
                new ApplicationUserRole
                {
                    RoleId = "ebef473b-b328-426b-b5b7-40008974384c",
                    UserId = "0e3aef22-513f-4e24-90d8-c41beb1e8942"
                },
                new ApplicationUserRole
                {
                    RoleId = "ebef473b-b328-426b-b5b7-40008974384c",
                    UserId = "9a48960c-57c6-4577-a926-5cd8e0e7478c"
                },
                new ApplicationUserRole
                {
                    RoleId = "ebef473b-b328-426b-b5b7-40008974384c",
                    UserId = "3f391255-44a0-49d6-803c-555296633ed1"
                },
                new ApplicationUserRole
                {
                    RoleId = "ebef473b-b328-426b-b5b7-40008974384c",
                    UserId = "1273ff89-5875-4e1f-944c-dfc2223b06e9"
                },
                new ApplicationUserRole
                {
                    RoleId = "ebef473b-b328-426b-b5b7-40008974384c",
                    UserId = "2dd414a1-2be5-4896-ad64-d6012f06505d"
                },
                new ApplicationUserRole
                {
                    RoleId = "ebef473b-b328-426b-b5b7-40008974384c",
                    UserId = "20f6ed72-6071-4ca2-be2d-caff78a84edd"
                },
                new ApplicationUserRole
                {
                    RoleId = "ebef473b-b328-426b-b5b7-40008974384c",
                    UserId = "cc3eafff-5099-405e-b73e-b8a2da435e7d"
                },
                new ApplicationUserRole
                {
                    RoleId = "ebef473b-b328-426b-b5b7-40008974384c",
                    UserId = "ae4cf9c8-69fb-48fc-9845-e96402dc5647"
                },
                new ApplicationUserRole
                {
                    RoleId = "ebef473b-b328-426b-b5b7-40008974384c",
                    UserId = "b99dd035-d9b7-4fe6-ac8c-bdbfb94224d1"
                },
                new ApplicationUserRole
                {
                    RoleId = "ebef473b-b328-426b-b5b7-40008974384c",
                    UserId = "becb3779-8931-4068-ac03-28ccf509db3d"
                },
                new ApplicationUserRole
                {
                    RoleId = "ebef473b-b328-426b-b5b7-40008974384c",
                    UserId = "6c3ff3ae-f201-4189-a082-9e3bf7bb6e8b"
                },
                new ApplicationUserRole
                {
                    RoleId = "a5c6115c-a79d-444a-b92a-2f4496e2f175",
                    UserId = "10baaefa-d3f0-45a5-a348-ac991898e3fe"
                },
                new ApplicationUserRole
                {
                    RoleId = "a5c6115c-a79d-444a-b92a-2f4496e2f175",
                    UserId = "cdf19c52-c8f0-4207-a682-36bbc27930fd"
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
                },
                new Tenant
                {
                    TenantName = "Tenant8",
                    Url = "tenant8url.no/activate",
                    IsActive = true,
                    TenantId = 8
                },
                new Tenant
                {
                    TenantName = "Tenant9",
                    Url = "tenant9url.no/activate",
                    IsActive = true,
                    TenantId = 9
                },
                new Tenant
                {
                    TenantName = "Tenant10",
                    Url = "tenant10url.no/activate",
                    IsActive = false,
                    TenantId = 10
                },
                new Tenant
                {
                    TenantName = "Tenant11",
                    Url = "tenant11url.no/activate",
                    IsActive = false,
                    TenantId = 11
                },
                new Tenant
                {
                    TenantName = "Tenant12",
                    Url = "tenant12url.no/activate",
                    IsActive = true,
                    TenantId = 12
                },
                new Tenant
                {
                    TenantName = "Tenant13",
                    Url = "tenant13url.no/activate",
                    IsActive = true,
                    TenantId = 13
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
                },
                new Group
                {
                    GroupName = "Group10",
                    IsActiveGroup = false,
                    GroupId = 10
                },
                new Group
                {
                    GroupName = "Group11",
                    IsActiveGroup = true,
                    GroupId = 11
                },
                new Group
                {
                    GroupName = "Group12",
                    IsActiveGroup = true,
                    GroupId = 12
                },
                new Group
                {
                    GroupName = "Group13",
                    IsActiveGroup = false,
                    GroupId = 13
                },
                new Group
                {
                    GroupName = "Group14",
                    IsActiveGroup = true,
                    GroupId = 14
                },
                new Group
                {
                    GroupName = "Group15",
                    IsActiveGroup = true,
                    GroupId = 15
                },
                new Group
                {
                    GroupName = "Group16",
                    IsActiveGroup = true,
                    GroupId = 16
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
