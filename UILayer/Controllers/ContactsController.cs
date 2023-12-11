using Microsoft.AspNetCore.Mvc;

namespace UILayer.Controllers
{
    public class ContactsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
