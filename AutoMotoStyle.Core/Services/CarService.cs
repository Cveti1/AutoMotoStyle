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
using Type = AutoMotoStyle.Infrastructure.Data.Models.Type;

namespace AutoMotoStyle.Core.Services
{
    public class CarService : ICarService
    {

        private readonly IRepository repo;

        public CarService(IRepository _repo)
        {
            repo = _repo;
        }

        public async Task<IEnumerable<CarFuelModel>> AllFuels()
        {
            return await repo.AllReadonly<Fuel>()
                    .OrderBy(h => h.Id)
                    .Select(h => new CarFuelModel()
                    {
                        Id = h.Id,
                        FuelName = h.FuelName
                    })
                    .ToListAsync();
        }

        public async Task<IEnumerable<CarTransmissionModel>> AllTransmissions()
        {
            return await repo.AllReadonly<Transmission>()
                    .OrderBy(h => h.Id)
                    .Select(h => new CarTransmissionModel()
                    {
                        Id = h.Id,
                        Name = h.Name
                    })
                    .ToListAsync();
        }

        public async Task<IEnumerable<CarTypeModel>> AllTypes()
        {
            return await repo.AllReadonly<Type>()
                    .OrderBy(h => h.Id)
                    .Select(h => new CarTypeModel()
                    {
                        Id = h.Id,
                        TypeName = h.TypeName
                    })
                    .ToListAsync();
        }

        public async Task<int> Create(CarModel model, int dealerId)
        {
            var car = new Car()
            {
                Brand = model.Brand,
                Model = model.Model,
                Description = model.Description,
                Price = model.Price,
                ImageUrl = model.ImageUrl,
                Year = model.Year,
                TypeId = model.TypeId,
                TransmissionId = model.TransmissionId,
                FuelId = model.FuelId,
                DealerId=dealerId
            };

            await repo.AddAsync(car);
            await repo.SaveChangesAsync();

            return car.Id;
        }

        public async Task<bool> FuelExist(int fuelId)
        {
            return await repo.AllReadonly<Fuel>()
                .AnyAsync(t => t.Id == fuelId);
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
                        ImageUrl = h.ImageUrl,
                        Description = h.Description
                    })
                    .Take(5)
                    .ToListAsync();
            
        }

        public async Task<bool> TransmissionExist(int transmissionId)
        {
            return await repo.AllReadonly<Transmission>()
               .AnyAsync(t => t.Id == transmissionId);
        }

        public async Task<bool> TypeExist(int typeId)
        {
            return await repo.AllReadonly<Type>()
               .AnyAsync(t => t.Id == typeId);
        }
    }
}

