using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using AutoMotoStyle.Infrastructure.Data.Models;

namespace AutoMotoStyle.Infrastructure.Data.Configuration
{
    internal class DealerConfiguration : IEntityTypeConfiguration<Dealer>
    {
        public void Configure(EntityTypeBuilder<Dealer> builder)
        {
            builder.HasData(CreateDealers());
        }

        private List<Dealer> CreateDealers()
        {
            var dealers = new List<Dealer>()
            {
                new Dealer()
                {
                    Id = 1,
                    DealerName = "dealer",
                    PhoneNumber = "+359123456789",
                    UserId = "dealer-7-4421-47c0-a9ba-38b9a5ddb357"
                },

                new Dealer()
                {
                    Id = 2,
                    DealerName = "dealer2",
                    PhoneNumber = "+359987654321",
                    UserId = "dealer-2-1234-47c0-a9ba-38b9a5ddb123"
                }
            };

            return dealers;
        }


    }
}
