﻿using Microsoft.AspNetCore.Identity;
using OskiTests.Data.Static;
using OskiTests.Models;

namespace OskiTests.Data
{
    public class AppDatabaseInitializer
    {
        public static async void Seed(IApplicationBuilder applicationBuilder)
        {
            using (var serviceScope = applicationBuilder.ApplicationServices.CreateScope())
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
        public static async void SeedRoles(IApplicationBuilder applicationBuilder)
        {
            using (var serviceScope = applicationBuilder.ApplicationServices.CreateScope())
            {
                var roleManager = serviceScope.ServiceProvider.GetRequiredService<RoleManager<IdentityRole>>();

                if (!await roleManager.RoleExistsAsync(UserRoles.Admin))
                    await roleManager.CreateAsync(new IdentityRole(UserRoles.Admin));

                if (!await roleManager.RoleExistsAsync(UserRoles.User))
                    await roleManager.CreateAsync(new IdentityRole(UserRoles.User));
            }
        }
    }
}
