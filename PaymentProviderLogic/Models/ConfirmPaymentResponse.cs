using Newtonsoft.Json;

namespace PaymentProviderLogic.Models
{
    public class ConfirmPaymentResponse
    {
        public string TransactionId { get; set; }
        public string Status { get; set; }
        public int Amount { get; set; }
        public string Currency { get; set; }
        public string OrderId { get; set; }
        public string LastFourDigits { get; set; }
    }

    public class ConfirmPaymentResponseWrapper
    {
        [JsonProperty("result")]
        public ConfirmPaymentResponse ConfirmPaymentResponse { get; set; }
    }
}