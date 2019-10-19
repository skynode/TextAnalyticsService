using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TextAnalyticsService.Services
{
    public class TextAnalyzer : ITextAnalyzer
    {
        public async Task<int> CountSpecialCharacter(string text, char character)
        {
            int characterCount = default;
            if (text is object)
            {
                foreach (char c in text)
                {
                    if (c.Equals(character))
                    {
                        characterCount++;
                    }
                }
            }
            return await Task.FromResult(characterCount).ConfigureAwait(false);
        }

        public async Task<int> CountWords(string text)
        {
            using var textReader = new StringReader(text);

            int wordCounter = default;
            string delim = " ,.?!*+-<>/\\[]{}~#$%^&=";
            string[] fields = default;
            string line = default;

            // we don't know the size of the text here, will need to implement some buffering
            
            return wordCounter;
        }
    }
}
