using System;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;
using PaymentProviderLogic.Abstraction;
using PaymentProviderLogic.CustomExceptions;
using PaymentProviderLogic.Models;
using Serilog;
using Serilog.Events;

namespace PaymentProviderLogic.Implementation
{
    public class DumDumPayService : IDumDumPayService
    {
        //There settings should comes from a secured appsettings in real app.
        private readonly string MerchantId = "6fc3aa31-7afd-4df1-825f-192e60950ca1";
        private readonly string SecretKey = "53cr3t";
        private readonly string BaseUrl = "https://dumdumpay.site/api/";

        private HttpClient HttpClient => new HttpClient
        {
            BaseAddress = new Uri(BaseUrl),
            DefaultRequestHeaders = { { "mechant-id", MerchantId }, { "secret-key", SecretKey } }
        };

        public DumDumPayService()
        {
            Log.Logger = new LoggerConfiguration()
                .MinimumLevel.Information()
                .WriteTo.Console(restrictedToMinimumLevel: LogEventLevel.Information)
                .CreateLogger();
        }

        public async Task<CreatePaymentResponse> CreatePayment(CreatePaymentRequest request)
        {
            using (HttpClient)
            {
                Log.Information("Sending create payment request..");

                var response = await HttpClient.PostAsync("payment/create",
                    new StringContent(JsonConvert.SerializeObject(request), System.Text.Encoding.Default,
                        "application/json"));

                if (response.StatusCode == HttpStatusCode.BadRequest)
                {
                    var errorModel =
                        JsonConvert.DeserializeObject<DumDumErrorModel>(await response.Content.ReadAsStringAsync());

                    errorModel?.Errors.ForEach(x => { Log.Error($"Error type : {x.Type}\nMessage : {x.Message}"); });

                    throw new CreatePaymentException(errorModel);
                }

                else if (response.StatusCode == HttpStatusCode.Unauthorized)
                {
                    Log.Error("Not authorized to the provider");
                    throw new UnauthorizedAccessException();
                }

                Log.Information("Payment created successfully");

                return JsonConvert
                    .DeserializeObject<CreatePaymentResponseWrapper>(await response.Content.ReadAsStringAsync())
                    ?.CreatePaymentResponse;
            }
        }

        public async Task<ConfirmPaymentResponse> ConfirmPayment(ConfirmPaymentRequest request)
        {
            using (HttpClient)
            {
                Log.Information("Sending confirmation request..");

                var response = await HttpClient.PostAsync("payment/confirm",
                    new StringContent(JsonConvert.SerializeObject(request), System.Text.Encoding.Default,
                        "application/json"));

                if (response.StatusCode == HttpStatusCode.BadRequest)
                {
                    var errorModel =
                        JsonConvert.DeserializeObject<DumDumErrorModel>(await response.Content.ReadAsStringAsync());

                    errorModel?.Errors.ForEach(x => { Log.Error($"Error type : {x.Type}\nMessage : {x.Message}"); });

                    throw new CreatePaymentException(errorModel);
                }

                else if (response.StatusCode == HttpStatusCode.Unauthorized)
                {
                    Log.Error("Not authorized to the provider");
                    throw new UnauthorizedAccessException();
                }

                Log.Information("Payment confirmation success");

                return JsonConvert
                    .DeserializeObject<ConfirmPaymentResponseWrapper>(await response.Content.ReadAsStringAsync())
                    ?.ConfirmPaymentResponse;
            }
        }

        public async Task<ConfirmPaymentResponse> PaymentStatus(string transactionId)
        {
            using (HttpClient)
            {
                Log.Information("Sending confirmation request..");

                var response = await HttpClient.GetAsync($"payment/{transactionId}/status");

                if (response.StatusCode == HttpStatusCode.BadRequest)
                {
                    var errorModel =
                        JsonConvert.DeserializeObject<DumDumErrorModel>(await response.Content.ReadAsStringAsync());

                    errorModel?.Errors.ForEach(x => { Log.Error($"Error type : {x.Type}\nMessage : {x.Message}"); });

                    throw new CreatePaymentException(errorModel);
                }

                else if (response.StatusCode == HttpStatusCode.Unauthorized)
                {
                    Log.Error("Not authorized to the provider");
                    throw new UnauthorizedAccessException();
                }

                Log.Information("Payment confirmation success");

                return JsonConvert
                    .DeserializeObject<ConfirmPaymentResponseWrapper>(await response.Content.ReadAsStringAsync())
                    ?.ConfirmPaymentResponse;
            }
        }
    }
}