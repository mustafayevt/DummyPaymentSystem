using Newtonsoft.Json;

namespace PaymentProviderLogic.Models
{
    public class CreatePaymentResponse
    {
        public string TransactionId { get; set; }

        public string TransactionStatus { get; set; }

        public string PaReq { get; set; }

        public string Url { get; set; }

        public string Method { get; set; }
    }

    public class CreatePaymentResponseWrapper
    {
        [JsonProperty("result")]
        public CreatePaymentResponse CreatePaymentResponse { get; set; }
    }
}