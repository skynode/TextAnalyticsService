namespace TextAnalyticsService.ErrorHandling
{
    using TextAnalyticsService.Validation;

    public class UnsupportedFileFormat : ValidateUpload
    {
        public UnsupportedFileFormat()
        {
            IsValid = false;
        }

        public override string Message => "Unsupported file format";
    }
}
