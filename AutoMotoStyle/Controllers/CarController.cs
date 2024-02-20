﻿using AutoMotoStyle.Core.Contracts;
using AutoMotoStyle.Core.Models.Car;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace AutoMotoStyle.Controllers
{
    [Authorize]
    public class CarController : Controller
    {

        [HttpGet]
        [AllowAnonymous]
        public async  Task<IActionResult> All()
        {
            var model = new CarsModel();



            return View(model);
        }


        public async Task<IActionResult> Mine()
        {
            var model = new CarsModel();



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


            var model = new CarFormModel();
         

            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Add(CarFormModel model)
        {
            int id = 1;

            return RedirectToAction(nameof(Details), new {  id });
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