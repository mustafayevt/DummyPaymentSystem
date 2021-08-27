using System;
using System.ComponentModel.DataAnnotations;

namespace PaymentProviderLogic.Models
{
    public class CreatePaymentRequest
    {
        public CreatePaymentRequest()
        {
            OrderId = Guid.NewGuid().ToString();
        }
        [Required]
        public string OrderId { get; set; }

        [Required]
        public int Amount { get; set; }

        [Required]
        public string Currency { get; set; }

        [Required]
        public string Country { get; set; }

        [Required]
        public string CardNumber { get; set; }

        [Required]
        public string CardHolder { get; set; }

        [Required]
        public string CardExpiryDate { get; set; }

        [Required]
        public string Cvv { get; set; }
    }

}