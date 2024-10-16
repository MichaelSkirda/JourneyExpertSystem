namespace JourneyExpertSystem.Models
{
    internal class Answer
    {
        internal string Text { get; set; }
        internal Action ClickCallback { get; set; }

        internal Answer(string text, Action clickCallback)
        {
            Text = text;
            ClickCallback = clickCallback;
        }
    }
}
