namespace JourneyExpertSystem.Models
{
    internal class Question
    {
        internal string Text { get; set; }
        internal IEnumerable<Answer> Answers { get; set; }

        internal Question(string text, IEnumerable<Answer> answers)
        {
            if (answers.Any() == false)
                throw new InvalidOperationException("Нельзя создать вопрос без ответов");

            Text = text;
            Answers = answers;
        }
    }
}
