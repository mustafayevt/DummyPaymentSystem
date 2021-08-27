using System.Collections.Generic;

namespace PaymentProviderLogic.Models
{
    public class Error
    {
        public string Type { get; set; }

        public string Message { get; set; }
    }

    public class DumDumErrorModel
    {
        public List<Error> Errors { get; set; }
    }
}