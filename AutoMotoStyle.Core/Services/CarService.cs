using AutoMotoStyle.Core.Contracts;
using AutoMotoStyle.Core.Models.Car;
using AutoMotoStyle.Core.Models.Dealer;
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

       // public async Task<bool> FuelExist(int fuelId)
       // {
          //  return await repo.AllReadonly<Fuel>()
        //        .AnyAsync(t => t.Id == fuelId);
        //}

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

     //   public async Task<bool> TransmissionExist(int transmissionId)
      //  {
       //     return await repo.AllReadonly<Transmission>()
       //        .AnyAsync(t => t.Id == transmissionId);
       // }

     //   public async Task<bool> TypeExist(int typeId)
      //  {
       //     return await repo.AllReadonly<Type>()
        //       .AnyAsync(t => t.Id == typeId);
       // }

        public async Task<IEnumerable<CarServiceModel>> AllCarsByDealerId(int id)
        {
            return await repo.AllReadonly<Car>()
                .Where(c => c.IsActive)
                .Where(c => c.DealerId == id)
                .Select(c => new CarServiceModel()
                {
                    Id = c.Id,
                    Brand = c.Brand,
                    Model = c.Model,
                    Description = c.Description,
                    Price = c.Price,
                    Year = c.Year,
                    ImageUrl = c.ImageUrl,
                    IsRented = c.RenterId != null                    
                })
                .ToListAsync();
        }

        public async Task<IEnumerable<CarServiceModel>> AllCarsByUsarId(string userId)
        {
            return await repo.AllReadonly<Car>()
               .Where(c => c.RenterId == userId)
               .Where(c => c.IsActive)
               .Select(c => new CarServiceModel()
               {
                   Id = c.Id,
                   Brand = c.Brand,
                   Model = c.Model,
                   Description = c.Description,
                   Price = c.Price,
                   Year = c.Year,
                   ImageUrl = c.ImageUrl,
                   IsRented = c.RenterId != null
               })
               .ToListAsync();
        }

        public async Task<CarDetailsModel> CarDetailsById(int id)
        {
            return await repo.AllReadonly<Car>()
                .Where(h => h.IsActive)
                .Where(h => h.Id == id)
                .Select(h => new CarDetailsModel()
                {
                    Id = id,
                    Brand = h.Brand,
                    Model = h.Model,                 
                    Year = h.Year,
                    Description = h.Description,
                    Type = h.Type.TypeName,
                    Fuel = h.Fuel.FuelName,
                    Transmission = h.Transmission.Name,
                    ImageUrl = h.ImageUrl,
                    IsRented = h.RenterId != null,
                    Price = h.Price,                    
                    Dealer = new DealerServiceModel()
                    {
                        Name = h.Dealer.User.UserName,
                        PhoneNumber = h.Dealer.PhoneNumber
                    }

                })
                .FirstAsync();
        }

        public async Task<bool> Exists(int id)
        {
            return await repo.AllReadonly<Car>()
                .AnyAsync(h => h.Id == id && h.IsActive);
        }

        public async Task Edit(int carId, CarModel model)
        {
            var car = await repo.GetByIdAsync<Car>(carId);

            car.Brand = model.Brand;
            car.Model = model.Model;
            car.Year = model.Year;
            car.Description = model.Description;            
            car.ImageUrl = model.ImageUrl;            
            car.Price = model.Price;
            car.TypeId = model.TypeId;
            car.FuelId = model.FuelId;
            car.TransmissionId = model.TransmissionId;          
          
            await repo.SaveChangesAsync();
        }

        public async Task<bool> HasDealerWithId(int carId, string currentUserId)
        {
            bool result = false;
            var car = await repo.AllReadonly<Car>()
                .Where(h => h.IsActive)
                .Where(h => h.Id == carId)
                .Include(h => h.Dealer)
                .FirstOrDefaultAsync();

            if (car?.Dealer != null && car.Dealer.UserId == currentUserId)
            {
                result = true;
            }

            return result;
        }

        public async Task<int> GetCarTypeId(int carId)
        {
            return (await repo.GetByIdAsync<Car>(carId)).TypeId;
        }

        public async Task<int> GetCarFuelId(int carId)
        {
            return (await repo.GetByIdAsync<Car>(carId)).FuelId;
        }

        public async Task<int> GetCarTransmissionId(int carId)
        {
            return (await repo.GetByIdAsync<Car>(carId)).TransmissionId;
        }
    }
}

