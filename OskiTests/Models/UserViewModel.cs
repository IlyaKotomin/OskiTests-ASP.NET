using System.ComponentModel.DataAnnotations;

namespace OskiTests.Models
{
    public class UserViewModel
    {
        [Key]
        public int Id { get; set; }

        public string? Name { get; set; }

        public string? AltName { get; set; }

        public string? Email { get; set; }

        public string? Password { get; set; }

        public List<QuizViewModel>? ComplitedQuizzes { get; set; }
    }
}
