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
                      Brand = "Big House Marina",
                      Model = "North London, UK (near the border)",
                      Year = 1995,
                      FuelId = 1,
                      Description = "A big house for your whole family. Don't miss to buy a house with three bedrooms.",
                      ImageUrl = "https://www.luxury-architecture.net/wp-content/uploads/2017/12/1513217889-7597-FAIRWAYS-010.jpg",
                      Price = 2100.00M,
                      TransmissionId=3,
                      TypeId = 2,
                      DealerId = 1,
                      RenterId = ""
                 },
                new Car()
                 {
                      Id = 2,
                      Brand = "Big House Marina",
                      Model = "North London, UK (near the border)",
                      Year = 1995,
                      FuelId = 3,
                      Description = "A big house for your whole family. Don't miss to buy a house with three bedrooms.",
                      ImageUrl = "https://www.luxury-architecture.net/wp-content/uploads/2017/12/1513217889-7597-FAIRWAYS-010.jpg",
                      Price = 2100.00M,
                      TransmissionId=3,
                      TypeId = 1,
                      DealerId = 1,
                      RenterId = ""
                 },
                new Car()
                 {
                      Id = 3,
                      Brand = "Big House Marina",
                      Model = "North London, UK (near the border)",
                      Year = 1995,
                      FuelId = 2,
                      Description = "A big house for your whole family. Don't miss to buy a house with three bedrooms.",
                      ImageUrl = "https://www.luxury-architecture.net/wp-content/uploads/2017/12/1513217889-7597-FAIRWAYS-010.jpg",
                      Price = 2100.00M,
                      TransmissionId=3,
                      TypeId = 3,
                      DealerId = 1,
                      RenterId = ""
                 }
            };

            return cars;
        }
    }
}





