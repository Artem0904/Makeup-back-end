﻿// <auto-generated />
using System;
using DataAccess;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace DataAccess.Migrations
{
    [DbContext(typeof(MakeupDbContext))]
    partial class MakeupDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.7")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("DataAccess.Data.Entities.Brand", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.HasKey("Id");

                    b.ToTable("Brands");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Chanel"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Dior"
                        });
                });

            modelBuilder.Entity("DataAccess.Data.Entities.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.HasKey("Id");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Perfumes"
                        });
                });

            modelBuilder.Entity("DataAccess.Data.Entities.Gender", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.HasKey("Id");

                    b.ToTable("Genders");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Female"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Male"
                        });
                });

            modelBuilder.Entity("DataAccess.Data.Entities.Order", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("TotalPrice")
                        .HasColumnType("int");

                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("DataAccess.Data.Entities.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("BrandId")
                        .HasColumnType("int");

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .HasMaxLength(2000)
                        .HasColumnType("nvarchar(2000)");

                    b.Property<int>("Discount")
                        .HasColumnType("int");

                    b.Property<int>("GenderId")
                        .HasColumnType("int");

                    b.Property<string>("Image")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<int>("Price")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("BrandId");

                    b.HasIndex("CategoryId");

                    b.HasIndex("GenderId");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            BrandId = 1,
                            CategoryId = 1,
                            Description = "",
                            Discount = 0,
                            GenderId = 2,
                            Image = "data:image/webp;base64,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",
                            Name = "Chanel Bleu de Chanel Parfum",
                            Price = 12592
                        });
                });

            modelBuilder.Entity("DataAccess.Data.Entities.User", b =>
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

                    b.Property<int>("UserTypeId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.HasIndex("UserTypeId");

                    b.ToTable("AspNetUsers", (string)null);
                });

            modelBuilder.Entity("DataAccess.Data.Entities.UserType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.HasKey("Id");

                    b.ToTable("UserTypes");
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
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

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

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

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

            modelBuilder.Entity("OrderProduct", b =>
                {
                    b.Property<int>("OrdersId")
                        .HasColumnType("int");

                    b.Property<int>("ProductsId")
                        .HasColumnType("int");

                    b.HasKey("OrdersId", "ProductsId");

                    b.HasIndex("ProductsId");

                    b.ToTable("OrderProduct");
                });

            modelBuilder.Entity("DataAccess.Data.Entities.Order", b =>
                {
                    b.HasOne("DataAccess.Data.Entities.User", "User")
                        .WithMany("Orders")
                        .HasForeignKey("UserId");

                    b.Navigation("User");
                });

            modelBuilder.Entity("DataAccess.Data.Entities.Product", b =>
                {
                    b.HasOne("DataAccess.Data.Entities.Brand", "Brand")
                        .WithMany("Products")
                        .HasForeignKey("BrandId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DataAccess.Data.Entities.Category", "Category")
                        .WithMany("Products")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DataAccess.Data.Entities.Gender", "Gender")
                        .WithMany("Products")
                        .HasForeignKey("GenderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Brand");

                    b.Navigation("Category");

                    b.Navigation("Gender");
                });

            modelBuilder.Entity("DataAccess.Data.Entities.User", b =>
                {
                    b.HasOne("DataAccess.Data.Entities.UserType", "UserType")
                        .WithMany("Users")
                        .HasForeignKey("UserTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("UserType");
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
                    b.HasOne("DataAccess.Data.Entities.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("DataAccess.Data.Entities.User", null)
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

                    b.HasOne("DataAccess.Data.Entities.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("DataAccess.Data.Entities.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("OrderProduct", b =>
                {
                    b.HasOne("DataAccess.Data.Entities.Order", null)
                        .WithMany()
                        .HasForeignKey("OrdersId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DataAccess.Data.Entities.Product", null)
                        .WithMany()
                        .HasForeignKey("ProductsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("DataAccess.Data.Entities.Brand", b =>
                {
                    b.Navigation("Products");
                });

            modelBuilder.Entity("DataAccess.Data.Entities.Category", b =>
                {
                    b.Navigation("Products");
                });

            modelBuilder.Entity("DataAccess.Data.Entities.Gender", b =>
                {
                    b.Navigation("Products");
                });

            modelBuilder.Entity("DataAccess.Data.Entities.User", b =>
                {
                    b.Navigation("Orders");
                });

            modelBuilder.Entity("DataAccess.Data.Entities.UserType", b =>
                {
                    b.Navigation("Users");
                });
#pragma warning restore 612, 618
        }
    }
}
