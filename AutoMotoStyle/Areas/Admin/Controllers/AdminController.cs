using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace AutoMotoStyle.Areas.Admin.Controllers
{
    [Authorize(Roles ="Administrator")]
    public class AdminController : BaseController
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
