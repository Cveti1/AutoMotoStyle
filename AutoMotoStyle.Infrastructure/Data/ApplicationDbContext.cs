using AutoMotoStyle.Infrastructure.Data;
using AutoMotoStyle.Infrastructure.Data.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

namespace AutoMotoStyle.Infrastructure.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Car> Cars { get; set; } = null!;

        public DbSet<Models.Type> Types { get; set; } = null!;
        public DbSet<Fuel> Fuels { get; set; } = null!;

        public DbSet<Dealer> Dealers { get; set; } = null!;
        public DbSet<Transmission> Transmissions { get; set; } = null!;



        protected override void OnModelCreating(ModelBuilder builder)
        {
           

            base.OnModelCreating(builder);
        }
    }
}