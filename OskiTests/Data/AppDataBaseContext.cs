using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using OskiTests.Models;

namespace OskiTests.Data
{
    public class AppDatabaseContext : IdentityDbContext<ApplicationUser>
    {
        public AppDatabaseContext(DbContextOptions<AppDatabaseContext> options)
            : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }

        public DbSet<QuestionViewModel> Questions { get; set; }

        public DbSet<QuizViewModel> Quizzes { get; set; }
    }
}
