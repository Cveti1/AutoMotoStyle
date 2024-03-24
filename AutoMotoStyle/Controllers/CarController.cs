using AutoMotoStyle.Core.Contracts;
using AutoMotoStyle.Core.Models.Car;
using AutoMotoStyle.Extensions;
using AutoMotoStyle.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Microsoft.VisualBasic;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;
using AutoMotoStyle.Core.Extensions;
using static AutoMotoStyle.Areas.Admin.Constants.AdminConstants;
using System.Data;

namespace AutoMotoStyle.Controllers
{
    [Authorize]
    public class CarController : Controller
    {

        private readonly ICarService carService;
        private readonly IDealerService dealerService;
       
      //  private readonly ILogger logger;

        public CarController(
            ICarService _carService,
            IDealerService _dealerService)
        {
            carService = _carService;
            dealerService = _dealerService;
          
        }


        [HttpGet]
        [AllowAnonymous]
        public async  Task<IActionResult> All([FromQuery]AllCarsQueryModel query)
        {
            var result = await carService.All(
            query.Type,
            query.SearchTerm,
                query.Sorting,
                query.CurrentPage,
            AllCarsQueryModel.CarsPerPage);

            query.TotalCarCount = result.TotalCarCount;
            query.Types = await carService.AllTypesNames();
            query.Cars = result.Cars;

            return View(query);
        }


        public async Task<IActionResult> Mine()
        {
            if (User.IsInRole(AdminRolleName))
            {
                return RedirectToAction("Mine", "Car", new { area = AreaName });
            }

            IEnumerable<CarServiceModel> myCars;
            var userId = User.Id();

            if (await dealerService.ExistsById(userId))
            {
                int dealerId = await dealerService.GetDealerId(userId);
                myCars = await carService.AllCarsByDealerId(dealerId);
            }
            else
            {
                myCars = await carService.AllCarsByUsarId(userId);
            }

            return View(myCars);
        }


        [AllowAnonymous]
        public async Task<IActionResult> Details(int id, string information)
        {
            if ((await carService.Exists(id)) == false)
            {
                return RedirectToAction(nameof(Mine));
            }

            var model = await carService.CarDetailsById(id);

            if (information != model.GetInformation())
            {
                TempData["ErrorMessage"] = "Error!";

                return RedirectToAction("Index", "Home");
            }

            return View(model);
           //return RedirectToAction(nameof());
        }


        [HttpGet]      
        public async Task<IActionResult> Add() 
        {
          

            if ((await dealerService.ExistsById(User.Id()))==false)
            {
                return RedirectToAction(nameof(DealerController.Become), "Dealer");
            }

            var model = new CarModel()
            {
                CarTypes = await carService.AllTypes(),
                CarFuels = await carService.AllFuels(),
                CarTransmissions = await carService.AllTransmissions()
            };
         

            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Add(CarModel car)
        {
            
            if ((await dealerService.ExistsById(User.Id())) == false )
            {
                return RedirectToAction(nameof(DealerController.Become), "Dealer");
            }
                     

            if (!ModelState.IsValid)
            {
                car.CarTypes = await carService.AllTypes();
                car.CarFuels = await carService.AllFuels();
                car.CarTransmissions = await carService.AllTransmissions();

                return View(car);
              
            }

            int dealerId = await dealerService.GetDealerId(User.Id());

            int id = await carService.Create(car, dealerId);

            return RedirectToAction(nameof(Details), new { id=id, information=car.GetInformation() });
        }



        [HttpGet]
        public async Task<IActionResult> Edit(int id)
        {

            if ((await carService.Exists(id)) == false)
            {
                return RedirectToAction(nameof(All));
            }

            if ((await carService.HasDealerWithId(id, User.Id())) == false)
            {
              //  logger.LogInformation("User with id {0} attempted to open other agent house", User.Id());

                return RedirectToPage("/Account/AccessDenied", new { area = "Identity" });
            }

            var car = await carService.CarDetailsById(id);
            var typeId = await carService.GetCarTypeId(id);
            var fuelId = await carService.GetCarFuelId(id);
            var transmissionId = await carService.GetCarTransmissionId(id);

            var model = new CarModel()
            {
                Id = id,
                Brand = car.Brand,
                Model = car.Model,
                Year = car.Year,             
                Description = car.Description,
                ImageUrl = car.ImageUrl,
                Price = car.Price,
                TypeId = typeId,              
                FuelId = fuelId,
                TransmissionId = transmissionId,              
                CarTypes = await carService.AllTypes(),
                CarFuels = await carService.AllFuels(),
                CarTransmissions = await carService.AllTransmissions()           
        };

            return View(model);

        }


        [HttpPost]
        public async Task<IActionResult> Edit(int id, CarModel mod)
        {
          //  if (id != mod.Id)
          //  {
          //      return RedirectToPage("/Account/AccessDenied", new { area = "Identity" });
         //   }

            if ((await carService.Exists(mod.Id)) == false)
            {
                ModelState.AddModelError("", "Car does not exist!");
                mod.CarTypes = await carService.AllTypes();
                mod.CarFuels = await carService.AllFuels();
                mod.CarTransmissions = await carService.AllTransmissions();

                return View(mod);
            }

            if ((await carService.HasDealerWithId(mod.Id, User.Id())) == false)
            {
                return RedirectToPage("/Account/AccessDenied", new { area = "Identity" });
            }
                       

            if (ModelState.IsValid == false)
            {
                mod.CarTypes = await carService.AllTypes();
                mod.CarFuels = await carService.AllFuels();
                mod.CarTransmissions = await carService.AllTransmissions();

                return View(mod);
            }

            await carService.Edit(mod.Id, mod);

            return RedirectToAction(nameof(Details), new {id=mod.Id, information = mod.GetInformation()
            });
        }

        [HttpGet]
        public async Task<IActionResult> Delete(int id)
        {

            if ((await carService.Exists(id)) == false)
            {
                return RedirectToAction(nameof(All));
            }

            if ((await carService.HasDealerWithId(id, User.Id())) == false)
            {
                return RedirectToPage("/Account/AccessDenied", new { area = "Identity" });
            }

            var car = await carService.CarDetailsById(id);
            var model = new CarDetailsViewModel()
            {
                Brand = car.Brand,
                Model = car.Model,
                ImageUrl = car.ImageUrl
            };

            return View(model);
        }


        [HttpPost]
        public async Task<IActionResult> Delete(int id, CarDetailsViewModel model)
        {
            if ((await carService.Exists(id)) == false)
            {
                return RedirectToAction(nameof(All));
            }

            if ((await carService.HasDealerWithId(id, User.Id())) == false)
            {
                return RedirectToPage("/Account/AccessDenied", new { area = "Identity" });
            }

            await carService.Delete(id);

            return RedirectToAction(nameof(All));
        }

        [HttpPost]
        public async Task<IActionResult> Rent(int id)
        {
            if ((await carService.Exists(id)) == false)
            {
                return RedirectToAction(nameof(All));
            }

            if ( await dealerService.ExistsById(User.Id()))
            {
               return RedirectToPage("/Account/AccessDenied", new { area = "Identity" });
            }

            if (await carService.IsRented(id))
            {
                return RedirectToAction(nameof(All));
            }

            await carService.Rent(id, User.Id());

            return RedirectToAction(nameof(Mine));


        }

        [HttpPost]
        public async Task<IActionResult> Leave(int id)
        {


            if ((await carService.Exists(id)) == false ||
                (await carService.IsRented(id)) == false)
            {
                return RedirectToAction(nameof(All));
            }

            if ((await carService.IsRentedByUserWithId(id, User.Id())) == false)
            {
                return RedirectToPage("/Account/AccessDenied", new { area = "Identity" });
            }

            await carService.Leave(id);

            return RedirectToAction(nameof(Mine));
        }
    }
}
