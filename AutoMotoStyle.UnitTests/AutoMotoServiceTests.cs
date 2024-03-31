using AutoMotoStyle.Core.Contracts;
using AutoMotoStyle.Core.Services;
using AutoMotoStyle.Infrastructure.Data;
using AutoMotoStyle.Infrastructure.Data.Common;
using AutoMotoStyle.Infrastructure.Data.Models;
using Microsoft.EntityFrameworkCore;


namespace AutoMotoStyle.UnitTests
{
    [TestFixture]
    public class AutoMotoServiceTests
    {
        private IRepository repo;
        private IServiceModel serviceModel;
        private ApplicationDbContext applicationDbContext;

        [SetUp]
        public void Setup()
        {
            var contextOptions = new DbContextOptionsBuilder<ApplicationDbContext>()
                .UseInMemoryDatabase("ServiceDataBase")
                .Options;

            applicationDbContext = new ApplicationDbContext(contextOptions);

            applicationDbContext.Database.EnsureDeleted();
            applicationDbContext.Database.EnsureCreated();
        }


        [Test]
        public async Task Test_ServiceDetailsById()
        {

            var repo = new Repository(applicationDbContext);
            serviceModel = new ServiceModel(repo);

            var exist = await serviceModel.ServiceDetailsById(2);

            Assert.That(exist.Name, Is.EqualTo("Car repair and service"));
            Assert.That(exist.Name, Is.Not.EqualTo("Car washing"));
            Assert.That(exist.Id, Is.Not.EqualTo(3));

        }



        [Test]
        public async Task Test_AllServices()
        {

            var repo = new Repository(applicationDbContext);
             serviceModel = new ServiceModel(repo);

            await repo.AddRangeAsync(new List<Service>()
            {
                new Service() { Id = 23, Name = "", Description="",   ImageUrl = "" },
                new Service() { Id = 14, Name = "", Description="",   ImageUrl = "" },
                new Service() { Id = 9,  Name = "", Description="",   ImageUrl = "" }
              
            });

            await repo.SaveChangesAsync();
            var serviceCollection = await serviceModel.AllServices();

            Assert.That(7, Is.EqualTo(serviceCollection.Count()));
            Assert.That(serviceCollection.Any(h => h.Id == 23), Is.True);

        }

        [TearDown]
        public void TearDown()
        {
            applicationDbContext.Dispose();
        }

    }
}




