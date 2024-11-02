using Microsoft.AspNetCore.Mvc;

namespace PB401_PurpleBuzz.Controllers
{
    public class PricingController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
