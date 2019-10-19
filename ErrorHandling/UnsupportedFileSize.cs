using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TextAnalyticsService.Validation;

namespace TextAnalyticsService.ErrorHandling
{
    public class UnsupportedFileSize : ValidateUpload
    {
        public UnsupportedFileSize()
        {
            IsValid = false;            
        }

        public override string Message => "File size exceeded stipulated value";        
    }
}
