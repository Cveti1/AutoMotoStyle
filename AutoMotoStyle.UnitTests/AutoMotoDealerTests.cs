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
            var repo = new Repository(applicationDbContext);
            dealerService = new DealerService(repo);

            var dealerId = await dealerService.GetDealerId("3");
            Assert.That(dealerId, Is.EqualTo((0)));

        }
        
        
        [Test]
        public async Task Test_CreateDealer()
        {
            var repo = new Repository(applicationDbContext);
            dealerService = new DealerService(repo);

            var newDealer = dealerService.Create("guest-a5-7a9a-4ba7-8768-66ba10cd-new",
                "newDealer", "0123456789");

            var countDealer =  repo.AllReadonly<Dealer>().Count();
            Assert.That(countDealer, Is.EqualTo(2));
        }


        [Test]
        public async Task Test_UserHasRents()
        {
            var repo = new Repository(applicationDbContext);
            dealerService = new DealerService(repo);

            var existId = await dealerService.UserHasRents("1");
            Assert.That(existId, Is.False);

        }

        
        [TearDown]
        public void TearDown()
        {
            applicationDbContext.Dispose();
        }

    }
}
