using AutoMotoStyle.Core.Models.Dealer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace AutoMotoStyle.Controllers
{
    [Authorize]
    public class DealerController : Controller
    {
        [HttpGet]
        public async Task<IActionResult> Become()
        {            

            var model = new DealerModel();

            return View(model);
        }


        [HttpPost]
        public async Task<IActionResult> Become(DealerModel model)
        {
            

            return RedirectToAction("All", "Car");
        }
    }
}
