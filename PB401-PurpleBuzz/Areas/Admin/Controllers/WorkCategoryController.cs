using Microsoft.AspNetCore.Mvc;
using PB401_PurpleBuzz.Areas.Admin.Models.WorkCategory;
using PB401_PurpleBuzz.Data;
using PB401_PurpleBuzz.Entities;

namespace PB401_PurpleBuzz.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class WorkCategoryController : Controller
    {
        private readonly AppDbContext _context;

        public WorkCategoryController(AppDbContext context)
        {
            _context = context;
        }

        #region List

        [HttpGet]
        public IActionResult Index()
        {
            var model = new WorkCategoryIndexVM
            {
                WorkCategories = _context.WorkCategories.ToList()
            };

            return View(model);
        }

        #endregion

        #region Create

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(WorkCategoryCreateVM model)
        {
            if (!ModelState.IsValid) return View();

            var workCategory = _context.WorkCategories.FirstOrDefault(wc => wc.Name.ToLower() == model.Name.ToLower());
            if (workCategory is not null)
            {
                ModelState.AddModelError("Name", "Bu adda kateqoriya mövcuddur");
                return View();
            }

            workCategory = new WorkCategory
            {
                Name = model.Name
            };

            _context.WorkCategories.Add(workCategory);
            _context.SaveChanges();

            return RedirectToAction(nameof(Index));
        }

        #endregion

        #region Update

        [HttpGet]
        public IActionResult Update(int id)
        {
            var workCategory = _context.WorkCategories.Find(id);
            if (workCategory is null) return NotFound();

            var model = new WorkCategoryUpdateVM
            {
                Name = workCategory.Name
            };

            return View(model);
        }

        [HttpPost]
        public IActionResult Update(int id, WorkCategoryUpdateVM model)
        {
            if (!ModelState.IsValid) return View();

            var workCategory = _context.WorkCategories.Find(id);
            if (workCategory is null) return NotFound();

            var isExist = _context.WorkCategories.Any(wc => wc.Name.ToLower() == model.Name.ToLower() && wc.Id != id);
            if (isExist)
            {
                ModelState.AddModelError("Name", "Bu adda kateqoriya mövcuddur");
                return View();
            }

            if (workCategory.Name != model.Name)
                workCategory.ModifiedAt = DateTime.Now;

            workCategory.Name = model.Name;

            _context.WorkCategories.Update(workCategory);
            _context.SaveChanges();

            return RedirectToAction(nameof(Index));
        }

        #endregion

        #region Delete

        [HttpPost]
        public IActionResult Delete(int id)
        {
            var workCategory = _context.WorkCategories.Find(id);
            if (workCategory is null) return NotFound();

            _context.WorkCategories.Remove(workCategory);
            _context.SaveChanges();

            return RedirectToAction(nameof(Index));
        }
 
        #endregion
    }
}
