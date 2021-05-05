using System.Collections.Generic;
using System.Linq;


namespace WordPattern
{
    public class WordPattern
    {
        public static bool TextMatchesPattern(string text, string patternExpected)
        {
            string[] wordsFromText = text.Split(' ');
            char[] patternActual = patternExpected.ToCharArray();
            int i = 0;
            
            if(wordsFromText.Length != patternActual.Length)
            {
                return false;
            }

            Dictionary<char, string> patternWordPairs = new Dictionary<char, string> { };
            foreach(char patternValue in patternActual)
            {
                if (patternWordPairs.TryGetValue(patternValue, out string word))
                {
                    if (!wordsFromText[i].Equals(word))
                    {
                        return false;
                    }
                }
                else
                {
                    patternWordPairs.Add(patternValue, wordsFromText[i]);
                }
                i++;
            }

            return true;
        }
    }
}
