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

    }
}
