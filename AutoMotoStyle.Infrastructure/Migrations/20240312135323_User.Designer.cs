﻿// <auto-generated />
using System;
using AutoMotoStyle.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace AutoMotoStyle.Infrastructure.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20240312135323_User")]
    partial class User
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.27")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("AutoMotoStyle.Infrastructure.Data.Models.Car", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Brand")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("DealerId")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<int>("FuelId")
                        .HasColumnType("int");

                    b.Property<string>("ImageUrl")
                        .IsRequired()
                        .HasMaxLength(2000)
                        .HasColumnType("nvarchar(2000)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<string>("Model")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<decimal>("Price")
                        .HasPrecision(18, 2)
                        .HasColumnType("money");

                    b.Property<string>("RenterId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("TransmissionId")
                        .HasColumnType("int");

                    b.Property<int>("TypeId")
                        .HasColumnType("int");

                    b.Property<int>("Year")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("DealerId");

                    b.HasIndex("FuelId");

                    b.HasIndex("RenterId");

                    b.HasIndex("TransmissionId");

                    b.HasIndex("TypeId");

                    b.ToTable("Cars");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Brand = "AUDI",
                            DealerId = 1,
                            Description = "Engine 2.0L TFSI with a power of 223 hp, 4x4 drive. Equipment:Brown leather interior, Navigation system, Climatronic. Front seat adjustment, Front seat heating, Steering wheel adjustment, Heated mirrors, Stability control",
                            FuelId = 1,
                            ImageUrl = "https://www.coches.com/fotos_historicas/audi/A3-Sedan-2.0-TDI-Quattro-S-Line-2016/audi_a3-sedan-2-0-tdi-quattro-s-line-2016_r14.jpg",
                            IsActive = true,
                            Model = "A3 QUATTRO",
                            Price = 23000.00m,
                            TransmissionId = 1,
                            TypeId = 1,
                            Year = 2016
                        },
                        new
                        {
                            Id = 2,
                            Brand = "CHEVROLET",
                            DealerId = 1,
                            Description = "7.0L V8 E-Force Supercharged engine with 730 hp, tire size P275/35ZR18; P325/30ZR19, alloy wheels. Edelbrok - screw compressor, installed in a tuning studio in Germany, chassis number: 1G1YY26E075126150.",
                            FuelId = 1,
                            ImageUrl = "https://cdn.dealeraccelerate.com/pjs/1/456/13143/1920x1440/2007-chevrolet-corvette-z06-procharged.webp",
                            IsActive = true,
                            Model = "CORVETTE ZO6",
                            Price = 44000.00m,
                            RenterId = "guest-a5-7a9a-4ba7-8768-66ba10cd0979",
                            TransmissionId = 3,
                            TypeId = 1,
                            Year = 2007
                        },
                        new
                        {
                            Id = 3,
                            Brand = "SKODA",
                            DealerId = 1,
                            Description = "Engine 2.0L TDI with a power of 190 hp. with. , aluminum rims.Chassis number: TMB1JCNP2H7544236, with registration. Equipment:Leather interior, Navigation system, Front and rear parking sensors, Heated mirrors, LED brake lights",
                            FuelId = 2,
                            ImageUrl = "https://img.indianautosblog.com/resize/750x-/2017/10/2018-Skoda-Superb-facelift-rendering-front-three-quarters.jpg",
                            IsActive = true,
                            Model = "SUPERB",
                            Price = 14000.00m,
                            TransmissionId = 2,
                            TypeId = 1,
                            Year = 2018
                        });
                });

            modelBuilder.Entity("AutoMotoStyle.Infrastructure.Data.Models.Dealer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("DealerName")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasMaxLength(15)
                        .HasColumnType("nvarchar(15)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("Dealers");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            DealerName = "dealer",
                            PhoneNumber = "+359123456789",
                            UserId = "dealer-7-4421-47c0-a9ba-38b9a5ddb357"
                        });
                });

            modelBuilder.Entity("AutoMotoStyle.Infrastructure.Data.Models.Fuel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("FuelName")
                        .IsRequired()
                        .HasMaxLength(15)
                        .HasColumnType("nvarchar(15)");

                    b.HasKey("Id");

                    b.ToTable("Fuels");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            FuelName = "Gasoline"
                        },
                        new
                        {
                            Id = 2,
                            FuelName = "Diesel"
                        },
                        new
                        {
                            Id = 3,
                            FuelName = "Hybrid"
                        },
                        new
                        {
                            Id = 4,
                            FuelName = "Electric"
                        });
                });

            modelBuilder.Entity("AutoMotoStyle.Infrastructure.Data.Models.Transmission", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Transmissions");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Automatic"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Semi-Аutomatic"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Manual"
                        });
                });

            modelBuilder.Entity("AutoMotoStyle.Infrastructure.Data.Models.Type", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("TypeName")
                        .IsRequired()
                        .HasMaxLength(35)
                        .HasColumnType("nvarchar(35)");

                    b.HasKey("Id");

                    b.ToTable("Types");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            TypeName = "Single Car"
                        },
                        new
                        {
                            Id = 2,
                            TypeName = "Bus"
                        },
                        new
                        {
                            Id = 3,
                            TypeName = "Jeep"
                        },
                        new
                        {
                            Id = 4,
                            TypeName = "Motorcycle"
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

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUser", b =>
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
                            Id = "dealer-7-4421-47c0-a9ba-38b9a5ddb357",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "2abaf438-4f29-4bc7-a263-5d168ea331fc",
                            Email = "dealer@mail.com",
                            EmailConfirmed = false,
                            LockoutEnabled = false,
                            NormalizedEmail = "dealer@mail.com",
                            NormalizedUserName = "dealer@mail.com",
                            PasswordHash = "AQAAAAEAACcQAAAAEN2m0rVMvU4xTFwi0IscS++Y2vuhe9fP6d1ZW4CU6rO/iDtRrvl++J+N5EMV6f/PKw==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "06d6577b-b125-469a-8d63-aee56dbb06d0",
                            TwoFactorEnabled = false,
                            UserName = "dealer@mail.com"
                        },
                        new
                        {
                            Id = "guest-a5-7a9a-4ba7-8768-66ba10cd0979",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "2d81b786-2aac-415c-ac80-381961fee382",
                            Email = "guest@mail.com",
                            EmailConfirmed = false,
                            LockoutEnabled = false,
                            NormalizedEmail = "guest@mail.com",
                            NormalizedUserName = "guest@mail.com",
                            PasswordHash = "AQAAAAEAACcQAAAAEHCyCyeHEIaX7uhT4uURKDvWROlZIbpeSO7jy/xq0vnRNBeY2329npp36iPMpffHmg==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "e6b47f70-0034-4c81-ba05-7c251d631fd7",
                            TwoFactorEnabled = false,
                            UserName = "guest@mail.com"
                        });
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
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ProviderKey")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

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
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Name")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("AutoMotoStyle.Infrastructure.Data.Models.Car", b =>
                {
                    b.HasOne("AutoMotoStyle.Infrastructure.Data.Models.Dealer", "Dealer")
                        .WithMany()
                        .HasForeignKey("DealerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("AutoMotoStyle.Infrastructure.Data.Models.Fuel", "Fuel")
                        .WithMany("Cars")
                        .HasForeignKey("FuelId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", "Renter")
                        .WithMany()
                        .HasForeignKey("RenterId");

                    b.HasOne("AutoMotoStyle.Infrastructure.Data.Models.Transmission", "Transmission")
                        .WithMany("Cars")
                        .HasForeignKey("TransmissionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("AutoMotoStyle.Infrastructure.Data.Models.Type", "Type")
                        .WithMany("Cars")
                        .HasForeignKey("TypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Dealer");

                    b.Navigation("Fuel");

                    b.Navigation("Renter");

                    b.Navigation("Transmission");

                    b.Navigation("Type");
                });

            modelBuilder.Entity("AutoMotoStyle.Infrastructure.Data.Models.Dealer", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
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
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
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

                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("AutoMotoStyle.Infrastructure.Data.Models.Fuel", b =>
                {
                    b.Navigation("Cars");
                });

            modelBuilder.Entity("AutoMotoStyle.Infrastructure.Data.Models.Transmission", b =>
                {
                    b.Navigation("Cars");
                });

            modelBuilder.Entity("AutoMotoStyle.Infrastructure.Data.Models.Type", b =>
                {
                    b.Navigation("Cars");
                });
#pragma warning restore 612, 618
        }
    }
}
