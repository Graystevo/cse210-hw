namespace ScriptureMemorizer
{
    public class Words
    {
        private string _text;
        private bool _isHidden;

        public Words(string text)
        {
            _text = text;
            _isHidden = false;
        }

        // Public property to expose the hidden state.
        public bool IsHidden => _isHidden;

        public void Hide()
        {
            _isHidden = true;
        }

        // New method to unhide a word.
        public void Unhide()
        {
            _isHidden = false;
        }

        public override string ToString()
        {
            // If the word is hidden, show underscores matching the length of the word.
            return _isHidden ? new string('_', _text.Length) : _text;
        }
    }
}
