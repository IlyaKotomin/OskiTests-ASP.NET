using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using OskiTests.Data.Services;
using OskiTests.Models;
using System.Reflection;
using System.Text.Json;

namespace OskiTests.Controllers
{
    [Authorize]
    public class QuizController : Controller
    {
        private readonly IQuizService _quizService;

        private readonly UserManager<ApplicationUser> _userManager;

        public QuizController(IQuizService quizService, UserManager<ApplicationUser> userManager)
        {
            _quizService = quizService;
            _userManager = userManager;
        }

        public async Task<IActionResult> Index(int id)
        {
            return View(await _quizService.GetQuizById(id)!);
        }
        public async Task<IActionResult> Question(string compliteQuestionJson)
        {
            var compliteQuestionViewModel = JsonSerializer.Deserialize<CompliteQuestionViewModel>(compliteQuestionJson);

            if (compliteQuestionViewModel!.LastAnswer == compliteQuestionViewModel.QuestionViewModel!.CorrectAnswer
                && compliteQuestionViewModel!.LastAnswer != null)
                compliteQuestionViewModel.CorrectAnswers++;

            compliteQuestionViewModel.QuestionViewModel = await _quizService.GetQuestion((int)compliteQuestionViewModel
                .Quiz!.Questions![compliteQuestionViewModel.CurrentIndex].Id!);

            return View(compliteQuestionViewModel);
        }

        public IActionResult SubmitQuestion(IFormCollection collection, string submit)
        {
            var compliteQuestionViewModel = JsonSerializer.Deserialize<CompliteQuestionViewModel>(submit);

            compliteQuestionViewModel!.LastAnswer = collection["LastAnswer"].ToString();

            compliteQuestionViewModel!.CurrentIndex++;

            if(compliteQuestionViewModel.CurrentIndex >= compliteQuestionViewModel.Quiz!.Questions!.Count)
                return RedirectToAction("Results", "Quiz", new { compliteQuestionJson = JsonSerializer.Serialize(compliteQuestionViewModel) });

            return RedirectToAction("Question", "Quiz", new { compliteQuestionJson = JsonSerializer.Serialize(compliteQuestionViewModel) });
        }

        public async Task<IActionResult> Results(string compliteQuestionJson)
        {
            var result = JsonSerializer.Deserialize<CompliteQuestionViewModel>(compliteQuestionJson);

            var user = await _userManager.GetUserAsync(HttpContext.User);

            if (user == null)
                return RedirectToAction("Login", "Account");

            if (user.ComplitedQuizzes == null)
                user.ComplitedQuizzes = new List<QuizViewModel>();

            result!.Quiz = await _quizService.GetQuizById(result.Quiz!.Id!)!;
            

            user.ComplitedQuizzes!.Add(result!.Quiz!);

            await _userManager.UpdateAsync(user);

            return View(result);
        }
    }
}
