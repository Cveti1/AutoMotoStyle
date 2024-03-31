using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
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
                      Description = "Engine 2.0L TFSI with a power of 223 hp, 4x4 drive. Equipment:Brown leather interior, Navigation system, Climatronic. Front seat adjustment, Front seat heating, Steering wheel adjustment, Heated mirrors, Stability control.",
                      ImageUrl = "https://www.coches.com/fotos_historicas/audi/A3-Sedan-2.0-TDI-Quattro-S-Line-2016/audi_a3-sedan-2-0-tdi-quattro-s-line-2016_r14.jpg",
                      Price = 1300.00M,
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
                      Description = "7.0L V8 E-Force Supercharged engine with 730 hp, tire size P275/35ZR18; P325/30ZR19, alloy wheels  Edelbrok - screw compressor, installed in a tuning studio in Germany, chassis number: 1G1YY26E075126150.",
                      ImageUrl = "https://cdn.dealeraccelerate.com/pjs/1/456/13143/1920x1440/2007-chevrolet-corvette-z06-procharged.webp",
                      Price = 1500.00M,
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
                      Description = "Engine 2.0L TDI with a power of 190 hp. with. , aluminum rims.Chassis number: TMB1JCNP2H7544236, with registration. Equipment:Leather interior, Navigation system, Front and rear parking sensors, Heated mirrors, LED brake lights.",
                      ImageUrl = "https://img.indianautosblog.com/resize/750x-/2017/10/2018-Skoda-Superb-facelift-rendering-front-three-quarters.jpg",
                      Price = 1400.00M,
                      TransmissionId=2,
                      TypeId = 1,
                      DealerId = 1                      
                 },
                new Car()
                {
                    Id = 4,
                    Brand = "TOYOTA",
                    Model = "LAND CRUISER",
                    Year = 2024,
                    FuelId = 4,
                    Description = "The Toyota Land Cruiser SUV is a high-performance vehicle. It comes with a turbocharged 2.4-liter four-cylinder engine. The power plant makes 326 horsepower and 465 pound-feet of torque compared to the 381 hp and 401 lb-ft from the old V8. And it can tow up to 6,000 pounds.",
                    ImageUrl = "https://carnovo.com/wp-content/uploads/2023/12/toyota-land-cruiser-2024-1200x900.jpg",
                    Price = 2000.00M,
                    TransmissionId=1,
                    TypeId = 3,
                    DealerId = 1
                },
                new Car()
                {
                    Id = 5,
                    Brand = "HONDA",
                    Model = "REBEL",
                    Year = 2023,
                    FuelId = 1,
                    Description = "Punchy maximum torque of 43.3Nm torque @ 6,000rpm combines with peak power of 34kW @ 8,500rpm. It's a power unit that strikes a great balance between physical size and flexible output. Bore and stroke is set at 67mm x 66.8mm with compression ratio of 10.7:1.",
                    ImageUrl = "https://silesmotos.com/img/cms/Motos/HONDA/500-cmx-2023/c4%20(2).png",
                    Price = 1900.00M,
                    TransmissionId=3,
                    TypeId = 4,
                    DealerId = 1
                },
                new Car()
                {
                    Id = 6,
                    Brand = "FIAT",
                    Model = "DUCATO",
                    Year = 2020,
                    FuelId = 3,
                    Description = "It is characterized by strength and low consumption. It is articulated around a 2.3 engine\nWith a new variable geometry turbocharger, among other things, the access mechanic increases its power and torque by 10% compared to the previous 2.0. Probably the most sought after is the 140 HP...or 160, which boasts a specific engine shaft with large bearings, special pistons and a specific turbocharger.",
                    ImageUrl = "https://www.fiatprofessional.com/content/dam/fiatprofessional/cross/news/details/Ducato-MY2020/fiatprofessional-ducato-grey-commercial-vehicle-mobile-626x386.jpg",
                    Price = 2400.00M,
                    TransmissionId=2,
                    TypeId = 2,
                    DealerId = 1
                }
            };

            return cars;
        }
    }
}





