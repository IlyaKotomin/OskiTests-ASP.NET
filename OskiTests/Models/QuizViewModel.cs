using System.ComponentModel.DataAnnotations;

namespace OskiTests.Models
{
    public class QuizViewModel
    {
        [Key]
        public int Id { get; set; }

        public string? Name { get; set; }

        public string? Description { get; set; }


        //Relationships
        public List<QuestionViewModel>? Questions { get; set; }
    }
}
