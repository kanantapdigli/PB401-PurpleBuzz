using Microsoft.AspNetCore.Mvc;
using PB401_PurpleBuzz.Data;
using PB401_PurpleBuzz.Models.About;

namespace PB401_PurpleBuzz.Controllers
{
    public class AboutController : Controller
    {
        private readonly AppDbContext _context;
        public AboutController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var teamMembers = _context.TeamMembers.OrderBy(x => x.Id).Take(3).ToList();

            var teamMembersList = new List<TeamMemberVM>();
            foreach (var teamMember in teamMembers)
            {
                var teamMemberVM = new TeamMemberVM
                {
                    Name = teamMember.Name,
                    Surname = teamMember.Surname,
                    PhotoPath = teamMember.PhotoPath,
                    Position = teamMember.Position
                };

                teamMembersList.Add(teamMemberVM);
            }

            var model = new AboutIndexVM
            {
                TeamMembers = teamMembersList
            };

            return View(model);
        }
    }
}
