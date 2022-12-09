using OpenTriviaSharp;
using OpenTriviaSharp.Models;
using System.Text.Json.Serialization;

namespace OskiTests.QuizzesAPI
{
    public class RandomQuiz
    {
        public readonly Category Category;

        public readonly Difficulty Difficulty;

        [JsonInclude]
        public TriviaQuestion[] Questions;

        private static OpenTriviaClient _triviaClient = new OpenTriviaClient();

        public int Count => Questions.Length;

        public RandomQuiz(byte count)
        {
            Difficulty = GetRandomEnumElement<Difficulty>();
            Category = GetRandomEnumElement<Category>();
            Questions = _triviaClient.GetQuestionAsync(amount: count,
                                                category: Category,
                                                difficulty: Difficulty)
                                                .Result;
        }

        private TOutput GetRandomEnumElement<TOutput>()
        {
            var type = typeof(TOutput);

            if (!type.IsEnum)
                throw new InvalidCastException();

            Array values = Enum.GetValues(type);
            return (TOutput)values.GetValue(new Random().Next(values.Length))!;
        }
    }
}
