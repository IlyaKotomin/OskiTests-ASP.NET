using System.ComponentModel.DataAnnotations;

namespace OskiTests.Models
{
    public class AnswerViewModel
    {
        [Key]
        public int Id { get; set; }

        public string? Content { get; set; }

        public bool IsCorrect { get; set; }
    }
}
