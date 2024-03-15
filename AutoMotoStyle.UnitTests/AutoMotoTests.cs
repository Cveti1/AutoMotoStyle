using AutoMotoStyle.Core.Contracts;
using AutoMotoStyle.Infrastructure.Data;
using AutoMotoStyle.Infrastructure.Data.Common;
using Castle.Core.Logging;
using Microsoft.EntityFrameworkCore;
using System;


namespace AutoMotoStyle.UnitTests
{
    public class AutoMotoTests
    {
        private  IRepository repo;
        private  ILogger logger;
        private  ICarService carService;
        private ApplicationDbContext applicationDbContext;

        [SetUp]
        public void Setup()
        {
            var contextOptions = new DbContextOptionsBuilder<ApplicationDbContext>()
                                     .UseInMemoryDatabase("HouseDB")
                                     .Options;

            applicationDbContext = new ApplicationDbContext(contextOptions);

            applicationDbContext.Database.EnsureDeleted();
            applicationDbContext.Database.EnsureCreated();
        }




        [Test]
        public void Test_HomePage()
        {
          
            
            //Assert.Pass();
        }


  //      [TearDown]
      //  public void TearDown()
      //  {
      //      Assert.Pass();
      //  }
    }
}