#pragma checksum "D:\IIHT\Task-16\InMemory\InternetServicesProvider\Views\Home\RegisterNewCustomer.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ff8905e4abb487b21af649e4f37a2cdc77f868e0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_RegisterNewCustomer), @"mvc.1.0.view", @"/Views/Home/RegisterNewCustomer.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/RegisterNewCustomer.cshtml", typeof(AspNetCore.Views_Home_RegisterNewCustomer))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ff8905e4abb487b21af649e4f37a2cdc77f868e0", @"/Views/Home/RegisterNewCustomer.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"15bcf470f680e2f924d80854af8881d535b0312a", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_RegisterNewCustomer : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<InternetServicesProvider.BusinessLayer.ViewModels.CustomerViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("text-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationMessageTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "D:\IIHT\Task-16\InMemory\InternetServicesProvider\Views\Home\RegisterNewCustomer.cshtml"
  
    ViewData["Title"] = "Placeorder";

#line default
#line hidden
            BeginContext(122, 189, true);
            WriteLiteral("\r\n<div class=\"card\" style=\"width:100%; margin:10px;\">\r\n    <div class=\"card-header bg-success text-white\">\r\n        <h5>Register New Customer</h5>\r\n    </div>\r\n    <div class=\"card-body\">\r\n");
            EndContext();
#line 11 "D:\IIHT\Task-16\InMemory\InternetServicesProvider\Views\Home\RegisterNewCustomer.cshtml"
         using (Html.BeginForm())
        {
            

#line default
#line hidden
            BeginContext(370, 23, false);
#line 13 "D:\IIHT\Task-16\InMemory\InternetServicesProvider\Views\Home\RegisterNewCustomer.cshtml"
       Write(Html.AntiForgeryToken());

#line default
#line hidden
            EndContext();
            BeginContext(408, 28, false);
#line 14 "D:\IIHT\Task-16\InMemory\InternetServicesProvider\Views\Home\RegisterNewCustomer.cshtml"
       Write(Html.ValidationSummary(true));

#line default
#line hidden
            EndContext();
            BeginContext(438, 141, true);
            WriteLiteral("            <div class=\"row\">\r\n                <div class=\"col-md-6\">\r\n                    <div class=\"form-group\">\r\n                        ");
            EndContext();
            BeginContext(580, 30, false);
#line 18 "D:\IIHT\Task-16\InMemory\InternetServicesProvider\Views\Home\RegisterNewCustomer.cshtml"
                   Write(Html.LabelFor(m => m.UserName));

#line default
#line hidden
            EndContext();
            BeginContext(610, 26, true);
            WriteLiteral("\r\n                        ");
            EndContext();
            BeginContext(637, 65, false);
#line 19 "D:\IIHT\Task-16\InMemory\InternetServicesProvider\Views\Home\RegisterNewCustomer.cshtml"
                   Write(Html.TextBoxFor(m => m.UserName, new { @class = "form-control" }));

#line default
#line hidden
            EndContext();
            BeginContext(702, 26, true);
            WriteLiteral("\r\n                        ");
            EndContext();
            BeginContext(728, 63, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("span", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ff8905e4abb487b21af649e4f37a2cdc77f868e05838", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationMessageTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper);
#line 20 "D:\IIHT\Task-16\InMemory\InternetServicesProvider\Views\Home\RegisterNewCustomer.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.UserName);

#line default
#line hidden
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-validation-for", __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(791, 164, true);
            WriteLiteral("\r\n                    </div>\r\n                </div>\r\n                <div class=\"col-md-6\">\r\n                    <div class=\"form-group\">\r\n                        ");
            EndContext();
            BeginContext(956, 33, false);
#line 25 "D:\IIHT\Task-16\InMemory\InternetServicesProvider\Views\Home\RegisterNewCustomer.cshtml"
                   Write(Html.LabelFor(m => m.PhoneNumber));

#line default
#line hidden
            EndContext();
            BeginContext(989, 26, true);
            WriteLiteral("\r\n                        ");
            EndContext();
            BeginContext(1016, 68, false);
#line 26 "D:\IIHT\Task-16\InMemory\InternetServicesProvider\Views\Home\RegisterNewCustomer.cshtml"
                   Write(Html.TextBoxFor(m => m.PhoneNumber, new { @class = "form-control" }));

#line default
#line hidden
            EndContext();
            BeginContext(1084, 26, true);
            WriteLiteral("\r\n                        ");
            EndContext();
            BeginContext(1110, 66, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("span", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ff8905e4abb487b21af649e4f37a2cdc77f868e08532", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationMessageTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper);
#line 27 "D:\IIHT\Task-16\InMemory\InternetServicesProvider\Views\Home\RegisterNewCustomer.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.PhoneNumber);

#line default
#line hidden
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-validation-for", __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1176, 215, true);
            WriteLiteral("\r\n                    </div>\r\n                </div>\r\n            </div>\r\n            <div class=\"row\">\r\n                <div class=\"col-md-6\">\r\n                    <div class=\"form-group\">\r\n                        ");
            EndContext();
            BeginContext(1392, 34, false);
#line 34 "D:\IIHT\Task-16\InMemory\InternetServicesProvider\Views\Home\RegisterNewCustomer.cshtml"
                   Write(Html.LabelFor(m => m.BusinessType));

#line default
#line hidden
            EndContext();
            BeginContext(1426, 26, true);
            WriteLiteral("\r\n                        ");
            EndContext();
            BeginContext(1453, 69, false);
#line 35 "D:\IIHT\Task-16\InMemory\InternetServicesProvider\Views\Home\RegisterNewCustomer.cshtml"
                   Write(Html.TextBoxFor(m => m.BusinessType, new { @class = "form-control" }));

#line default
#line hidden
            EndContext();
            BeginContext(1522, 26, true);
            WriteLiteral("\r\n                        ");
            EndContext();
            BeginContext(1548, 67, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("span", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ff8905e4abb487b21af649e4f37a2cdc77f868e011291", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationMessageTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper);
#line 36 "D:\IIHT\Task-16\InMemory\InternetServicesProvider\Views\Home\RegisterNewCustomer.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.BusinessType);

#line default
#line hidden
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-validation-for", __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1615, 164, true);
            WriteLiteral("\r\n                    </div>\r\n                </div>\r\n                <div class=\"col-md-6\">\r\n                    <div class=\"form-group\">\r\n                        ");
            EndContext();
            BeginContext(1780, 27, false);
#line 41 "D:\IIHT\Task-16\InMemory\InternetServicesProvider\Views\Home\RegisterNewCustomer.cshtml"
                   Write(Html.LabelFor(m => m.Email));

#line default
#line hidden
            EndContext();
            BeginContext(1807, 26, true);
            WriteLiteral("\r\n                        ");
            EndContext();
            BeginContext(1834, 62, false);
#line 42 "D:\IIHT\Task-16\InMemory\InternetServicesProvider\Views\Home\RegisterNewCustomer.cshtml"
                   Write(Html.TextBoxFor(m => m.Email, new { @class = "form-control" }));

#line default
#line hidden
            EndContext();
            BeginContext(1896, 26, true);
            WriteLiteral("\r\n                        ");
            EndContext();
            BeginContext(1922, 60, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("span", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ff8905e4abb487b21af649e4f37a2cdc77f868e013981", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationMessageTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper);
#line 43 "D:\IIHT\Task-16\InMemory\InternetServicesProvider\Views\Home\RegisterNewCustomer.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Email);

#line default
#line hidden
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-validation-for", __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1982, 215, true);
            WriteLiteral("\r\n                    </div>\r\n                </div>\r\n            </div>\r\n            <div class=\"row\">\r\n                <div class=\"col-md-6\">\r\n                    <div class=\"form-group\">\r\n                        ");
            EndContext();
            BeginContext(2198, 25, false);
#line 50 "D:\IIHT\Task-16\InMemory\InternetServicesProvider\Views\Home\RegisterNewCustomer.cshtml"
                   Write(Html.LabelFor(m => m.Age));

#line default
#line hidden
            EndContext();
            BeginContext(2223, 26, true);
            WriteLiteral("\r\n                        ");
            EndContext();
            BeginContext(2250, 60, false);
#line 51 "D:\IIHT\Task-16\InMemory\InternetServicesProvider\Views\Home\RegisterNewCustomer.cshtml"
                   Write(Html.TextBoxFor(m => m.Age, new { @class = "form-control" }));

#line default
#line hidden
            EndContext();
            BeginContext(2310, 26, true);
            WriteLiteral("\r\n                        ");
            EndContext();
            BeginContext(2336, 58, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("span", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ff8905e4abb487b21af649e4f37a2cdc77f868e016717", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationMessageTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper);
#line 52 "D:\IIHT\Task-16\InMemory\InternetServicesProvider\Views\Home\RegisterNewCustomer.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Age);

#line default
#line hidden
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-validation-for", __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2394, 164, true);
            WriteLiteral("\r\n                    </div>\r\n                </div>\r\n                <div class=\"col-md-6\">\r\n                    <div class=\"form-group\">\r\n                        ");
            EndContext();
            BeginContext(2559, 28, false);
#line 57 "D:\IIHT\Task-16\InMemory\InternetServicesProvider\Views\Home\RegisterNewCustomer.cshtml"
                   Write(Html.LabelFor(m => m.Region));

#line default
#line hidden
            EndContext();
            BeginContext(2587, 26, true);
            WriteLiteral("\r\n                        ");
            EndContext();
            BeginContext(2614, 63, false);
#line 58 "D:\IIHT\Task-16\InMemory\InternetServicesProvider\Views\Home\RegisterNewCustomer.cshtml"
                   Write(Html.TextBoxFor(m => m.Region, new { @class = "form-control" }));

#line default
#line hidden
            EndContext();
            BeginContext(2677, 26, true);
            WriteLiteral("\r\n                        ");
            EndContext();
            BeginContext(2703, 61, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("span", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ff8905e4abb487b21af649e4f37a2cdc77f868e019400", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationMessageTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper);
#line 59 "D:\IIHT\Task-16\InMemory\InternetServicesProvider\Views\Home\RegisterNewCustomer.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Region);

#line default
#line hidden
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-validation-for", __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2764, 216, true);
            WriteLiteral("\r\n                    </div>\r\n                </div>\r\n            </div>\r\n            <div class=\"row\">\r\n                <div class=\"col-md-12\">\r\n                    <div class=\"form-group\">\r\n                        ");
            EndContext();
            BeginContext(2981, 29, false);
#line 66 "D:\IIHT\Task-16\InMemory\InternetServicesProvider\Views\Home\RegisterNewCustomer.cshtml"
                   Write(Html.LabelFor(m => m.Address));

#line default
#line hidden
            EndContext();
            BeginContext(3010, 26, true);
            WriteLiteral("\r\n                        ");
            EndContext();
            BeginContext(3037, 64, false);
#line 67 "D:\IIHT\Task-16\InMemory\InternetServicesProvider\Views\Home\RegisterNewCustomer.cshtml"
                   Write(Html.TextBoxFor(m => m.Address, new { @class = "form-control" }));

#line default
#line hidden
            EndContext();
            BeginContext(3101, 26, true);
            WriteLiteral("\r\n                        ");
            EndContext();
            BeginContext(3127, 62, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("span", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ff8905e4abb487b21af649e4f37a2cdc77f868e022146", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationMessageTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper);
#line 68 "D:\IIHT\Task-16\InMemory\InternetServicesProvider\Views\Home\RegisterNewCustomer.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Address);

#line default
#line hidden
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-validation-for", __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3189, 251, true);
            WriteLiteral("\r\n                    </div>\r\n                </div>\r\n            </div>\r\n            <div class=\"form-group text-center\">\r\n                <button type=\"submit\" class=\"btn btn-primary\">Register</button>\r\n                <button class=\"btn btn-danger\"");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 3440, "\"", 3508, 4);
            WriteAttributeValue("", 3450, "location.href=\'", 3450, 15, true);
#line 74 "D:\IIHT\Task-16\InMemory\InternetServicesProvider\Views\Home\RegisterNewCustomer.cshtml"
WriteAttributeValue("", 3465, Url.Action("Index", "Home"), 3465, 28, false);

#line default
#line hidden
            WriteAttributeValue("", 3493, "\';return", 3493, 8, true);
            WriteAttributeValue(" ", 3501, "false;", 3502, 7, true);
            EndWriteAttribute();
            BeginContext(3509, 44, true);
            WriteLiteral(">Back To Home</button>\r\n            </div>\r\n");
            EndContext();
#line 76 "D:\IIHT\Task-16\InMemory\InternetServicesProvider\Views\Home\RegisterNewCustomer.cshtml"
        }

#line default
#line hidden
            BeginContext(3564, 18, true);
            WriteLiteral("    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<InternetServicesProvider.BusinessLayer.ViewModels.CustomerViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
