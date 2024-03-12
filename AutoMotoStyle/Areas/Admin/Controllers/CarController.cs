using AutoMotoStyle.Areas.Admin.Models;
using AutoMotoStyle.Controllers;
using AutoMotoStyle.Core.Contracts;
using AutoMotoStyle.Core.Services;
using AutoMotoStyle.Extensions;
using Microsoft.AspNetCore.Mvc;

namespace AutoMotoStyle.Areas.Admin.Controllers
{
    public class CarController : BaseController
    {
        private readonly ICarService carService;

        private readonly IDealerService dealerService;

        public CarController(
            ICarService _carService,
            IDealerService _dealerService)
        {
            carService = _carService;
            dealerService = _dealerService;
        }

         public async Task<IActionResult> Mine()
         {
            var myCars = new MyCarsViewModel();
            var adminId = User.Id();
            myCars.RentedCars = await carService.AllCarsByUsarId(adminId);
            var dealerId = await dealerService.GetDealerId(adminId);
            myCars.AddedCars = await carService.AllCarsByDealerId(dealerId);

            return View(myCars);
         }
        
    }
}

