using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using AutoMotoStyle.Infrastructure.Data.Models;

namespace AutoMotoStyle.Infrastructure.Data.Configuration
{
    internal class DealerConfiguration : IEntityTypeConfiguration<Dealer>
    {
        public void Configure(EntityTypeBuilder<Dealer> builder)
        {
            builder.HasData(new Dealer()
            {
                Id = 1,
                DealerName = "dealer",
                PhoneNumber = "+359123456789",
                UserId = "dealer-7-4421-47c0-a9ba-38b9a5ddb357"
            }); 
        }
    }
}

