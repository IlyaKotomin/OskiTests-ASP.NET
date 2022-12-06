using Microsoft.EntityFrameworkCore;
using OskiTests.Models;

namespace OskiTests.Data
{
    public class AppDataBaseContext : DbContext
    {
        public AppDataBaseContext(DbContextOptions<AppDataBaseContext> options)
            : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }

        public DbSet<AnswerViewModel> AnswerViewModels { get; set; }

        public DbSet<QuestionViewModel> QuestionViewModels { get; set; }

        public DbSet<QuizViewModel> QuizViewModels { get; set; }
    }
}
