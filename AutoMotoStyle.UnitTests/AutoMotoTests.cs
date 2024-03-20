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
using System.Runtime.ConstrainedExecution;
using AutoMotoStyle.Core.Models.Dealer;


namespace AutoMotoStyle.UnitTests
{
    [TestFixture]
    public class AutoMotoTests
    {
        private  IRepository repo;
        private  ILogger<CarService>logger;
        private  ICarService carService;
        private  IDealerService dealerService;
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

            var newCar = await carService.Create(new CarModel()
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

            Assert.That(newCar.Equals(3), Is.False);
           
            
            
  }

        [Test]
        public async Task Test_GetCarTypeId()
        {
            var loggerMock = new Mock<ILogger<CarService>>();
            logger = loggerMock.Object;
            var repo = new Repository(applicationDbContext);
            carService = new CarService(repo, logger);

            var carType = await carService.GetCarTypeId(1);
            Assert.That(carType.Equals(1), Is.True);
            Assert.That(carType.Equals(3), Is.False);
        }

        [Test]
        public async Task Test_GetCarTransmissionId()
        {
            var loggerMock = new Mock<ILogger<CarService>>();
            logger = loggerMock.Object;
            var repo = new Repository(applicationDbContext);
            carService = new CarService(repo, logger);

            var carTransmission = await carService.GetCarTransmissionId(2);
            Assert.That(carTransmission.Equals(3), Is.True);
            Assert.That(carTransmission.Equals(1), Is.False);
        }

        [Test]
        public async Task Test_GetCarFuelId()
        {
            var loggerMock = new Mock<ILogger<CarService>>();
            logger = loggerMock.Object;
            var repo = new Repository(applicationDbContext);
            carService = new CarService(repo, logger);

            var carFuel = await carService.GetCarFuelId(3);
            Assert.That(carFuel.Equals(2), Is.True);
            Assert.That(carFuel.Equals(1), Is.False);
        }

        [Test]
        public async Task Test_AllTypesName()
        {
            var loggerMock = new Mock<ILogger<CarService>>();
            logger = loggerMock.Object;
            var repo = new Repository(applicationDbContext);
            carService = new CarService(repo, logger);

            var typeNames = await carService.AllTypesNames();
            Assert.That(typeNames.Count(), Is.EqualTo(4));
            Assert.That(typeNames.Count(), Is.Not.EqualTo(3));

        }

        [Test]
        public async Task Test_ExistCarId()
        {
            var loggerMock = new Mock<ILogger<CarService>>();
            logger = loggerMock.Object;
            var repo = new Repository(applicationDbContext);
            carService = new CarService(repo, logger);

            var exist_first = await carService.Exists(2);
            Assert.That(exist_first, Is.True );

            var exist_second = await carService.Exists(4);
            Assert.That(exist_second, Is.False);
        }

        [Test]
        public async Task Test_HasDealerWithId()

        {
            var loggerMock = new Mock<ILogger<CarService>>();
            logger = loggerMock.Object;
            var repo = new Repository(applicationDbContext);
            carService = new CarService(repo, logger);

            var existId = await carService.HasDealerWithId(2, "1");
            Assert.That(existId, Is.False);
        }

        [Test]
        public async Task Test_IsRentedByUserWithId()
        {
            var loggerMock = new Mock<ILogger<CarService>>();
            logger = loggerMock.Object;
            var repo = new Repository(applicationDbContext);
            carService = new CarService(repo, logger);

            var existId = await carService.IsRentedByUserWithId(1, "1");
            Assert.That(existId, Is.False);

        }

        [Test]
        public async Task Test_IsRented()
        {
            var loggerMock = new Mock<ILogger<CarService>>();
            logger = loggerMock.Object;
            var repo = new Repository(applicationDbContext);
            carService = new CarService(repo, logger);

            var existId_1 = await carService.IsRented(2);
            Assert.That(existId_1, Is.True);

            var existId_2 = await carService.IsRented(3);
            Assert.That(existId_2, Is.False);

        }

        [Test]
        public async Task Test_Rent()
        {
            var loggerMock = new Mock<ILogger<CarService>>();
            logger = loggerMock.Object;
            var repo = new Repository(applicationDbContext);
            carService = new CarService(repo, logger);


            await carService.Rent(1, "1");
            await repo.SaveChangesAsync();

            var newCar = carService.IsRented(1);
            Assert.That(newCar.Id==3, Is.False);
        }

        
        [Test]
        public async Task Test_Leave()
        {
            var loggerMock = new Mock<ILogger<CarService>>();
            logger = loggerMock.Object;
            var repo = new Repository(applicationDbContext);
            carService = new CarService(repo, logger);

            var leavedCar = carService.Leave(3);
            Assert.That(leavedCar.Id == 3, Is.False);

        }

        [Test]
        public async Task Test_Delete()
        {
            var loggerMock = new Mock<ILogger<CarService>>();
            logger = loggerMock.Object;
            var repo = new Repository(applicationDbContext);
            carService = new CarService(repo, logger);

            var deletedCar = carService.Delete(3);

            await repo.SaveChangesAsync();
            
            Assert.That(deletedCar.Id==3, Is.False);

        }

        [Test]
        public async Task Test_CarDetailsById()
        {
            var loggerMock = new Mock<ILogger<CarService>>();
            logger = loggerMock.Object;
            var repo = new Repository(applicationDbContext);
            carService = new CarService(repo, logger);

            var exist = await carService.CarDetailsById(2); 
            
            Assert.That(exist.Brand, Is.EqualTo("CHEVROLET"));
            Assert.That(exist.Model, Is.Not.EqualTo("SUPERB"));
            Assert.That(exist.Id, Is.Not.EqualTo(3));

        }

        [Test]
        public async Task Test_AllCarsByDealerId()
        {
            var loggerMock = new Mock<ILogger<CarService>>();
            logger = loggerMock.Object;
            var repo = new Repository(applicationDbContext);
            carService = new CarService(repo, logger);

            var existCars = await carService.AllCarsByDealerId(1);
            Assert.That(existCars.Count(), Is.EqualTo(3));

        }

        [Test]
        public async Task Test_AllCarsByUsarId()
        {
            var loggerMock = new Mock<ILogger<CarService>>();
            logger = loggerMock.Object;
            var repo = new Repository(applicationDbContext);
            carService = new CarService(repo, logger);

            var existCars = await carService.AllCarsByUsarId("1");
            Assert.That(existCars.Count(), Is.EqualTo(0));
            Assert.That(existCars.Count(), Is.Not.EqualTo(3));
        

        }

        

        [TearDown]
          public void TearDown()
          {
            applicationDbContext.Dispose();
          }
        
    }
}