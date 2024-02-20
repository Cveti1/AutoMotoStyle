using AutoMotoStyle.Core.Contracts;
using AutoMotoStyle.Core.Models.Dealer;
using AutoMotoStyle.Extensions;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace AutoMotoStyle.Controllers
{
    [Authorize]
    public class DealerController : Controller
    {

        private readonly IDealerService dealerService;

        public DealerController(IDealerService _dealerService)
        {
            dealerService = _dealerService;
        }


        [HttpGet]
        public async Task<IActionResult> Become()
        {

            if (await dealerService.ExistsById(User.Id()))
            {
                // return BadRequest();
                return RedirectToAction("All", "Car");
            }

            var model = new BecomeDealer();

            return View(model);


        }


        [HttpPost]
        public async Task<IActionResult> Become(BecomeDealer model)
        {
            var userId = User.Id();

            if (!ModelState.IsValid)
            {
                return View(model);
            }
            if (await dealerService.ExistsById(userId))
            {
                 return BadRequest();
              
            }

           await dealerService.Create(userId, model.DealerName, model.PhoneNumber);

            return RedirectToAction("All", "Car");
        }
    }
}





  

   
