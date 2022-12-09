using OskiTests.Models;

namespace OskiTests.Data.Services
{
    public interface IQuizService
    {
        public Task<QuestionViewModel> GetQuestion(int id);

        public Task<IEnumerable<QuizViewModel>> GetAllQuizzes(bool withQuestions);

        public Task<QuizViewModel>? GetQuizById(int id);

        public void AddQuiz(QuizViewModel quiz);

        public void DeleteQuiz(int id);

        public QuizViewModel UpdateQuiz(int id, QuizViewModel newQuiz);
    }
}
