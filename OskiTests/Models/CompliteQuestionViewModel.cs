namespace OskiTests.Models
{
	public class CompliteQuestionViewModel
	{
		public QuestionViewModel? QuestionViewModel { get; set; }

		public QuizViewModel? Quiz { get; set; }

		public int CurrentIndex { get; set; }

		public int CorrectAnswers { get; set; }

        public string? LastAnswer { get; set; }

    }
}
