#pragma checksum "C:\Users\Lenovo\Documents\React 17 and ASP.NET Core 6\DummyPaymentSystem\PaymentProviderWeb\Views\Shared\_PaymentInfo.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c279ddadb1f2373ecb2a11f0ac5d19667bb10522"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__PaymentInfo), @"mvc.1.0.view", @"/Views/Shared/_PaymentInfo.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c279ddadb1f2373ecb2a11f0ac5d19667bb10522", @"/Views/Shared/_PaymentInfo.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ca3f96448ab671ad14229e8f07b3fe99d0e56b1d", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__PaymentInfo : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<PaymentProviderLogic.Models.ConfirmPaymentResponse>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<div class=\"container\">\r\n    <div class=\"row\">\r\n        <h3>Transaction ID: ");
#nullable restore
#line 5 "C:\Users\Lenovo\Documents\React 17 and ASP.NET Core 6\DummyPaymentSystem\PaymentProviderWeb\Views\Shared\_PaymentInfo.cshtml"
                       Write(Model.TransactionId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n    </div>\r\n    <div class=\"row\">\r\n        <h3>Status: ");
#nullable restore
#line 8 "C:\Users\Lenovo\Documents\React 17 and ASP.NET Core 6\DummyPaymentSystem\PaymentProviderWeb\Views\Shared\_PaymentInfo.cshtml"
               Write(Model.Status);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n    </div>\r\n    <div class=\"row\">\r\n        <h3>Amount: ");
#nullable restore
#line 11 "C:\Users\Lenovo\Documents\React 17 and ASP.NET Core 6\DummyPaymentSystem\PaymentProviderWeb\Views\Shared\_PaymentInfo.cshtml"
               Write(Model.Amount);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n    </div>\r\n    <div class=\"row\">\r\n        <h3>Curency: ");
#nullable restore
#line 14 "C:\Users\Lenovo\Documents\React 17 and ASP.NET Core 6\DummyPaymentSystem\PaymentProviderWeb\Views\Shared\_PaymentInfo.cshtml"
                Write(Model.Currency);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n    </div>\r\n    <div class=\"row\">\r\n        <h3>Order ID: ");
#nullable restore
#line 17 "C:\Users\Lenovo\Documents\React 17 and ASP.NET Core 6\DummyPaymentSystem\PaymentProviderWeb\Views\Shared\_PaymentInfo.cshtml"
                 Write(Model.OrderId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n    </div>\r\n    <div class=\"row\">\r\n        <h3>Last Four Digits: ");
#nullable restore
#line 20 "C:\Users\Lenovo\Documents\React 17 and ASP.NET Core 6\DummyPaymentSystem\PaymentProviderWeb\Views\Shared\_PaymentInfo.cshtml"
                         Write(Model.LastFourDigits);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n    </div>\r\n</div>");
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