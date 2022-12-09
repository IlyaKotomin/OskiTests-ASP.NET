using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Newtonsoft.Json;
using OskiTests.QuizzesAPI;

namespace OskiTests.PageModels
{
    public class QuizPageModel : PageModel
    {
        public RandomQuiz? Quiz { get; set; }

        public IActionResult OnGet(string passedObject)
        {
            Quiz = JsonConvert.DeserializeObject<RandomQuiz>(passedObject);

            if (Quiz == null)
                return NotFound();

            return Page();
        }


    }
}
