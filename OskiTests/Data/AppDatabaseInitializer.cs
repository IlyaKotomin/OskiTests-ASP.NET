using OskiTests.Models;

namespace OskiTests.Data
{
    public class AppDatabaseInitializer
    {
        public static void Seed(IApplicationBuilder builder)
        {
            using (var serviceScope = builder.ApplicationServices.CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetService<AppDataBaseContext>()!;

                context.Database.EnsureCreated();


                //Answers
                if (!context.AnswerViewModels.Any())
                {
                    context.AnswerViewModels.AddRange(new List<AnswerViewModel>()
                    {
                        new AnswerViewModel()
                        {
                            Content = "Correct Answer",
                            IsCorrect = true,
                        },
                        new AnswerViewModel()
                        {
                            Content = "",
                            IsCorrect = true,
                        },
                        new AnswerViewModel()
                        {
                            Content = "",
                            IsCorrect = true,
                        },
                        new AnswerViewModel()
                        {
                            Content = "",
                            IsCorrect = true,
                        },
                    });
                }
                //Questions
                //Quizzes
            }
        }
    }
}
