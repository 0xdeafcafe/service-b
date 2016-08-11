using Microsoft.AspNetCore.Mvc;

namespace ServiceB.Controllers
{
	public class InfoController : Controller
	{
		public IActionResult Index()
		{
			return Json(new
			{
				service = "b",
				test = true
			});
		}
	}
}
