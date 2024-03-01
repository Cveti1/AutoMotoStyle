using AutoMotoStyle.Core.Contracts;
using AutoMotoStyle.Core.Models.Car;
using AutoMotoStyle.Extensions;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

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
        public async  Task<IActionResult> All()
        {
                        
            var model = new CarModel();
            return View(model);
        }


        public async Task<IActionResult> Mine()
        {
            var model = new CarModel();



            return View(model);
        }


        [AllowAnonymous]
        public async Task<IActionResult> Details(int id)
        {


            var model = new CarDetailsModel();


           
            return View(model);
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
            if ((await dealerService.ExistsById(User.Id())) == false)
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

            return RedirectToAction(nameof(Details), new { id });
        }



        [HttpGet]
        public async Task<IActionResult> Edit(int id)
        {

            var model = new CarFormModel();
               return View(model);
            
        }


        [HttpPost]
        public async Task<IActionResult> Edit(int id, CarFormModel model)
        {
        

            return RedirectToAction(nameof(Details), new { id});
        }


        [HttpPost]
        public async Task<IActionResult> Delete(int id)
        {


            return RedirectToAction(nameof(All), new { id });
        }

        [HttpPost]
        public async Task<IActionResult> Rent(int id)
        {


            return RedirectToAction(nameof(Mine), new { id });
        }

        [HttpPost]
        public async Task<IActionResult> Leave(int id)
        {


            return RedirectToAction(nameof(Mine), new { id });
        }
    }
}
