using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp
{
    public class annagram
    {
        public bool IsAnagram(string s1, string s2)
        {
            // If one of them are null, they can't be anagrams
            if (s1 == null || s2 == null)
                return false;

            // If they are the same string, then they are an anagram
            if (s1 == s2)
                return true;

            // If they don't have the same lenght, they can't be anagrams
            if (s1.Length != s2.Length)
                return false;

            var charCount = new Dictionary<char, int>();

            // Count characters from first string
            foreach (char c in s1)
            {
                if (charCount.ContainsKey(c))
                    charCount[c]++;
                else
                    charCount[c] = 1;
            }

            // Subtract using second string
            foreach (char c in s2)
            {
                if (!charCount.ContainsKey(c))
                    return false;

                charCount[c]--;

                if (charCount[c] < 0)
                    return false;
            }

            return true;
        }
    }
}
