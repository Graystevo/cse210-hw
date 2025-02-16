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

            // split the scripture text into individual words.
            string[] splitWords = text.Split(' ');
            foreach (string word in splitWords)
            {
                _words.Add(new Words(word));
            }

            _random = new Random();
            UpdateWordArrays();
        }

        // update our arrays to reflect the current state of _words.
        private void UpdateWordArrays()
        {
            _allWords = _words.ToArray();
            _hiddenWords = _words.Where(w => w.IsHidden).ToArray();
        }

        // display the scripture with its reference.
        public void Display()
        {
            Console.WriteLine(Reference.ToString());
            foreach (var word in _words)
            {
                Console.Write(word + " ");
            }
            Console.WriteLine();
        }

        // returns true if all words are hidden.
        public bool AllWordsHidden()
        {
            return _words.All(w => w.IsHidden);
        }

        // hide a set number of words at random, but only those that are not already hidden.
        public void HideRandomWords(int count)
        {
            // get list of words that are not yet hidden.
            List<Words> visibleWords = _words.Where(w => !w.IsHidden).ToList();
            if (visibleWords.Count == 0)
            {
                return; // Nothing left to hide.
            }

            // determine how many words we can hide.
            int numberToHide = Math.Min(count, visibleWords.Count);

            for (int i = 0; i < numberToHide; i++)
            {
                // choose a random visible word.
                int index = _random.Next(visibleWords.Count);
                visibleWords[index].Hide();
                // remove it from the list to avoid hiding it again in this iteration.
                visibleWords.RemoveAt(index);
            }

            UpdateWordArrays();
        }

        // unhide a set number of random words from those that are hidden.
        public void UnhideRandomWords(int count)
        {
            // Get a list of currently hidden words.
            List<Words> hiddenList = _words.Where(w => w.IsHidden).ToList();
            if (hiddenList.Count == 0)
            {
                return; // Nothing to unhide.
            }

            // Unhide up to 'count' words.
            int numberToUnhide = Math.Min(count, hiddenList.Count);
            for (int i = 0; i < numberToUnhide; i++)
            {
                int index = _random.Next(hiddenList.Count);
                hiddenList[index].Unhide();
                hiddenList.RemoveAt(index); // Remove it so it's not unhidden twice.
            }
            UpdateWordArrays();
        }
    }
}
