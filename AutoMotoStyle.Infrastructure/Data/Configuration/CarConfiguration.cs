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
                      Description = "Engine 2.0L TFSI with a power of 223 hp, 4x4 drive.\r\nEquipment:\r\nBrown leather interior, Navigation system, Climatronic\r\nFront seat adjustment, Front seat heating, Steering wheel adjustment, Heated mirrors, Stability control",
                      ImageUrl = "https://k-vod.uecdn.es/html5/html5lib/v2.89.0_ue/modules/KalturaSupport/thumbnail.php/p/110/uiconf_id/14969339/entry_id/0_bw4limh9/height/407?",
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
                      ImageUrl = "https://www.google.com/url?sa=i&url=https%3A%2F%2Fwww.edmunds.com%2Fchevrolet%2Fcorvette%2F2007%2Freview%2F&psig=AOvVaw0nLAtQV-k00a0Wrn96Ppa8&ust=1708081842154000&source=images&cd=vfe&opi=89978449&ved=0CBMQjRxqFwoTCKD64-2arYQDFQAAAAAdAAAAABAE",
                      Price = 44000.00M,
                      TransmissionId=3,
                      TypeId = 1,
                      DealerId = 1,
                      RenterId = "f2f07383-6973-4a6a-bbf7-42bf2e81027b"
                 },
                new Car()
                 {
                      Id = 3,
                      Brand = "SKODA",
                      Model = "SUPERB",
                      Year = 2018,
                      FuelId = 2,
                      Description = "Engine 2.0L TDI with a power of 190 hp. with. , aluminum rims.\r\nChassis number: TMB1JCNP2H7544236, with registration.\r\nEquipment:\r\nLeather interior, Navigation system, Front and rear parking sensors, Heated mirrors, LED brake lights",
                      ImageUrl = "https://www.google.com/url?sa=i&url=https%3A%2F%2Fes.3dexport.com%2F3dmodel-skoda-superb-2018-180246.htm&psig=AOvVaw1MN--ZSNExuvblWQXgnz5d&ust=1708082234604000&source=images&cd=vfe&opi=89978449&ved=0CBMQjRxqFwoTCJjrm6mcrYQDFQAAAAAdAAAAABAJ",
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





