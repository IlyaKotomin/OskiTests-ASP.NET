using OskiTests.Models;

namespace OskiTests.Data.Services
{
    public interface IQuizService
    {
        public IEnumerable<QuizViewModel> GetAllQuizzes();

        public QuizViewModel GetQuizById(int id);

        public void AddQuiz(QuizViewModel quiz);

        public void DeleteQuiz(int id);

        public QuizViewModel UpdateQuiz(int id, QuizViewModel newQuiz);
    }
}
