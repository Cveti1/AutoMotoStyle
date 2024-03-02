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

        public async Task<CarsQueryModel> All(
            string? type = null, 
            string? searchTerm = null, 
            Sorting sorting = Sorting.Newest, 
            int currentPage = 1, 
            int carsPerPage = 1)
        {
            var result = new CarsQueryModel();

            var cars = repo.AllReadonly<Car>()
                .Where(h => h.IsActive);

            if (string.IsNullOrEmpty(type) == false)
            {
                cars = cars
                    .Where(h => h.Type.TypeName == type);
            }

            if (string.IsNullOrEmpty(searchTerm) == false)
            {
                searchTerm = $"%{searchTerm.ToLower()}%";

                cars = cars
                    .Where(h => EF.Functions.Like(h.Brand.ToLower(), searchTerm) ||
                        EF.Functions.Like(h.Model.ToLower(), searchTerm) ||
                        EF.Functions.Like(h.Description.ToLower(), searchTerm));
            }

            //switch (sorting)
            //{
            //    case HouseSorting.Price:
            //        houses = houses
            //        .OrderBy(h => h.PricePerMonth);
            //        break;
            //    case HouseSorting.NotRentedFirst:
            //        houses = houses
            //        .OrderBy(h => h.RenterId);
            //        break;
            //    default:
            //        houses = houses.OrderByDescending(h => h.Id);
            //        break;
            //}

            cars = sorting switch
            {
               Sorting.Price => cars
                    .OrderBy(h => h.Price),
                Sorting.NotRentedFirst => cars
                    .OrderBy(h => h.RenterId),
                _ => cars.OrderByDescending(h => h.Id)
            };

            result.Cars = await cars
                .Skip((currentPage - 1) * carsPerPage)
                .Take(carsPerPage)
                .Select(h => new CarServiceModel()
                {
                    Brand = h.Brand,
                    Model = h.Model,
                    Id = h.Id,
                    ImageUrl = h.ImageUrl,
                    IsRented = h.RenterId != null,
                    Price = h.Price,
                    Description = h.Description,
                    Year = h.Year
                })
                .ToListAsync();

            result.TotalCarCount = await cars.CountAsync();

            return result;
        }

        public async Task<IEnumerable<string>> AllTypesNames()
        {
            return await repo.AllReadonly<Type>()
                .Select(c => c.TypeName)
                .Distinct()
                .ToListAsync();
        }

        public async Task<IEnumerable<CarFuelModel>> AllFuels()
        {
            return await repo.AllReadonly<Fuel>()
                    .OrderBy(h => h.FuelName)
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
                    .OrderBy(h => h.Name)
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
                    .OrderBy(h => h.TypeName)
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

