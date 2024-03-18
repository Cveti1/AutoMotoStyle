using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMotoStyle.Core.Contracts;
using AutoMotoStyle.Core.Models.Car;
using AutoMotoStyle.Core.Services;
using AutoMotoStyle.Infrastructure.Data;
using AutoMotoStyle.Infrastructure.Data.Common;
using AutoMotoStyle.Infrastructure.Data.Models;
using AutoMotoStyle.Infrastructure.Migrations;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Moq;

namespace AutoMotoStyle.UnitTests
{
    [TestFixture]
    public class AutoMotoDealerTests
    {
        private IRepository repo;
        private ILogger<CarService> logger;
        private ICarService carService;
        private IDealerService dealerService;
        private ApplicationDbContext applicationDbContext;

        [SetUp]
        public void Setup()
        {
            var contextOptions = new DbContextOptionsBuilder<ApplicationDbContext>()
                                     .UseInMemoryDatabase("DealerDataBase")
                                     .Options;

            applicationDbContext = new ApplicationDbContext(contextOptions);

            applicationDbContext.Database.EnsureDeleted();
            applicationDbContext.Database.EnsureCreated();
        }


        [Test]
        public async Task Test_ExistDealerId()
        {
         
            var repo = new Repository(applicationDbContext);
          
            dealerService = new DealerService(repo);
            var exist = await dealerService.ExistsById("3");
           
           Assert.That(exist, Is.False);

        }

        [Test]
        public async Task Test_GetDealerId()
        {
            var loggerMock = new Mock<ILogger<CarService>>();
            logger = loggerMock.Object;
            var repo = new Repository(applicationDbContext);
            dealerService = new DealerService(repo);


           
            var dealerId = await dealerService.GetDealerId("3");
               Assert.That(dealerId, Is.EqualTo((0)));

    
        }
        /*

        [Test]
        public async Task Test_CreateDealer()
        {
            var loggerMock = new Mock<ILogger<CarService>>();
            logger = loggerMock.Object;
            var repo = new Repository(applicationDbContext);
            dealerService = new DealerService(repo);


            var dealerCar = await dealerService.Create(new Dealer("5", "new", "0123456789");
          


            var dealer = new Dealer()
            {
                UserId = "5",
                DealerName = "new dealer",
                PhoneNumber = "0123456789"
            };

            await repo.SaveChangesAsync();

            var countDealers = repo.AllReadonly<Dealer>().Count();

            Assert.That(countDealers, Is.Not.EqualTo(4));
            Assert.That(dealer.Equals(1), Is.False);




        }


        */




        [TearDown]
        public void TearDown()
        {
            applicationDbContext.Dispose();
        }

    }
}
