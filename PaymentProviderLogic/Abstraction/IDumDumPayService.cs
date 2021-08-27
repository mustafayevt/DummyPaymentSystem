using System.Threading.Tasks;
using PaymentProviderLogic.Models;

namespace PaymentProviderLogic.Abstraction
{
    /// <summary>
    /// DumDumPay payment provider service.
    /// </summary>
    public interface IDumDumPayService
    {
        /// <summary>
        /// Creates payment request on DumDumPayService.
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        Task<CreatePaymentResponse> CreatePayment(CreatePaymentRequest request);

        /// <summary>
        /// Sends confirmation request to DumDumPayment service.
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        Task<ConfirmPaymentResponse> ConfirmPayment(ConfirmPaymentRequest request);

        /// <summary>
        /// Returns status of payment.
        /// </summary>
        /// <param name="transactionId"></param>
        /// <returns></returns>
        Task<ConfirmPaymentResponse> PaymentStatus(string transactionId);
    }
}