using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;


namespace AutoMotoStyle.Infrastructure.Data.Configuration
{
    internal class TypeConfiguration : IEntityTypeConfiguration<Models.Type>
    {
        public void Configure(EntityTypeBuilder<Models.Type> builder)
        {
            builder.HasData(CreateType());
        }

        private List<Models.Type> CreateType()
        {
            List<Models.Type> types = new List<Models.Type>()
            {
                new Models.Type()
                {
                    Id = 1,
                    TypeName = "Single Car" 
               
                },

                new Models.Type()
                {
                    Id = 2,
                    TypeName = "Bus"

                },

                new Models.Type()
                {
                    Id = 3,
                    TypeName = "Jeep"
                },

                new Models.Type()
                {
                    Id = 4,
                    TypeName = "Motorcycle"
                }

             };

            return types;
        }
    }
}

