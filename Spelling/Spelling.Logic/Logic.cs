/*
 * Developer : Matt Smith (matt@matt40k.co.uk)
 * All code (c) Matthew Smith all rights reserved
 */

using System;

namespace Matt40k.Spelling
{
    public class Logic
    {
        private int? _validMaxLength = 5;

        public int? GetWordLength(string word)
        {
            // If the name is null or empty return null length
            if (string.IsNullOrEmpty(word))
                return null;

            // Get the word length
            return word.Length;
        }

        public bool IsValidWord(string word)
        {
            int? wordLength = GetWordLength(word);

            if (wordLength == null || wordLength == 0)
            {
                // Word length is empty
                return false;
            }
            if (wordLength > _validMaxLength)
            {
                // Word is too long
                return false;
            }

            // Word is ok
            return true;
        }
    }
}
