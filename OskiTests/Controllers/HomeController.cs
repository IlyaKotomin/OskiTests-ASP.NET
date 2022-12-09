using Microsoft.AspNetCore.Identity;
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

        private readonly UserManager<ApplicationUser> _userManager;


        public HomeController(ILogger<HomeController> logger, IQuizService quizService, UserManager<ApplicationUser> userManager)
        {
            _logger = logger;
            _quizService = quizService;
            _userManager = userManager;
        }

        public async Task<IActionResult> Index()
        {
            var quizzesData = await _quizService.GetAllQuizzes(withQuestions: true);

            var quizzesToShow = new List<QuizViewModel>();

            var user = await _userManager.GetUserAsync(HttpContext.User);

            if (user == null || user.ComplitedQuizzes == null)
                return View(quizzesData);

            foreach (var quizData in quizzesData)
                if (!user.ComplitedQuizzes!.Contains(quizData))
                    quizzesToShow.Add(quizData);

            return View(quizzesToShow);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}