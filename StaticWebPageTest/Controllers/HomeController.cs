using System.Linq;
using Microsoft.AspNetCore.Mvc;
using StaticWebPageTest.Models;

namespace StaticWebPageTest.Controllers
{
	public class HomeController : Controller
    {
		private ApplicationDbContext db;
		public HomeController(ApplicationDbContext _context)
		{
			db = _context;
		}

		public IActionResult Index()
        {
			var item = db.Items.FirstOrDefault(s => s.Id == 1);

			return View(item);
        }


    }
}
