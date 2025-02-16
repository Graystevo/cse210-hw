using System;
using System.Collections.Generic;
using System.Linq;

namespace ScriptureMemorizer
{
    public class Scripture
    {
        public Reference Reference { get; private set; }
        private List<Words> _words;
        private Random _random;

        public Scripture(Reference reference, string text)
        {
            Reference = reference;
            _words = new List<Words>();

            // Split the scripture text into individual words.
            string[] splitWords = text.Split(' ');
            foreach (string word in splitWords)
            {
                _words.Add(new Words(word));
            }

            _random = new Random();
        }

        // Display the scripture with its reference. Hidden words appear as underscores.
        public void Display()
        {
            Console.WriteLine(Reference.ToString());
            foreach (var word in _words)
            {
                Console.Write(word + " ");
            }
            Console.WriteLine();
        }

        // Returns true if all words are hidden.
        public bool AllWordsHidden()
        {
            return _words.All(w => w.IsHidden);
        }

        // Hide a set number of words at random.
        public void HideRandomWords(int count)
        {
            for (int i = 0; i < count; i++)
            {
                int index = _random.Next(_words.Count);
                _words[index].Hide();
            }
        }
    }
}
