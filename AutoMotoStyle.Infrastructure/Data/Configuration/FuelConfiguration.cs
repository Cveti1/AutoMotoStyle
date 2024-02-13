using AutoMotoStyle.Infrastructure.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AutoMotoStyle.Infrastructure.Data.Configuration
{
    internal class FuelConfiguration : IEntityTypeConfiguration<Fuel>
    {
        public void Configure(EntityTypeBuilder<Fuel> builder)
        {
            builder.HasData(CreateFuel());
        }

        private List<Fuel> CreateFuel()
        {
            List<Fuel> fuels = new List<Fuel>()
            {
                new Fuel()
                {
                    Id = 1,
                    FuelName = "Gasoline"
                },

                new Fuel()
                {
                    Id = 2,
                    FuelName = "Diesel"
                },

                new Fuel()
                {
                    Id = 3,
                    FuelName = "Hybrid"
                },

                 new Fuel()
                {
                    Id = 4,
                    FuelName = "Electric"
                },


             };

            return fuels;
        }
    }
}
