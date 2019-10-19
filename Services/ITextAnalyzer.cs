namespace TextAnalyticsService.Services
{
    using System.Threading.Tasks;

    public interface ITextAnalyzer
    {
        Task<int> CountWords(string text);

        Task<int> CountSpecialCharacter(string text, char character);
    }
}
