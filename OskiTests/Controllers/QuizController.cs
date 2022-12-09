using Microsoft.AspNetCore.Mvc;

namespace OskiTests.Controllers
{
    public class QuizController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
