#pragma checksum "D:\IIHT\Task-16\InMemory\InternetServicesProvider\Views\Home\OrderPlanInfo.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "89db319a8b735381993ea08066ff1ed2cab121df"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_OrderPlanInfo), @"mvc.1.0.view", @"/Views/Home/OrderPlanInfo.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/OrderPlanInfo.cshtml", typeof(AspNetCore.Views_Home_OrderPlanInfo))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"89db319a8b735381993ea08066ff1ed2cab121df", @"/Views/Home/OrderPlanInfo.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"15bcf470f680e2f924d80854af8881d535b0312a", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_OrderPlanInfo : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<InternetServicesProvider.Entities.BookedPlan>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "D:\IIHT\Task-16\InMemory\InternetServicesProvider\Views\Home\OrderPlanInfo.cshtml"
  
    ViewData["Title"] = "Book Plan Details";

#line default
#line hidden
            BeginContext(106, 315, true);
            WriteLiteral(@"<div class=""card"" style=""width:100%; margin-top:10px;"">
    <div class=""card-header bg-dark text-white"">
        <h5>Booked Internet Services Plan Details</h5>
    </div>
    <div class=""card-body"">
        <table class=""table table-borderless"">
            <tr>
                <td>
                    <b>");
            EndContext();
            BeginContext(422, 36, false);
#line 13 "D:\IIHT\Task-16\InMemory\InternetServicesProvider\Views\Home\OrderPlanInfo.cshtml"
                  Write(Html.DisplayNameFor(m => m.UserName));

#line default
#line hidden
            EndContext();
            BeginContext(458, 49, true);
            WriteLiteral("</b>\r\n                </td>\r\n                <td>");
            EndContext();
            BeginContext(508, 32, false);
#line 15 "D:\IIHT\Task-16\InMemory\InternetServicesProvider\Views\Home\OrderPlanInfo.cshtml"
               Write(Html.DisplayFor(m => m.UserName));

#line default
#line hidden
            EndContext();
            BeginContext(540, 52, true);
            WriteLiteral("</td>\r\n                <td>\r\n                    <b>");
            EndContext();
            BeginContext(593, 38, false);
#line 17 "D:\IIHT\Task-16\InMemory\InternetServicesProvider\Views\Home\OrderPlanInfo.cshtml"
                  Write(Html.DisplayNameFor(m => m.CustomerId));

#line default
#line hidden
            EndContext();
            BeginContext(631, 49, true);
            WriteLiteral("</b>\r\n                </td>\r\n                <td>");
            EndContext();
            BeginContext(681, 34, false);
#line 19 "D:\IIHT\Task-16\InMemory\InternetServicesProvider\Views\Home\OrderPlanInfo.cshtml"
               Write(Html.DisplayFor(m => m.CustomerId));

#line default
#line hidden
            EndContext();
            BeginContext(715, 89, true);
            WriteLiteral("</td>\r\n            </tr>\r\n            <tr>\r\n                <td>\r\n                    <b>");
            EndContext();
            BeginContext(805, 36, false);
#line 23 "D:\IIHT\Task-16\InMemory\InternetServicesProvider\Views\Home\OrderPlanInfo.cshtml"
                  Write(Html.DisplayNameFor(m => m.PlanName));

#line default
#line hidden
            EndContext();
            BeginContext(841, 49, true);
            WriteLiteral("</b>\r\n                </td>\r\n                <td>");
            EndContext();
            BeginContext(891, 32, false);
#line 25 "D:\IIHT\Task-16\InMemory\InternetServicesProvider\Views\Home\OrderPlanInfo.cshtml"
               Write(Html.DisplayFor(m => m.PlanName));

#line default
#line hidden
            EndContext();
            BeginContext(923, 52, true);
            WriteLiteral("</td>\r\n                <td>\r\n                    <b>");
            EndContext();
            BeginContext(976, 33, false);
#line 27 "D:\IIHT\Task-16\InMemory\InternetServicesProvider\Views\Home\OrderPlanInfo.cshtml"
                  Write(Html.DisplayNameFor(m => m.Email));

#line default
#line hidden
            EndContext();
            BeginContext(1009, 49, true);
            WriteLiteral("</b>\r\n                </td>\r\n                <td>");
            EndContext();
            BeginContext(1059, 29, false);
#line 29 "D:\IIHT\Task-16\InMemory\InternetServicesProvider\Views\Home\OrderPlanInfo.cshtml"
               Write(Html.DisplayFor(m => m.Email));

#line default
#line hidden
            EndContext();
            BeginContext(1088, 89, true);
            WriteLiteral("</td>\r\n            </tr>\r\n            <tr>\r\n                <td>\r\n                    <b>");
            EndContext();
            BeginContext(1178, 35, false);
#line 33 "D:\IIHT\Task-16\InMemory\InternetServicesProvider\Views\Home\OrderPlanInfo.cshtml"
                  Write(Html.DisplayNameFor(m => m.Address));

#line default
#line hidden
            EndContext();
            BeginContext(1213, 49, true);
            WriteLiteral("</b>\r\n                </td>\r\n                <td>");
            EndContext();
            BeginContext(1263, 31, false);
#line 35 "D:\IIHT\Task-16\InMemory\InternetServicesProvider\Views\Home\OrderPlanInfo.cshtml"
               Write(Html.DisplayFor(m => m.Address));

#line default
#line hidden
            EndContext();
            BeginContext(1294, 69, true);
            WriteLiteral("</td>\r\n            </tr>\r\n        </table>\r\n        <p>\r\n            ");
            EndContext();
            BeginContext(1364, 84, false);
#line 39 "D:\IIHT\Task-16\InMemory\InternetServicesProvider\Views\Home\OrderPlanInfo.cshtml"
       Write(Html.ActionLink("Back to Home", "Index", "Home", new { @class = "btn btn-primary" }));

#line default
#line hidden
            EndContext();
            BeginContext(1448, 34, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<InternetServicesProvider.Entities.BookedPlan> Html { get; private set; }
    }
}
#pragma warning restore 1591
