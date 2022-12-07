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

        public QuizViewModel GetQuizById(int id)
        { 
            throw new NotImplementedException();
        }

        public QuizViewModel UpdateQuiz(int id, QuizViewModel newQuiz)
        {
            throw new NotImplementedException();
        }
    }
}
