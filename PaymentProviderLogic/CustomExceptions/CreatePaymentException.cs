using System;
using System.Linq;
using PaymentProviderLogic.Models;

namespace PaymentProviderLogic.CustomExceptions
{
    public class CreatePaymentException : Exception
    {
        private readonly DumDumErrorModel _errorModel;
        public override string Message => _errorModel.Errors.Any() ? string.Join(", ", _errorModel.Errors.SelectMany(x=>x.Message)) : base.Message; 

        public CreatePaymentException(DumDumErrorModel errorModel)
        {
            _errorModel = errorModel;
        }
    }
}