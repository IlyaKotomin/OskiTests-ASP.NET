using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using OskiTests.Data;
using OskiTests.Models;
using System.Diagnostics;

namespace OskiTests.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        private readonly AppDatabaseContext _context;

        public HomeController(ILogger<HomeController> logger, AppDatabaseContext context)
        {
            _logger = logger;
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            var quizzesData = await _context.Quizzes.Include(n => n.Questions).ToListAsync();
            return View(quizzesData);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}