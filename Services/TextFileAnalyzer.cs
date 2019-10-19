using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using TextAnalyticsService.Utilities;

namespace TextAnalyticsService.Services
{
    public class TextFileAnalyzer : ITextAnalyzer
    {
        private readonly string fileLocation;

        public TextFileAnalyzer()
        {
            fileLocation = FileManager.GetFileFromSource();
        }
        

        public async Task<int> CountSpecialCharacter(string text, char character)
        {
            
        }

        public async Task<int> CountWords(string text)
        {
            using var streamReader = new StreamReader(text);

            int wordCounter = default;
            string delim = " ,.?!*+-<>/\\[]{}~#$%^&=";
            string[] fields = default;
            string line = default;

            while (!streamReader.EndOfStream)
            {
                line = await streamReader.ReadLineAsync().ConfigureAwait(false);
                fields = line.Trim().Split(delim.ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
                wordCounter += fields.Length;
            }
            streamReader.Close();
            return wordCounter;
        }
    }
}
