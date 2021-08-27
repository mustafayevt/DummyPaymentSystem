using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.Extensions;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Routing;
using PaymentProviderLogic.Abstraction;
using PaymentProviderLogic.Models;

namespace PaymentProviderWeb.Controllers
{
    public class PaymentController : Controller
    {
        private readonly IDumDumPayService _dumDumPayService;
        private readonly IHttpContextAccessor _httpContextAccessor;

        public static string CurrentTransactionId;

        public PaymentController(IDumDumPayService dumDumPayService, IHttpContextAccessor httpContextAccessor)
        {
            _dumDumPayService = dumDumPayService;
            _httpContextAccessor = httpContextAccessor;
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View(new CreatePaymentRequest());
        }

        [HttpPost]
        public async Task<IActionResult> Create(CreatePaymentRequest model)
        {
            if(!ModelState.IsValid)
                return View(model);

            try
            {
                var paymentResponse = await _dumDumPayService.CreatePayment(model);
                CurrentTransactionId = paymentResponse.TransactionId;
                return RedirectToAction("Checkout", paymentResponse);
            }
            catch (Exception e)
            {
                return View("PaymentError", e.Message);
            }
        }

        [HttpGet]
        public IActionResult Checkout(CreatePaymentResponse paymentResponse)
        {
            ViewBag.BaseUrl = _httpContextAccessor.HttpContext?.Request.Scheme + "://" +
                              _httpContextAccessor.HttpContext?.Request.Host.ToString();
            return View(paymentResponse);
        }

        [HttpGet]
        public IActionResult PaymentConfirmation([FromQuery]string md, [FromQuery]string paRes)
        {
            return View(new ConfirmationModel(){Md = md,PaRes = paRes});
        }

        [HttpPost]
        public async Task<IActionResult> PaymentConfirmationConfirm(ConfirmationModel model)
        {
            try
            {
                var confirmModel = new ConfirmPaymentRequest
                {
                    PaRes = model.PaRes,
                    TransactionId = CurrentTransactionId
                };
                
                var paymentResponse = await _dumDumPayService.ConfirmPayment(confirmModel);
                return View("PaymentSuccessful", paymentResponse);
            }
            catch (Exception e)
            {
                return View("PaymentError", e.Message);
            }
        }
        
        [HttpPost]
        public IActionResult PaymentConfirmationCancel(string paRes)
        {
            return RedirectToAction("Create");
        }

        [HttpGet]
        public IActionResult PaymentStatus()
        {
            return View(new ConfirmPaymentResponse());
        }

        [HttpPost]
        public async Task<IActionResult> PaymentStatus(ConfirmPaymentResponse model)
        {
            try
            {
                var paymentResponse = await _dumDumPayService.PaymentStatus(model.TransactionId);
                return View(paymentResponse);
            }
            catch (Exception e)
            {
                return View("PaymentError", e.Message);
            }
        }
    }
}