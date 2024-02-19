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

    }
}
