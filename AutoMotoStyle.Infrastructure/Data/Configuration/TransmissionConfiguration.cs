using AutoMotoStyle.Infrastructure.Data.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace AutoMotoStyle.Infrastructure.Data.Configuration
{
    internal class TransmissionConfiguration : IEntityTypeConfiguration<Transmission>
    {
        public void Configure(EntityTypeBuilder<Transmission> builder)
        {
            builder.HasData(CreateTransmission());
        }

        private List<Transmission> CreateTransmission()
        {
            List<Transmission> transmissions = new List<Transmission>()
            {
                new Transmission()
                {
                    Id = 1,
                    Name = "Automatic"
                },

                new Transmission()
                {
                    Id = 2,
                    Name = "Semi-Аutomatic"
                },

                new Transmission()
                {
                    Id = 3,
                    Name = "Manual"
                }
             };

            return transmissions;
        }
    }
}
