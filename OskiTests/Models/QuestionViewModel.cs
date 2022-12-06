using System.ComponentModel.DataAnnotations;

namespace OskiTests.Models
{
    public class QuestionViewModel
    {
        [Key]
        public int? QuestionId { get; set; }

        public string? Question { get; set; }

        public string[]? Answers { get; set; }
    }
}
