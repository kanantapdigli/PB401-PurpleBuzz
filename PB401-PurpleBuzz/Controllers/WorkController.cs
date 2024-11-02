using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PB401_PurpleBuzz.Data;
using PB401_PurpleBuzz.Models.Work;

namespace PB401_PurpleBuzz.Controllers
{
    public class WorkController : Controller
    {
        private readonly AppDbContext _context;

        public WorkController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var model = new WorkIndexVM
            {
                WorkCategories = _context.WorkCategories.Include(wc => wc.Works).ToList()
            };

            return View(model);
        }

        public IActionResult Details(int id)
        {
            return View();
        }
    }
}
