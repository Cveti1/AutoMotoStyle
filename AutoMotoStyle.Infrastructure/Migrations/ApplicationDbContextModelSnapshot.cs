﻿// <auto-generated />
using System;
using AutoMotoStyle.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace AutoMotoStyle.Infrastructure.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
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
                        .HasMaxLength(1000)
                        .HasColumnType("nvarchar(1000)");

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
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("TransmissionId")
                        .HasColumnType("int");

                    b.Property<int>("TypeId")
                        .HasColumnType("int");

                    b.Property<int>("Year")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("DealerId");

                    b.HasIndex("FuelId");

                    b.HasIndex("TransmissionId");

                    b.HasIndex("TypeId");

                    b.ToTable("Cars");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Brand = "AUDI",
                            DealerId = 1,
                            Description = "Engine 2.0L TFSI with a power of 223 hp, 4x4 drive. Equipment:Brown leather interior, Navigation system, Climatronic. Front seat adjustment, Front seat heating, Steering wheel adjustment, Heated mirrors, Stability control.",
                            FuelId = 1,
                            ImageUrl = "https://www.coches.com/fotos_historicas/audi/A3-Sedan-2.0-TDI-Quattro-S-Line-2016/audi_a3-sedan-2-0-tdi-quattro-s-line-2016_r14.jpg",
                            IsActive = true,
                            Model = "A3 QUATTRO",
                            Price = 1300.00m,
                            TransmissionId = 1,
                            TypeId = 1,
                            Year = 2016
                        },
                        new
                        {
                            Id = 2,
                            Brand = "CHEVROLET",
                            DealerId = 1,
                            Description = "7.0L V8 E-Force Supercharged engine with 730 hp, tire size P275/35ZR18; P325/30ZR19, alloy wheels  Edelbrok - screw compressor, installed in a tuning studio in Germany, chassis number: 1G1YY26E075126150.",
                            FuelId = 1,
                            ImageUrl = "https://cdn.dealeraccelerate.com/pjs/1/456/13143/1920x1440/2007-chevrolet-corvette-z06-procharged.webp",
                            IsActive = true,
                            Model = "CORVETTE ZO6",
                            Price = 1500.00m,
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
                            Description = "Engine 2.0L TDI with a power of 190 hp. with. , aluminum rims.Chassis number: TMB1JCNP2H7544236, with registration. Equipment:Leather interior, Navigation system, Front and rear parking sensors, Heated mirrors, LED brake lights.",
                            FuelId = 2,
                            ImageUrl = "https://img.indianautosblog.com/resize/750x-/2017/10/2018-Skoda-Superb-facelift-rendering-front-three-quarters.jpg",
                            IsActive = true,
                            Model = "SUPERB",
                            Price = 1400.00m,
                            TransmissionId = 2,
                            TypeId = 1,
                            Year = 2018
                        },
                        new
                        {
                            Id = 4,
                            Brand = "TOYOTA",
                            DealerId = 1,
                            Description = "The Toyota Land Cruiser SUV is a high-performance vehicle. It comes with a turbocharged 2.4-liter four-cylinder engine. The power plant makes 326 horsepower and 465 pound-feet of torque compared to the 381 hp and 401 lb-ft from the old V8. And it can tow up to 6,000 pounds.",
                            FuelId = 4,
                            ImageUrl = "https://carnovo.com/wp-content/uploads/2023/12/toyota-land-cruiser-2024-1200x900.jpg",
                            IsActive = true,
                            Model = "LAND CRUISER",
                            Price = 2000.00m,
                            TransmissionId = 1,
                            TypeId = 3,
                            Year = 2024
                        },
                        new
                        {
                            Id = 5,
                            Brand = "HONDA",
                            DealerId = 1,
                            Description = "Punchy maximum torque of 43.3Nm torque @ 6,000rpm combines with peak power of 34kW @ 8,500rpm. It's a power unit that strikes a great balance between physical size and flexible output. Bore and stroke is set at 67mm x 66.8mm with compression ratio of 10.7:1.",
                            FuelId = 1,
                            ImageUrl = "https://silesmotos.com/img/cms/Motos/HONDA/500-cmx-2023/c4%20(2).png",
                            IsActive = true,
                            Model = "REBEL",
                            Price = 1900.00m,
                            TransmissionId = 3,
                            TypeId = 4,
                            Year = 2023
                        },
                        new
                        {
                            Id = 6,
                            Brand = "FIAT",
                            DealerId = 1,
                            Description = "It is characterized by strength and low consumption. It is articulated around a 2.3 engine\nWith a new variable geometry turbocharger, among other things, the access mechanic increases its power and torque by 10% compared to the previous 2.0. Probably the most sought after is the 140 HP...or 160, which boasts a specific engine shaft with large bearings, special pistons and a specific turbocharger.",
                            FuelId = 3,
                            ImageUrl = "https://www.fiatprofessional.com/content/dam/fiatprofessional/cross/news/details/Ducato-MY2020/fiatprofessional-ducato-grey-commercial-vehicle-mobile-626x386.jpg",
                            IsActive = true,
                            Model = "DUCATO",
                            Price = 2400.00m,
                            TransmissionId = 2,
                            TypeId = 2,
                            Year = 2020
                        },
                        new
                        {
                            Id = 7,
                            Brand = "KAWASAKI",
                            DealerId = 1,
                            Description = "Futuristic appearance, excellent optics, digital instrument panel, adjustable suspension, sliding clutch - all this works as a single organism, at the heart of which is a 1043-cc engine with an impeccable reputation. 142 horsepower and a maximum speed of 249 km/h.",
                            FuelId = 3,
                            ImageUrl = "https://synergosmoto.com/uploaded/KWkFm67eFd.jpg",
                            IsActive = true,
                            Model = "Z1000",
                            Price = 1700.00m,
                            TransmissionId = 3,
                            TypeId = 4,
                            Year = 2021
                        },
                        new
                        {
                            Id = 8,
                            Brand = "HYUNDAI",
                            DealerId = 1,
                            Description = "The 2023 Tucson Plug-in Hybrid is a powerful, efficient, and practical crossover. The 261-hp Plug-in's extra power—74 horsepower suits its personality well. It behaves well in the curves, and the electric torque provides plenty of oomph off the line.",
                            FuelId = 3,
                            ImageUrl = "https://www.motortrend.com/uploads/2022/08/2023-Hyundai-Tucson-PHEV-Front-Three-Quarter.jpg",
                            IsActive = true,
                            Model = "TUCSON",
                            Price = 2700.00m,
                            TransmissionId = 1,
                            TypeId = 3,
                            Year = 2023
                        },
                        new
                        {
                            Id = 9,
                            Brand = "VOLKSWAGEN",
                            DealerId = 1,
                            Description = "Gasoline engine of the TSI series with a volume of 2.0 liters, power of 150 and 204 hp. It combines two technologies: direct injection and turbocharging. Fuel consumption is about 15 liters per 100 km. Length - 4904 mm, height - 1990 mm. The total number of seats when transporting people is 5 or 6 passengers.",
                            FuelId = 1,
                            ImageUrl = "https://parkers-images.bauersecure.com/wp-images/19429/12-vw-transporter-2003.jpg",
                            IsActive = true,
                            Model = "TRANSPORTER",
                            Price = 1600.00m,
                            TransmissionId = 1,
                            TypeId = 2,
                            Year = 2010
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

            modelBuilder.Entity("AutoMotoStyle.Infrastructure.Data.Models.Service", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<string>("ImageUrl")
                        .IsRequired()
                        .HasMaxLength(1000)
                        .HasColumnType("nvarchar(1000)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.ToTable("Services");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = "We offer a professional manual car wash service, often provided by someone in a mobile unit who can come to your home or workplace. They use professional products and can offer a high quality service.",
                            ImageUrl = "https://imgrabo.com/pics/deals/15898130566073.jpg",
                            Name = "Car washing"
                        },
                        new
                        {
                            Id = 2,
                            Description = "General repair, engine rebuilding or reconditioning of motor vehicles collision service such as body, frame and fender straightening and repair and painting of motor vehicles and more... Just tell us what you need...!",
                            ImageUrl = "https://www.totalcardiagnostics.com/learn/wp-content/uploads/2015/10/car-repair-770x269.jpg",
                            Name = "Car repair and service"
                        },
                        new
                        {
                            Id = 3,
                            Description = "All condition of the car or bus. Identification of the vehicle - registration numbers and documentation. Measurement of the braking system; status of brakes, parking brake and ABS. Condition of steering. Operation of all lights - lights, headlights, turn signals, gauges. Condition of electrical equipment - battery. Condition of tires, axles and suspension. Harmful effects - noise emissions exhaust. Car equipment - first aid kit, fire extinguisher, triangle, belts etc.",
                            ImageUrl = "https://www.netsuite.com/portal/assets/img/business-articles/accounting-software/social-quarterly-annual-business-reviews.jpg",
                            Name = "Annual technical inspection"
                        },
                        new
                        {
                            Id = 4,
                            Description = "Tuning of motorcycles, cars and other vehicles, means reworking and changing according to the owner's personal preferences. Mainly this can refer to optical and technical changes.\r\nTuning cars and other vehicles is fine-tuning the engine, aerodynamics or suspension to improve performance, exterior and interior aesthetics, and acoustics.",
                            ImageUrl = "https://www.gtplanet.net/wp-content/uploads/2022/10/image-6-11.jpg",
                            Name = "Тuning"
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
                            ConcurrencyStamp = "42250d4a-eab8-44c9-a3b1-ef86ffa15cf6",
                            Email = "dealer@mail.com",
                            EmailConfirmed = false,
                            LockoutEnabled = false,
                            NormalizedEmail = "dealer@mail.com",
                            NormalizedUserName = "dealer@mail.com",
                            PasswordHash = "AQAAAAEAACcQAAAAEEnvNPqB8PsZTCDHX0UmsnxN+jg6Sq5v65haN9KVHsl7DDxVQ9iHDJAAXIY0ZPaEGA==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "979e480f-9d0c-4836-aec8-c4ef365c9b42",
                            TwoFactorEnabled = false,
                            UserName = "dealer@mail.com"
                        },
                        new
                        {
                            Id = "guest-a5-7a9a-4ba7-8768-66ba10cd0979",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "a3d5fdb2-6357-44b7-9af3-8acfd5d3115e",
                            Email = "guest@mail.com",
                            EmailConfirmed = false,
                            LockoutEnabled = false,
                            NormalizedEmail = "guest@mail.com",
                            NormalizedUserName = "guest@mail.com",
                            PasswordHash = "AQAAAAEAACcQAAAAEIgFt5RIrHkoYugtQqpVT6yoxIVZmoruVmSxgtwDhHveXcbrj6mNYquYs4DUL2YR1g==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "711ee94a-bbf4-4b34-ae5e-8726753d860e",
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
