using Microsoft.AspNetCore.Mvc;

namespace AutoMotoStyle.Controllers
{
	public class ServiceController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}
