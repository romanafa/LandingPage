﻿// <auto-generated />
using System;
using LandingPage.API.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace LandingPage.API.Migrations
{
    [DbContext(typeof(AthenaPayLandingPageDbContext))]
    [Migration("20220526144353_update")]
    partial class update
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("ApplicationUserGroup", b =>
                {
                    b.Property<int>("GroupsGroupId")
                        .HasColumnType("int");

                    b.Property<string>("UsersId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("GroupsGroupId", "UsersId");

                    b.HasIndex("UsersId");

                    b.ToTable("ApplicationUserGroup");
                });

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
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<bool?>("IsActive")
                        .HasColumnType("bit");

                    b.Property<string>("LastName")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

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
                            ConcurrencyStamp = "db9551e1-2ff9-443e-bf6d-858f8ba8fd46",
                            Email = "admin@admin.no",
                            EmailConfirmed = false,
                            FirstName = "Admin",
                            IsActive = true,
                            LastName = "Bruker",
                            LockoutEnabled = false,
                            NormalizedEmail = "ADMIN@ADMIN.NO",
                            NormalizedUserName = "ADMIN@ADMIN.NO",
                            PasswordHash = "AQAAAAEAACcQAAAAEPttdjNrhlAfh00/wAzEnZBiy+QO+KVo4+6MzJ5UCmOamsgBnQtJS06MBJviES3/eA==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "d667427d-0c3c-4745-81f1-590426fe9bc6",
                            TwoFactorEnabled = false,
                            UserName = "admin@admin.no"
                        },
                        new
                        {
                            Id = "b575d83e-27e5-4f5e-8a3d-a607a5bdc0fb",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "b213add4-67aa-4c8d-94f3-1d9ea8f44d93",
                            Email = "merchant@merchant.com",
                            EmailConfirmed = false,
                            FirstName = "Forhandler",
                            IsActive = true,
                            LastName = "Bruker",
                            LockoutEnabled = false,
                            NormalizedEmail = "MERCHANT@MERCHANT.COM",
                            NormalizedUserName = "MERCHANT@MERCHANT.COM",
                            PasswordHash = "AQAAAAEAACcQAAAAEFN9rCapHLLmdAcsxLz//qKOqHVYQppUXQxfK71cdl9N73Z9pUXgrBeeVkWOqms5Mw==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "07a8ba5a-46ef-4d87-8312-b0bd2685baca",
                            TwoFactorEnabled = false,
                            UserName = "merchant@merchant.com"
                        },
                        new
                        {
                            Id = "e20119f7-b5cb-43b3-8183-3f814334b160",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "a5fc0c1f-afbc-4899-8a6d-94def56b276b",
                            Email = "tenant@tenant.no",
                            EmailConfirmed = false,
                            FirstName = "Tenant",
                            IsActive = true,
                            LastName = "Bruker",
                            LockoutEnabled = false,
                            NormalizedEmail = "TENANT@TENANT.NO",
                            NormalizedUserName = "TENANT@TENANT.NO",
                            PasswordHash = "AQAAAAEAACcQAAAAEOErS6iifK4YfGKTkky8BGgWfJrXBBD8USkaiVOaHXZVj7fDdvhntuWPS8VYmDNV1A==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "5937256b-2640-4997-b049-45b03f69e0e9",
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

                    b.Property<string>("GroupName")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<bool>("IsActiveGroup")
                        .HasColumnType("bit");

                    b.HasKey("GroupId");

                    b.ToTable("Groups");

                    b.HasData(
                        new
                        {
                            GroupId = 1,
                            GroupName = "Group1",
                            IsActiveGroup = true
                        },
                        new
                        {
                            GroupId = 2,
                            GroupName = "Group2",
                            IsActiveGroup = true
                        },
                        new
                        {
                            GroupId = 3,
                            GroupName = "Group3",
                            IsActiveGroup = true
                        });
                });

            modelBuilder.Entity("LandingPage.API.Data.GroupTenant", b =>
                {
                    b.Property<int>("GroupId")
                        .HasColumnType("int");

                    b.Property<int>("TenantId")
                        .HasColumnType("int");

                    b.HasKey("GroupId", "TenantId");

                    b.HasIndex("TenantId");

                    b.ToTable("GroupTenants");

                    b.HasData(
                        new
                        {
                            GroupId = 3,
                            TenantId = 1
                        },
                        new
                        {
                            GroupId = 3,
                            TenantId = 2
                        },
                        new
                        {
                            GroupId = 1,
                            TenantId = 3
                        });
                });

            modelBuilder.Entity("LandingPage.API.Data.Tenant", b =>
                {
                    b.Property<int>("TenantId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("TenantId"), 1L, 1);

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<string>("TenantName")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Url")
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.HasKey("TenantId");

                    b.ToTable("Tenants");

                    b.HasData(
                        new
                        {
                            TenantId = 1,
                            IsActive = true,
                            TenantName = "Tenant1",
                            Url = "tenant1url.no/activate"
                        },
                        new
                        {
                            TenantId = 2,
                            IsActive = true,
                            TenantName = "Tenant2",
                            Url = "tenant2url.no/activate"
                        },
                        new
                        {
                            TenantId = 3,
                            IsActive = true,
                            TenantName = "Tenant3",
                            Url = "tenant3url.no/activate"
                        });
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
                            ConcurrencyStamp = "905e435a-b04b-495a-9738-82824c9194ff",
                            Name = "Admin",
                            NormalizedName = "ADMIN"
                        },
                        new
                        {
                            Id = "a5c6115c-a79d-444a-b92a-2f4496e2f175",
                            ConcurrencyStamp = "e69ff015-cdf8-4f80-85d6-dc7dff90a081",
                            Name = "Merchant",
                            NormalizedName = "MERCHANT"
                        },
                        new
                        {
                            Id = "ebef473b-b328-426b-b5b7-40008974384c",
                            ConcurrencyStamp = "5d2da787-eb61-4d04-b967-0fbb95c94555",
                            Name = "Tenant",
                            NormalizedName = "TENANT"
                        },
                        new
                        {
                            Id = "9e229e60-a76b-4088-a262-bfa9d8e1a6cd",
                            ConcurrencyStamp = "ef4651e4-582c-476a-a3c7-15e0a0dc3bc5",
                            Name = "NewTenant",
                            NormalizedName = "NEWTENANT"
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

            modelBuilder.Entity("ApplicationUserGroup", b =>
                {
                    b.HasOne("LandingPage.API.Data.Group", null)
                        .WithMany()
                        .HasForeignKey("GroupsGroupId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("LandingPage.API.Data.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UsersId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("LandingPage.API.Data.GroupTenant", b =>
                {
                    b.HasOne("LandingPage.API.Data.Group", "Group")
                        .WithMany("GroupTenants")
                        .HasForeignKey("GroupId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("LandingPage.API.Data.Tenant", "Tenant")
                        .WithMany("GroupTenants")
                        .HasForeignKey("TenantId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Group");

                    b.Navigation("Tenant");
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

            modelBuilder.Entity("LandingPage.API.Data.Group", b =>
                {
                    b.Navigation("GroupTenants");
                });

            modelBuilder.Entity("LandingPage.API.Data.Tenant", b =>
                {
                    b.Navigation("GroupTenants");
                });
#pragma warning restore 612, 618
        }
    }
}