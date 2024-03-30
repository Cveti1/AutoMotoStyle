using AutoMotoStyle.Controllers;
using AutoMotoStyle.Core.Contracts;
using AutoMotoStyle.Core.Models.Car;
using AutoMotoStyle.Core.Models.Service;
using AutoMotoStyle.Core.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Cors.Infrastructure;
using Microsoft.AspNetCore.Mvc;

namespace AutoMotoStyle.Controllers
{
    [Authorize]
    public class ServiceController : Controller
	{
        private readonly IServiceModel serviceModel;
      
        public ServiceController(IServiceModel _serviceModel)
        {
            serviceModel = _serviceModel;
           
        }



        public async Task<IActionResult> IndexService()
        {

            // if (User.IsInRole(AdminRolleName))
            //  {
            //      return RedirectToAction("Index", "Admin", new { area = "Admin" });
            //  }

            var model = await serviceModel.AllServices();

            return View(model);

           }
	}
}





