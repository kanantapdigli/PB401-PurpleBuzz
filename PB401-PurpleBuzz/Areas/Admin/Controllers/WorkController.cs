using Microsoft.AspNetCore.Mvc;

namespace PB401_PurpleBuzz.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class WorkController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
