using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMotoStyle.Infrastructure.Data.Models;

namespace AutoMotoStyle.Infrastructure.Data.Configuration
{
    internal class CarConfiguration : IEntityTypeConfiguration<Car>
    {
        public void Configure(EntityTypeBuilder<Car> builder)
        {
            builder.HasData(CreateCars());
        }

        private List<Car> CreateCars()
        {
            var cars = new List<Car>()
            {
                new Car()
                 {
                      Id = 1,
                      Brand = "AUDI",
                      Model = "A3 QUATTRO",
                      Year = 2016,
                      FuelId = 1,
                      Description = "Engine 2.0L TFSI with a power of 223 hp, 4x4 drive. Equipment:Brown leather interior, Navigation system, Climatronic. Front seat adjustment, Front seat heating, Steering wheel adjustment, Heated mirrors, Stability control",
                      ImageUrl = "https://www.google.com/url?sa=i&url=https%3A%2F%2Fwww.autocasion.com%2Fmarcas%2Faudi%2Fa3-compactos%2Fa3-sedan-2-0tdi-design-edition-quattro-150-4-puertas-72727&psig=AOvVaw1XJMe-aG9baMYW6MAZt9Rw&ust=1708107620224000&source=images&cd=vfe&opi=89978449&ved=0CBMQjRxqFwoTCMiN9PH6rYQDFQAAAAAdAAAAABAE",
                      Price = 23000.00M,
                      TransmissionId=1,
                      TypeId = 1,
                      DealerId = 1
                 },
                new Car()
                 {
                      Id = 2,
                      Brand = "CHEVROLET",
                      Model = "CORVETTE ZO6",
                      Year = 2007,
                      FuelId = 1,
                      Description = "7.0L V8 E-Force Supercharged engine with 730 hp, tire size P275/35ZR18; P325/30ZR19, alloy wheels. Edelbrok - screw compressor, installed in a tuning studio in Germany, chassis number: 1G1YY26E075126150.",
                      ImageUrl = "https://www.google.com/url?sa=i&url=https%3A%2F%2Fwww.pjsautoworld.com%2Fvehicles%2F487%2F2007-chevrolet-corvette-z06-procharged&psig=AOvVaw2IDhTWbbk8WPObH3y2r_Wi&ust=1708107533403000&source=images&cd=vfe&opi=89978449&ved=0CBMQjRxqFwoTCPD1vcj6rYQDFQAAAAAdAAAAABAE",
                      Price = 44000.00M,
                      TransmissionId=3,
                      TypeId = 1,
                      DealerId = 1,
                      RenterId = "guest-a5-7a9a-4ba7-8768-66ba10cd0979"
                 },
                new Car()
                 {
                      Id = 3,
                      Brand = "SKODA",
                      Model = "SUPERB",
                      Year = 2018,
                      FuelId = 2,
                      Description = "Engine 2.0L TDI with a power of 190 hp. with. , aluminum rims.Chassis number: TMB1JCNP2H7544236, with registration. Equipment:Leather interior, Navigation system, Front and rear parking sensors, Heated mirrors, LED brake lights",
                      ImageUrl = "https://www.google.com/url?sa=i&url=https%3A%2F%2Findianautosblog.com%2F2018-skoda-superb-facelift-render-p286727&psig=AOvVaw17BfdprSt_Dry886ZJKR1u&ust=1708107574130000&source=images&cd=vfe&opi=89978449&ved=0CBMQjRxqFwoTCJC59tv6rYQDFQAAAAAdAAAAABAE",
                      Price = 14000.00M,
                      TransmissionId=2,
                      TypeId = 1,
                      DealerId = 1                      
                 }
            };

            return cars;
        }
    }
}





