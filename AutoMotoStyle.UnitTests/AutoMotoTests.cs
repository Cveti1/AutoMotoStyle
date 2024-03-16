using AutoMotoStyle.Core.Contracts;
using AutoMotoStyle.Infrastructure.Data;
using AutoMotoStyle.Infrastructure.Data.Common;
using AutoMotoStyle.Core.Services;
using Microsoft.EntityFrameworkCore;
using Moq;
using Microsoft.Extensions.Logging;
using AutoMotoStyle.Infrastructure.Data.Models;
using System;
using AutoMotoStyle.Core.Models.Car;


namespace AutoMotoStyle.UnitTests
{
    [TestFixture]
    public class AutoMotoTests
    {
        private  IRepository repo;
        private  ILogger<CarService>logger;
        private  ICarService carService;
        private ApplicationDbContext applicationDbContext;

        [SetUp]
        public void Setup()
        {
            var contextOptions = new DbContextOptionsBuilder<ApplicationDbContext>()
                                     .UseInMemoryDatabase("CarsDataBase")
                                     .Options;

            applicationDbContext = new ApplicationDbContext(contextOptions);

            applicationDbContext.Database.EnsureDeleted();
            applicationDbContext.Database.EnsureCreated();
        }

        [Test]
        public async Task Test_CarsEdit()
        {
            var loggerMock = new Mock<ILogger<CarService>>();
            logger = loggerMock.Object;
            var repo = new Repository(applicationDbContext);
            carService = new CarService(repo, logger);

            await repo.AddAsync(new Car()
            {
                Id = 15,
                Brand = "",
                Model = "",
                Year = 2015,
                Description = "",
                ImageUrl = "",
                Price = 0                
            });

            await repo.SaveChangesAsync();

            await carService.Edit(15, new CarModel()
            {
                Id = 15,
                Brand = "",
                Model = "",
                Year = 2015,
                Description = "new car",
                ImageUrl = "",
                Price = 0
            });

            var dbCar = await repo.GetByIdAsync<Car>(15);

            Assert.That(dbCar.Description, Is.EqualTo("new car"));
        }


        [Test]
        public async Task Test_HomePage()
        {
          
            var loggerMock = new Mock<ILogger<CarService>>();
            logger = loggerMock.Object;
            var repo = new Repository(applicationDbContext);
            carService = new CarService(repo, logger);

            await repo.AddRangeAsync(new List<Car>()
            {
                new Car() { Id = 23, Brand = "", Model="",  Year = 2000, ImageUrl = "",  Description = "" },
                new Car() { Id = 14, Brand = "", Model="",  Year = 2001, ImageUrl = "",  Description = "" },
                new Car() { Id = 10, Brand = "", Model="",  Year = 2002, ImageUrl = "",  Description = "" },
                new Car() { Id = 12, Brand = "", Model="",  Year = 2003, ImageUrl = "",  Description = "" }
            });

            await repo.SaveChangesAsync();
            var carCollection = await carService.HomePageCars();

            Assert.That(4, Is.EqualTo(carCollection.Count()));
            Assert.That(carCollection.Any(h => h.Id == 3), Is.False);
           
        }

        [Test]
        public async Task Test_AllFuel()
        {
            var loggerMock = new Mock<ILogger<CarService>>();
            logger = loggerMock.Object;
            var repo = new Repository(applicationDbContext);
            carService = new CarService(repo, logger);

            await repo.AddAsync(new Fuel()
            {
                Id = 6,
                FuelName = "new fuel"
            });

                 await repo.SaveChangesAsync();

            await repo.SaveChangesAsync();
            var carFuel = await carService.AllFuels();

            Assert.That(carFuel.Any(h => h.Id == 6), Is.True);

        }

        [Test]
        public async Task Test_AllTransmission()
        {
            var loggerMock = new Mock<ILogger<CarService>>();
            logger = loggerMock.Object;
            var repo = new Repository(applicationDbContext);
            carService = new CarService(repo, logger);

            await repo.AddAsync(new Transmission()
            {
                Id = 8,
                Name = "new transmission"
            });

            await repo.SaveChangesAsync();

            await repo.SaveChangesAsync();
            var carTransmission = await carService.AllTransmissions();

            Assert.That(carTransmission.Any(h => h.Id == 8), Is.True);

        }

        [Test]
        public async Task Test_AllType()
        {
            var loggerMock = new Mock<ILogger<CarService>>();
            logger = loggerMock.Object;
            var repo = new Repository(applicationDbContext);
            carService = new CarService(repo, logger);

            await repo.AddAsync(new Infrastructure.Data.Models.Type()
            {
                Id = 12,
                TypeName = "new type"
            });

            await repo.SaveChangesAsync();

            await repo.SaveChangesAsync();
            var carType = await carService.AllTypes();

            Assert.That(carType.Any(h => h.Id == 12), Is.True);
        }

        [Test]
        public async Task Test_CarCreate()
        {
            var loggerMock = new Mock<ILogger<CarService>>();
            logger = loggerMock.Object;
            var repo = new Repository(applicationDbContext);
            carService = new CarService(repo, logger);

            var allCars = await carService.Create(new CarModel()
            {
                Id = 10,
                Brand = "Kawasaki",
                Model = "",
                Description = "",
                Price = 0,
                ImageUrl = "",
                Year = 2020,
                TypeId = 1,
                TransmissionId = 2,
                FuelId = 1
            }, 2);

            await repo.SaveChangesAsync();

            Assert.That(allCars.Equals(3), Is.False);
     
        }

   //     [Test]
   //     public async Task Test_GetCarTypeId()
       // {
        //    var loggerMock = new Mock<ILogger<CarService>>();
        //    logger = loggerMock.Object;
         //   var repo = new Repository(applicationDbContext);
         //   carService = new CarService(repo, logger);

          ///  await repo.AddAsync(new Infrastructure.Data.Models.Type()
          //  {
           //     Id = 5,
            //    TypeName = "new type"
          //  });

            

         //   await repo.SaveChangesAsync();
         //   var carType = await carService.GetCarTypeId(5);

           // Assert.That(carType.Equals(5), Is.True);
            // return (await repo.GetByIdAsync<Car>(carId)).TypeId;
            //Assert.That(allCars.Equals(3), Is.False);
         //   Assert.That(carType.Any(h => h.Id == 5), Is.True);
      //  }



        [TearDown]
          public void TearDown()
          {
            applicationDbContext.Dispose();
          }
        
    }
}