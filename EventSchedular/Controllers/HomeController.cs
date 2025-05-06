using Microsoft.AspNetCore.Mvc;

namespace Event_Schedular.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
