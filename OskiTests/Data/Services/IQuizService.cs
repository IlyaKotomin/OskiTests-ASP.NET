using OskiTests.Models;

namespace OskiTests.Data.Services
{
    public interface IQuizService
    {
        public Task<IEnumerable<QuizViewModel>> GetAllQuizzes(bool withQuestions);

        public QuizViewModel GetQuizById(int id);

        public void AddQuiz(QuizViewModel quiz);

        public void DeleteQuiz(int id);

        public QuizViewModel UpdateQuiz(int id, QuizViewModel newQuiz);
    }
}
