namespace ScriptureMemorizer
{
    public class Word
    {
        public string Text { get; private set; }
        public bool IsHidden { get; private set; }

        public Word(string text)
        {
            Text = text;
            IsHidden = false;
        }

        public void Hide()
        {
            IsHidden = true;
        }

        public override string ToString()
        {
            // Display underscores matching the length of the word when hidden.
            return IsHidden ? new string('_', Text.Length) : Text;
        }
    }
}
