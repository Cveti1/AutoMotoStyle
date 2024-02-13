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
                DealerName = "dealer1",
                PhoneNumber = "+359123456789"
                // UserId = "dea12856-c198-4129-b3f3-b893d8395082"
            }); ;
        }
    }
}

