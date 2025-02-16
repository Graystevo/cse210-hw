namespace ScriptureMemorizer
{
    public class Words
    {
        public string _text { get; private set; }
        public bool IsHidden { get; private set; }

        public Words(string text)
        {
            _text = text;
            IsHidden = false;
        }

        public void Hide()
        {
            IsHidden = true;
        }

        public string ToHiddenString()
        {
            // display underscore matching the length of the word when hidden.
            return IsHidden ? new string('_', _text.Length) : _text;
        }
    }
}
