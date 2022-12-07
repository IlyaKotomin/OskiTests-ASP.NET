using OskiTests.Models;

namespace OskiTests.Data
{
    public class AppDatabaseInitializer
    {
        public static async void Seed(IApplicationBuilder builder)
        {
            using (var serviceScope = builder.ApplicationServices.CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetService<AppDatabaseContext>()!;

                context.Database.EnsureCreated();

                if (context.Quizzes.Any())
                    return;

                QuizViewModel testQuiz = new()
                {
                    Name = "This is a test Quiz! (1)",
                    Description = "Test quiz description! (1)",
                    Questions = new List<QuestionViewModel>()
                    {
                        new()
                        {
                            Question = "First Test Quiz Question (1)!",
                            Answers = new List<AnswerViewModel>()
                            {
                                new()
                                {
                                    IsCorrect = true,
                                    Content = "Correct Answer!"
                                },

                                new()
                                {
                                    IsCorrect = true,
                                    Content = "Not Correct Answer! 1"
                                },

                                new()
                                {
                                    IsCorrect = true,
                                    Content = "Not Correct Answer! 2"
                                },

                                new()
                                {
                                    IsCorrect = true,
                                    Content = "Not Correct Answer! 3"
                                },
                            }
                        },

                        new()
                        {
                            Question = "Second Test Quiz Question (1)!",
                            Answers = new List<AnswerViewModel>()
                            {
                                new()
                                {
                                    IsCorrect = true,
                                    Content = "Correct Answer!"
                                },

                                new()
                                {
                                    IsCorrect = true,
                                    Content = "Not Correct Answer! 1"
                                },

                                new()
                                {
                                    IsCorrect = true,
                                    Content = "Not Correct Answer! 2"
                                },

                                new()
                                {
                                    IsCorrect = true,
                                    Content = "Not Correct Answer! 3"
                                },
                            }
                        },
                    },
                };

                QuizViewModel testQuiz2 = new()
                {
                    Name = "This is a test Quiz! (2)",
                    Description = "Test quiz description! (2)",
                    Questions = new List<QuestionViewModel>()
                    {
                        new()
                        {
                            Question = "First Test Quiz Question (2)!",
                            Answers = new List<AnswerViewModel>()
                            {
                                new()
                                {
                                    IsCorrect = true,
                                    Content = "Correct Answer!"
                                },

                                new()
                                {
                                    IsCorrect = true,
                                    Content = "Not Correct Answer! 1"
                                },

                                new()
                                {
                                    IsCorrect = true,
                                    Content = "Not Correct Answer! 2"
                                },

                                new()
                                {
                                    IsCorrect = true,
                                    Content = "Not Correct Answer! 3"
                                },
                            }
                        },

                        new()
                        {
                            Question = "Second Test Quiz Question (2)!",
                            Answers = new List<AnswerViewModel>()
                            {
                                new()
                                {
                                    IsCorrect = true,
                                    Content = "Correct Answer!"
                                },

                                new()
                                {
                                    IsCorrect = true,
                                    Content = "Not Correct Answer! 1"
                                },

                                new()
                                {
                                    IsCorrect = true,
                                    Content = "Not Correct Answer! 2"
                                },

                                new()
                                {
                                    IsCorrect = true,
                                    Content = "Not Correct Answer! 3"
                                },
                            }
                        },
                    },
                };

                await context.AddRangeAsync(new List<QuizViewModel>() { testQuiz, testQuiz2 });

                await context.SaveChangesAsync();
            }
        }
    }
}
