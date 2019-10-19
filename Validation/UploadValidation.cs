using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TextAnalyticsService.Validation
{
    public class UploadValidation : ValidateUpload
    {
        private readonly int _fileSize;
        private readonly string _fileFormat;
        private string _message;

        public override string Message => _message;

        public UploadValidation(int fileSize, string fileFormat)
        {
            _fileSize = fileSize;
            _fileFormat = fileFormat;                          
        }

        public static bool ValidateFileSize()
        {
            // op
            return true;
        }

        public static bool ValidateFileFormat()
        {
            // op
            return true;
        }
    }
}
