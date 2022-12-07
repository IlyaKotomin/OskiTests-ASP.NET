using Microsoft.EntityFrameworkCore;
using OskiTests.Models;

namespace OskiTests.Data
{
    public class AppDatabaseContext : DbContext
    {
        public AppDatabaseContext(DbContextOptions<AppDatabaseContext> options)
            : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }

        public DbSet<AnswerViewModel> Answers { get; set; }

        public DbSet<QuestionViewModel> Questions { get; set; }

        public DbSet<QuizViewModel> Quizzes { get; set; }

        public DbSet<UserViewModel> Users { get; set; }
    }
}
