﻿// <auto-generated />
using System;
using LandingPage.API.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace LandingPage.API.Migrations
{
    [DbContext(typeof(AthenaPayLandingPageDbContext))]
    partial class AthenaPayLandingPageDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("LandingPage.API.Data.ApplicationUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool?>("IsActive")
                        .HasColumnType("bit");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers", (string)null);

                    b.HasData(
                        new
                        {
                            Id = "e9caf277-b4f7-48d9-a97f-c2533e6adbe3",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "d8f2799f-1142-4a54-98c9-04f8fcb7d348",
                            Email = "admin@admin.no",
                            EmailConfirmed = false,
                            FirstName = "Admin",
                            IsActive = true,
                            LastName = "Bruker",
                            LockoutEnabled = false,
                            NormalizedEmail = "ADMIN@ADMIN.NO",
                            NormalizedUserName = "ADMIN@ADMIN.NO",
                            PasswordHash = "AQAAAAEAACcQAAAAEIpQlQ9KHWjqnP/b+i/p53RoHyGL0eicm687RVJCzrmzi8bJUW64Za8pKfNc0H0iww==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "cbf50947-02be-45bb-8887-30fcf5b7c49a",
                            TwoFactorEnabled = false,
                            UserName = "admin@admin.no"
                        },
                        new
                        {
                            Id = "b575d83e-27e5-4f5e-8a3d-a607a5bdc0fb",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "748ad0b1-a98a-4463-82f2-581b9090edfe",
                            Email = "merchant@merchant.com",
                            EmailConfirmed = false,
                            FirstName = "Forhandler",
                            IsActive = true,
                            LastName = "Bruker",
                            LockoutEnabled = false,
                            NormalizedEmail = "MERCHANT@MERCHANT.COM",
                            NormalizedUserName = "MERCHANT@MERCHANT.COM",
                            PasswordHash = "AQAAAAEAACcQAAAAENTGizLEDWDbzIbCvT06+Hftw6+lxuUA1SoXpMGnsH3LDz5VkxTwwVuZP4qTH6mBdA==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "5d862b4c-10c9-4250-bf41-425dca5d7b68",
                            TwoFactorEnabled = false,
                            UserName = "merchant@merchant.com"
                        },
                        new
                        {
                            Id = "e20119f7-b5cb-43b3-8183-3f814334b160",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "6b0583ae-f93b-4ba7-bc90-19bbb7ca6c9c",
                            Email = "tenant@tenant.no",
                            EmailConfirmed = false,
                            FirstName = "Tenant",
                            IsActive = true,
                            LastName = "Bruker",
                            LockoutEnabled = false,
                            NormalizedEmail = "TENANT@TENANT.NO",
                            NormalizedUserName = "TENANT@TENANT.NO",
                            PasswordHash = "AQAAAAEAACcQAAAAEGyauZyv1rG7vZcu5ecxTMLewsLUVN9sCZ1aQdv/1sKFuBWqF05m6pSZeXGKLrWI2Q==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "9d515619-3183-465b-87b3-5a1cdf6fe81b",
                            TwoFactorEnabled = false,
                            UserName = "tenant@tenant.no"
                        });
                });

            modelBuilder.Entity("LandingPage.API.Data.Group", b =>
                {
                    b.Property<int>("GroupId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("GroupId"), 1L, 1);

                    b.Property<string>("ApplicationUserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("GroupName")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<bool>("IsActiveGroup")
                        .HasColumnType("bit");

                    b.HasKey("GroupId");

                    b.HasIndex("ApplicationUserId");

                    b.ToTable("Groups");
                });

            modelBuilder.Entity("LandingPage.API.Data.Tenant", b =>
                {
                    b.Property<int>("TenantId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("TenantId"), 1L, 1);

                    b.Property<int?>("GroupId")
                        .HasColumnType("int");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<string>("TenantName")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Url")
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.HasKey("TenantId");

                    b.HasIndex("GroupId");

                    b.ToTable("Tenants");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles", (string)null);

                    b.HasData(
                        new
                        {
                            Id = "a998f9ea-d2ef-4835-8744-590e2f4157eb",
                            ConcurrencyStamp = "d4a93381-fb5c-4b36-80a6-64ea83afe51c",
                            Name = "Admin",
                            NormalizedName = "ADMIN"
                        },
                        new
                        {
                            Id = "a5c6115c-a79d-444a-b92a-2f4496e2f175",
                            ConcurrencyStamp = "ae610229-e516-4553-a4b2-3f255571b80f",
                            Name = "Merchant",
                            NormalizedName = "MERCHANT"
                        },
                        new
                        {
                            Id = "ebef473b-b328-426b-b5b7-40008974384c",
                            ConcurrencyStamp = "0d215a35-5d2a-41bf-a088-78ad26662538",
                            Name = "Tenant",
                            NormalizedName = "TENANT"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);

                    b.HasData(
                        new
                        {
                            UserId = "e9caf277-b4f7-48d9-a97f-c2533e6adbe3",
                            RoleId = "a998f9ea-d2ef-4835-8744-590e2f4157eb"
                        },
                        new
                        {
                            UserId = "b575d83e-27e5-4f5e-8a3d-a607a5bdc0fb",
                            RoleId = "a5c6115c-a79d-444a-b92a-2f4496e2f175"
                        },
                        new
                        {
                            UserId = "e20119f7-b5cb-43b3-8183-3f814334b160",
                            RoleId = "ebef473b-b328-426b-b5b7-40008974384c"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("LandingPage.API.Data.Group", b =>
                {
                    b.HasOne("LandingPage.API.Data.ApplicationUser", null)
                        .WithMany("Groups")
                        .HasForeignKey("ApplicationUserId");
                });

            modelBuilder.Entity("LandingPage.API.Data.Tenant", b =>
                {
                    b.HasOne("LandingPage.API.Data.Group", "Group")
                        .WithMany("Tenants")
                        .HasForeignKey("GroupId")
                        .HasConstraintName("FK_Tenants_Groups_GroupId");

                    b.Navigation("Group");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("LandingPage.API.Data.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("LandingPage.API.Data.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("LandingPage.API.Data.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("LandingPage.API.Data.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("LandingPage.API.Data.ApplicationUser", b =>
                {
                    b.Navigation("Groups");
                });

            modelBuilder.Entity("LandingPage.API.Data.Group", b =>
                {
                    b.Navigation("Tenants");
                });
#pragma warning restore 612, 618
        }
    }
}
