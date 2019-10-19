namespace TextAnalyticsService.Models
{
    public class TextStatistics
    {
        public int WordCount { get; set; }

        public int HyphenCount { get; set; }

        public int SpaceCount { get; set; }

        public override string ToString()
        {
            return $"TextStatics: Submitted text file contains {HyphenCount} hyphens, {SpaceCount} spaces and {WordCount} words";
        }
    }
}
