using Microsoft.AspNetCore.Mvc;

namespace PB401_PurpleBuzz.Controllers
{
    public class ContactController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
