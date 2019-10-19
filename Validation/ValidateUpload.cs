namespace TextAnalyticsService.Validation
{
    public abstract class ValidateUpload
    {
        public bool IsValid { get; set; }

        public virtual string Message { get; } = "File not supported";
    }
}
