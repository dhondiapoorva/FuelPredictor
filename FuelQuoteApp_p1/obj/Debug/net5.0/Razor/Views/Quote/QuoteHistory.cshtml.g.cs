#pragma checksum "E:\UH\Summer\SD\FuelQuoteApp_p1\FuelQuoteApp_p1\Views\Quote\QuoteHistory.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9ac2da1418a4f7b3c2932753d1f94c721e55d964"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Quote_QuoteHistory), @"mvc.1.0.view", @"/Views/Quote/QuoteHistory.cshtml")]
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
#line 1 "E:\UH\Summer\SD\FuelQuoteApp_p1\FuelQuoteApp_p1\Views\_ViewImports.cshtml"
using FuelQuoteApp_p1;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\UH\Summer\SD\FuelQuoteApp_p1\FuelQuoteApp_p1\Views\_ViewImports.cshtml"
using FuelQuoteApp_p1.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9ac2da1418a4f7b3c2932753d1f94c721e55d964", @"/Views/Quote/QuoteHistory.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c465a0bb5d5bcf1189a5f5a84c636f7905c3d294", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Quote_QuoteHistory : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<FuelQuoteApp_p1.Models.Quote.FQuote>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "E:\UH\Summer\SD\FuelQuoteApp_p1\FuelQuoteApp_p1\Views\Quote\QuoteHistory.cshtml"
  
    ViewData["Title"] = "QuoteHistory";

#line default
#line hidden
#nullable disable
            WriteLiteral("<style>\r\n .title\r\n{\r\n    text-align:center;\r\n    font-family:futura;\r\n    font-weight:bold;\r\n    color:#DA252A;\r\n    \r\n    font-size:50px;\r\n}\r\n#create_new\r\n{\r\n     color:#4d709e;\r\n}\r\n\r\n</style>\r\n\r\n\r\n<h1 class=\"title\">Quote History</h1>\r\n\r\n");
            WriteLiteral("<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
#nullable restore
#line 33 "E:\UH\Summer\SD\FuelQuoteApp_p1\FuelQuoteApp_p1\Views\Quote\QuoteHistory.cshtml"
           Write(Html.DisplayNameFor(model => model.GallonsRequested));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 36 "E:\UH\Summer\SD\FuelQuoteApp_p1\FuelQuoteApp_p1\Views\Quote\QuoteHistory.cshtml"
           Write(Html.DisplayNameFor(model => model.DeliveryAddress));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 39 "E:\UH\Summer\SD\FuelQuoteApp_p1\FuelQuoteApp_p1\Views\Quote\QuoteHistory.cshtml"
           Write(Html.DisplayNameFor(model => model.DateRequested));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 42 "E:\UH\Summer\SD\FuelQuoteApp_p1\FuelQuoteApp_p1\Views\Quote\QuoteHistory.cshtml"
           Write(Html.DisplayNameFor(model => model.PricePerGallon));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 45 "E:\UH\Summer\SD\FuelQuoteApp_p1\FuelQuoteApp_p1\Views\Quote\QuoteHistory.cshtml"
           Write(Html.DisplayNameFor(model => model.TotalAmount));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 51 "E:\UH\Summer\SD\FuelQuoteApp_p1\FuelQuoteApp_p1\Views\Quote\QuoteHistory.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
#nullable restore
#line 54 "E:\UH\Summer\SD\FuelQuoteApp_p1\FuelQuoteApp_p1\Views\Quote\QuoteHistory.cshtml"
           Write(Html.DisplayFor(modelItem => item.GallonsRequested));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 57 "E:\UH\Summer\SD\FuelQuoteApp_p1\FuelQuoteApp_p1\Views\Quote\QuoteHistory.cshtml"
           Write(Html.DisplayFor(modelItem => item.DeliveryAddress));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 60 "E:\UH\Summer\SD\FuelQuoteApp_p1\FuelQuoteApp_p1\Views\Quote\QuoteHistory.cshtml"
           Write(Html.DisplayFor(modelItem => item.DateRequested));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 63 "E:\UH\Summer\SD\FuelQuoteApp_p1\FuelQuoteApp_p1\Views\Quote\QuoteHistory.cshtml"
           Write(Html.DisplayFor(modelItem => item.PricePerGallon));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 66 "E:\UH\Summer\SD\FuelQuoteApp_p1\FuelQuoteApp_p1\Views\Quote\QuoteHistory.cshtml"
           Write(Html.DisplayFor(modelItem => item.TotalAmount));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 69 "E:\UH\Summer\SD\FuelQuoteApp_p1\FuelQuoteApp_p1\Views\Quote\QuoteHistory.cshtml"
           Write(Html.ActionLink("Edit", "Edit", new { /* id=item.PrimaryKey */ }));

#line default
#line hidden
#nullable disable
            WriteLiteral(" |\r\n                ");
#nullable restore
#line 70 "E:\UH\Summer\SD\FuelQuoteApp_p1\FuelQuoteApp_p1\Views\Quote\QuoteHistory.cshtml"
           Write(Html.ActionLink("Details", "Details", new { /* id=item.PrimaryKey */ }));

#line default
#line hidden
#nullable disable
            WriteLiteral(" |\r\n                ");
#nullable restore
#line 71 "E:\UH\Summer\SD\FuelQuoteApp_p1\FuelQuoteApp_p1\Views\Quote\QuoteHistory.cshtml"
           Write(Html.ActionLink("Delete", "Delete", new { /* id=item.PrimaryKey */ }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n");
#nullable restore
#line 74 "E:\UH\Summer\SD\FuelQuoteApp_p1\FuelQuoteApp_p1\Views\Quote\QuoteHistory.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<FuelQuoteApp_p1.Models.Quote.FQuote>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
