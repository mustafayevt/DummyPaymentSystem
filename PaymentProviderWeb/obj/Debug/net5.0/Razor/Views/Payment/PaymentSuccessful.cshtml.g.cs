#pragma checksum "C:\Users\Lenovo\Documents\React 17 and ASP.NET Core 6\DummyPaymentSystem\PaymentProviderWeb\Views\Payment\PaymentSuccessful.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1aceb6159dd42b71088e3e534ca122e29d32bf8e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Payment_PaymentSuccessful), @"mvc.1.0.view", @"/Views/Payment/PaymentSuccessful.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\Lenovo\Documents\React 17 and ASP.NET Core 6\DummyPaymentSystem\PaymentProviderWeb\Views\_ViewImports.cshtml"
using PaymentProviderWeb;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1aceb6159dd42b71088e3e534ca122e29d32bf8e", @"/Views/Payment/PaymentSuccessful.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ca3f96448ab671ad14229e8f07b3fe99d0e56b1d", @"/Views/_ViewImports.cshtml")]
    public class Views_Payment_PaymentSuccessful : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<PaymentProviderLogic.Models.ConfirmPaymentResponse>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\Lenovo\Documents\React 17 and ASP.NET Core 6\DummyPaymentSystem\PaymentProviderWeb\Views\Payment\PaymentSuccessful.cshtml"
  
    ViewBag.Title = "Payment successful";
    Layout = "_Layout";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"alert alert-success\" role=\"alert\">\r\n    <h2>Your payment done successfully.</h2>\r\n</div>\r\n\r\n");
#nullable restore
#line 11 "C:\Users\Lenovo\Documents\React 17 and ASP.NET Core 6\DummyPaymentSystem\PaymentProviderWeb\Views\Payment\PaymentSuccessful.cshtml"
Write(Html.RenderPartialAsync("_PaymentInfo", Model));

#line default
#line hidden
#nullable disable
            WriteLiteral(";");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<PaymentProviderLogic.Models.ConfirmPaymentResponse> Html { get; private set; }
    }
}
#pragma warning restore 1591
