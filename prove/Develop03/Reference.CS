namespace ScriptureMemorizer
{
    public class Reference
    {
        private string _book;
        private int _chapter;
        private int _verse;
        private int? _verseEnd;

        // Public read-only properties that expose the private fields.
        public string Book => _book;
        public int Chapter => _chapter;
        public int Verse => _verse;
        public int? VerseEnd => _verseEnd;

        // Constructor for a single verse.
        public Reference(string book, int chapter, int verse)
        {
            _book = book;
            _chapter = chapter;
            _verse = verse;
            _verseEnd = null;
        }

        // Constructor for a verse range.
        public Reference(string book, int chapter, int verse, int verseEnd)
        {
            _book = book;
            _chapter = chapter;
            _verse = verse;
            _verseEnd = verseEnd;
        }

        public override string ToString()
        {
            return _verseEnd.HasValue
                ? $"{_book} {_chapter}:{_verse}-{_verseEnd}"
                : $"{_book} {_chapter}:{_verse}";
        }
    }
}
