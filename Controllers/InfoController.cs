using Microsoft.AspNetCore.Mvc;

namespace ServiceB.Controllers
{
    public class InfoController : Controller
    {
        public IActionResult Get()
        {
            return Json(new
            {
                service = "b",
                test = true
            });
        }
    }
}
