using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TextAnalyticsService.ErrorHandling
{
    public class HttpResponseException : Exception
    {
        public int Status { get; set; }

        public object Value { get; set; }

        public HttpResponseException() { }

        public HttpResponseException(string message) : base(message) { }

        public HttpResponseException(string message, Exception innerException) : base(message, innerException) { }        
    }
}
