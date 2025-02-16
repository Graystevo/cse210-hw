using System;
using System.Collections.Generic;
using System.Linq;

namespace ScriptureMemorizer
{
    public class Scripture
    {
        public Reference Reference { get; private set; }
        private List<Words> _words;
        private Words[] _allWords;    // Array of all words.
        private Words[] _hiddenWords; // Array of only hidden words.
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
            UpdateWordArrays();
        }

        // Update our arrays to reflect the current state of _words.
        private void UpdateWordArrays()
        {
            _allWords = _words.ToArray();
            _hiddenWords = _words.Where(w => w.IsHidden).ToArray();
        }

        // Display the scripture with its reference.
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
            UpdateWordArrays();
        }

        // Unhide a set number of random words from those that are hidden.
        public void UnhideRandomWords(int count)
        {
            // Get a list of currently hidden words.
            List<Words> hiddenList = _words.Where(w => w.IsHidden).ToList();
            if (hiddenList.Count == 0)
            {
                return; // Nothing to unhide.
            }

            // Unhide up to 'count' words.
            for (int i = 0; i < count; i++)
            {
                if (hiddenList.Count == 0)
                {
                    break; // No more hidden words.
                }

                int index = _random.Next(hiddenList.Count);
                hiddenList[index].Unhide();
                hiddenList.RemoveAt(index); // Remove it so it's not unhidden twice.
            }
            UpdateWordArrays();
        }
    }
}
