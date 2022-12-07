using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using OskiTests.Data;
using OskiTests.Data.Services;
using OskiTests.Models;
using System.Diagnostics;

namespace OskiTests.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        private readonly IQuizService _quizService;

        public HomeController(ILogger<HomeController> logger, IQuizService quizService)
        {
            _logger = logger;
            _quizService = quizService;
        }

        public async Task<IActionResult> Index()
        {
            var quizzesData = await _quizService.GetAllQuizzes(withQuestions: true);
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