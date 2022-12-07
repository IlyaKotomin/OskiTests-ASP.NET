using Microsoft.AspNetCore.Mvc;

namespace OskiTests.Controllers
{
    public class AdminController : Controller
    {
        public IActionResult AddNewQuiz()
        {
            return View();
        }

        public IActionResult Edit()
        {
            return View();
        }
    }
}
