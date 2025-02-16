namespace ScriptureMemorizer
{
    public class Reference
    {
        public string Book { get; private set; }
        public int Chapter { get; private set; }
        public int VerseStart { get; private set; }
        public int? VerseEnd { get; private set; }  // Nullable int to support a verse range

        // Constructor for a single verse
        public Reference(string book, int chapter, int verse)
        {
            Book = book;
            Chapter = chapter;
            VerseStart = verse;
            VerseEnd = null;
        }

        // Constructor for a verse range
        public Reference(string book, int chapter, int verseStart, int verseEnd)
        {
            Book = book;
            Chapter = chapter;
            VerseStart = verseStart;
            VerseEnd = verseEnd;
        }

        public override string ToString()
        {
            return VerseEnd.HasValue ? $"{Book} {Chapter}:{VerseStart}-{VerseEnd}" : $"{Book} {Chapter}:{VerseStart}";
        }
    }
}
