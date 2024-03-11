using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using static AutoMotoStyle.Areas.Admin.Constants.AdminConstants;

namespace AutoMotoStyle.Areas.Admin.Controllers
{
	[Area(AreaName)]
	[Route("Admin/[controller]/[Action]/{id?}")]
	[Authorize(Roles = AdminRolleName)]

	public class BaseController : Controller
	{
		
	}
}
