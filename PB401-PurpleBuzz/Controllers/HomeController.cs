using Microsoft.AspNetCore.Mvc;

namespace PB401_PurpleBuzz.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        } 
    }
}
