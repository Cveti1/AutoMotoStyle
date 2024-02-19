using AutoMotoStyle.Core.Contracts;
using AutoMotoStyle.Core.Models.Car;
using AutoMotoStyle.Infrastructure.Data.Common;
using AutoMotoStyle.Infrastructure.Data.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoMotoStyle.Core.Services
{
    public class CarService : ICarService
    {

        private readonly IRepository repo;

        public CarService(IRepository _repo)
        {
            repo = _repo;
        }
        public async Task<IEnumerable<CarHomePageModel>> HomePageCars()
        {
                return await repo.AllReadonly<Car>()                   
                    .OrderByDescending(h => h.Id)
                    .Select(h => new CarHomePageModel()
                    {
                        Id = h.Id,
                        Brand = h.Brand,
                        Model = h.Model,                        
                        Year = h.Year,                        
                        //ImageUrl = h.ImageUrl,
                        Description = h.Description
                    })
                    .Take(5)
                    .ToListAsync();
            
        }
    }
}

