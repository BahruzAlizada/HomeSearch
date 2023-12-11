using Microsoft.AspNetCore.Mvc;

namespace UILayer.Controllers
{
    public class AboutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
