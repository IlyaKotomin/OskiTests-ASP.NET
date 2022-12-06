using System.ComponentModel.DataAnnotations;

namespace OskiTests.Models
{
    public class QuestionViewModel
    {
        [Key]
        public int? Id { get; set; }

        public string? Question { get; set; }

        public List<AnswerViewModel>? Answers { get; set; }
    }
}
