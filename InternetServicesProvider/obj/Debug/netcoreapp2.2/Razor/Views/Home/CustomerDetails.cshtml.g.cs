#pragma checksum "D:\IIHT\Task-16\InMemory\InternetServicesProvider\Views\Home\CustomerDetails.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6feaff80c9e5607f8d9b1d3820136bc7eef432f2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_CustomerDetails), @"mvc.1.0.view", @"/Views/Home/CustomerDetails.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/CustomerDetails.cshtml", typeof(AspNetCore.Views_Home_CustomerDetails))]
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
#line 1 "D:\IIHT\Task-16\InMemory\InternetServicesProvider\Views\_ViewImports.cshtml"
using InternetServicesProvider;

#line default
#line hidden
#line 2 "D:\IIHT\Task-16\InMemory\InternetServicesProvider\Views\_ViewImports.cshtml"
using InternetServicesProvider.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6feaff80c9e5607f8d9b1d3820136bc7eef432f2", @"/Views/Home/CustomerDetails.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"15bcf470f680e2f924d80854af8881d535b0312a", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_CustomerDetails : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<InternetServicesProvider.Entities.Customer>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "D:\IIHT\Task-16\InMemory\InternetServicesProvider\Views\Home\CustomerDetails.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
            BeginContext(94, 313, true);
            WriteLiteral(@"<div class=""card"" style=""width:100%; margin-top:10px;"">
    <div class=""card-header bg-dark text-white"">
        <h5>Internet Services Customer Details </h5>
    </div>
    <div class=""card-body"">
        <table class=""table table-borderless"">
            <tr>
                <td>
                    <b>");
            EndContext();
            BeginContext(408, 38, false);
#line 13 "D:\IIHT\Task-16\InMemory\InternetServicesProvider\Views\Home\CustomerDetails.cshtml"
                  Write(Html.DisplayNameFor(m => m.CustomerId));

#line default
#line hidden
            EndContext();
            BeginContext(446, 49, true);
            WriteLiteral("</b>\r\n                </td>\r\n                <td>");
            EndContext();
            BeginContext(496, 34, false);
#line 15 "D:\IIHT\Task-16\InMemory\InternetServicesProvider\Views\Home\CustomerDetails.cshtml"
               Write(Html.DisplayFor(m => m.CustomerId));

#line default
#line hidden
            EndContext();
            BeginContext(530, 52, true);
            WriteLiteral("</td>\r\n                <td>\r\n                    <b>");
            EndContext();
            BeginContext(583, 36, false);
#line 17 "D:\IIHT\Task-16\InMemory\InternetServicesProvider\Views\Home\CustomerDetails.cshtml"
                  Write(Html.DisplayNameFor(m => m.UserName));

#line default
#line hidden
            EndContext();
            BeginContext(619, 49, true);
            WriteLiteral("</b>\r\n                </td>\r\n                <td>");
            EndContext();
            BeginContext(669, 32, false);
#line 19 "D:\IIHT\Task-16\InMemory\InternetServicesProvider\Views\Home\CustomerDetails.cshtml"
               Write(Html.DisplayFor(m => m.UserName));

#line default
#line hidden
            EndContext();
            BeginContext(701, 89, true);
            WriteLiteral("</td>\r\n            </tr>\r\n            <tr>\r\n                <td>\r\n                    <b>");
            EndContext();
            BeginContext(791, 39, false);
#line 23 "D:\IIHT\Task-16\InMemory\InternetServicesProvider\Views\Home\CustomerDetails.cshtml"
                  Write(Html.DisplayNameFor(m => m.PhoneNumber));

#line default
#line hidden
            EndContext();
            BeginContext(830, 49, true);
            WriteLiteral("</b>\r\n                </td>\r\n                <td>");
            EndContext();
            BeginContext(880, 35, false);
#line 25 "D:\IIHT\Task-16\InMemory\InternetServicesProvider\Views\Home\CustomerDetails.cshtml"
               Write(Html.DisplayFor(m => m.PhoneNumber));

#line default
#line hidden
            EndContext();
            BeginContext(915, 52, true);
            WriteLiteral("</td>\r\n                <td>\r\n                    <b>");
            EndContext();
            BeginContext(968, 35, false);
#line 27 "D:\IIHT\Task-16\InMemory\InternetServicesProvider\Views\Home\CustomerDetails.cshtml"
                  Write(Html.DisplayNameFor(m => m.Address));

#line default
#line hidden
            EndContext();
            BeginContext(1003, 49, true);
            WriteLiteral("</b>\r\n                </td>\r\n                <td>");
            EndContext();
            BeginContext(1053, 31, false);
#line 29 "D:\IIHT\Task-16\InMemory\InternetServicesProvider\Views\Home\CustomerDetails.cshtml"
               Write(Html.DisplayFor(m => m.Address));

#line default
#line hidden
            EndContext();
            BeginContext(1084, 89, true);
            WriteLiteral("</td>\r\n            </tr>\r\n            <tr>\r\n                <td>\r\n                    <b>");
            EndContext();
            BeginContext(1174, 33, false);
#line 33 "D:\IIHT\Task-16\InMemory\InternetServicesProvider\Views\Home\CustomerDetails.cshtml"
                  Write(Html.DisplayNameFor(m => m.Email));

#line default
#line hidden
            EndContext();
            BeginContext(1207, 49, true);
            WriteLiteral("</b>\r\n                </td>\r\n                <td>");
            EndContext();
            BeginContext(1257, 29, false);
#line 35 "D:\IIHT\Task-16\InMemory\InternetServicesProvider\Views\Home\CustomerDetails.cshtml"
               Write(Html.DisplayFor(m => m.Email));

#line default
#line hidden
            EndContext();
            BeginContext(1286, 52, true);
            WriteLiteral("</td>\r\n                <td>\r\n                    <b>");
            EndContext();
            BeginContext(1339, 31, false);
#line 37 "D:\IIHT\Task-16\InMemory\InternetServicesProvider\Views\Home\CustomerDetails.cshtml"
                  Write(Html.DisplayNameFor(m => m.Age));

#line default
#line hidden
            EndContext();
            BeginContext(1370, 49, true);
            WriteLiteral("</b>\r\n                </td>\r\n                <td>");
            EndContext();
            BeginContext(1420, 27, false);
#line 39 "D:\IIHT\Task-16\InMemory\InternetServicesProvider\Views\Home\CustomerDetails.cshtml"
               Write(Html.DisplayFor(m => m.Age));

#line default
#line hidden
            EndContext();
            BeginContext(1447, 89, true);
            WriteLiteral("</td>\r\n            </tr>\r\n            <tr>\r\n                <td>\r\n                    <b>");
            EndContext();
            BeginContext(1537, 34, false);
#line 43 "D:\IIHT\Task-16\InMemory\InternetServicesProvider\Views\Home\CustomerDetails.cshtml"
                  Write(Html.DisplayNameFor(m => m.Region));

#line default
#line hidden
            EndContext();
            BeginContext(1571, 49, true);
            WriteLiteral("</b>\r\n                </td>\r\n                <td>");
            EndContext();
            BeginContext(1621, 30, false);
#line 45 "D:\IIHT\Task-16\InMemory\InternetServicesProvider\Views\Home\CustomerDetails.cshtml"
               Write(Html.DisplayFor(m => m.Region));

#line default
#line hidden
            EndContext();
            BeginContext(1651, 52, true);
            WriteLiteral("</td>\r\n                <td>\r\n                    <b>");
            EndContext();
            BeginContext(1704, 40, false);
#line 47 "D:\IIHT\Task-16\InMemory\InternetServicesProvider\Views\Home\CustomerDetails.cshtml"
                  Write(Html.DisplayNameFor(m => m.BusinessType));

#line default
#line hidden
            EndContext();
            BeginContext(1744, 49, true);
            WriteLiteral("</b>\r\n                </td>\r\n                <td>");
            EndContext();
            BeginContext(1794, 36, false);
#line 49 "D:\IIHT\Task-16\InMemory\InternetServicesProvider\Views\Home\CustomerDetails.cshtml"
               Write(Html.DisplayFor(m => m.BusinessType));

#line default
#line hidden
            EndContext();
            BeginContext(1830, 69, true);
            WriteLiteral("</td>\r\n            </tr>\r\n        </table>\r\n        <p>\r\n            ");
            EndContext();
            BeginContext(1900, 84, false);
#line 53 "D:\IIHT\Task-16\InMemory\InternetServicesProvider\Views\Home\CustomerDetails.cshtml"
       Write(Html.ActionLink("Back To Home", "Index", "Home", new { @class = "btn btn-primary" }));

#line default
#line hidden
            EndContext();
            BeginContext(1984, 34, true);
            WriteLiteral("\r\n        </p>\r\n    </div>\r\n</div>");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<InternetServicesProvider.Entities.Customer> Html { get; private set; }
    }
}
#pragma warning restore 1591
