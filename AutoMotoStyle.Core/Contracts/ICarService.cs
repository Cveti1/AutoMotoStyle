using AutoMotoStyle.Core.Models.Car;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoMotoStyle.Core.Contracts
{
    public interface ICarService 
    {
        Task<IEnumerable<CarHomePageModel>> HomePageCars();
        Task<IEnumerable<CarTypeModel>> AllTypes();
        Task<IEnumerable<CarFuelModel>> AllFuels();
        Task<IEnumerable<CarTransmissionModel>> AllTransmissions();
        Task<bool> TypeExist(int typeId);
        Task<bool> TransmissionExist(int transmissionId);
        Task<bool> FuelExist(int fuelId);
        Task<int> Create(CarModel model, int dealerId);
        
        Task<CarsQueryModel> All(
            string? type = null,            
            string? searchTerm = null,
            Sorting sorting = Sorting.Newest,
            int currentPage = 1,
            int carsPerPage = 1);

        Task<IEnumerable<string>> AllTypesNames();

      //  Task<IEnumerable<HouseServiceModel>> AllHousesByAgentId(int id);

       // Task<IEnumerable<HouseServiceModel>> AllHousesByUserId(string userId);

        //Task<HouseDetailsModel> HouseDetailsById(int id);

       // Task<bool> Exists(int id);

       // Task Edit(int houseId, HouseModel model);

      //  Task<bool> HasAgentWithId(int houseId, string currentUserId);

       // Task<int> GetHouseCategoryId(int houseId);

       // Task Delete(int houseId);

       // Task<bool> IsRented(int houseId);

       // Task<bool> IsRentedByUserWithId(int houseId, string currentUserId);

       // Task Rent(int houseId, string currentUserId);

       // Task Leave(int houseId);

    }
}
