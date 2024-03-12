using Microsoft.AspNetCore.Mvc;

namespace AutoMotoStyle.Areas.Admin.Controllers
{
    public class UserController : Controller
    {
        public async Task<IActionResult> All()
        {
            return View();
        }
    }
}
