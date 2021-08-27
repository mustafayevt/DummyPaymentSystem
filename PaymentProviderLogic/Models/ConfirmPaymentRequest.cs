using System.ComponentModel.DataAnnotations;

namespace PaymentProviderLogic.Models
{
    public class ConfirmPaymentRequest
    {
        [Required]
        public string TransactionId { get; set; }
        
        [Required]
        public string PaRes { get; set; }
    }
}