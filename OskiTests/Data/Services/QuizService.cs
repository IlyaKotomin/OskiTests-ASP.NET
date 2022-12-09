using Microsoft.EntityFrameworkCore;
using OskiTests.Models;

namespace OskiTests.Data.Services
{
    public class QuizService : IQuizService
    {
        private readonly AppDatabaseContext _databaseContext;

        public QuizService(AppDatabaseContext databaseContext) =>
            _databaseContext = databaseContext;

        public void AddQuiz(QuizViewModel quiz)
        {
            throw new NotImplementedException();
        }

        public void DeleteQuiz(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<QuizViewModel>> GetAllQuizzes(bool withQuestions) =>
            withQuestions ? await _databaseContext.Quizzes.Include(n => n.Questions).ToListAsync()
            : await _databaseContext.Quizzes.ToListAsync();

        public async Task<QuestionViewModel> GetQuestion(int questionId)
        {
            var result = await _databaseContext.Questions
                .Include(n => n.Answers)!
                .FirstOrDefaultAsync(n => n.Id == questionId)!;

            return result!;

        }

        public async Task<QuizViewModel>? GetQuizById(int id)
        {
            var model = await _databaseContext.Quizzes!
                .Include(n => n.Questions)
                .FirstOrDefaultAsync(n => n.Id == id)!;

            return model!;
        }

        public QuizViewModel UpdateQuiz(int id, QuizViewModel newQuiz)
        {
            throw new NotImplementedException();
        }
    }
}
