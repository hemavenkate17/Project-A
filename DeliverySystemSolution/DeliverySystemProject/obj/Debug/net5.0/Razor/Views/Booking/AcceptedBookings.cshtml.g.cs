#pragma checksum "C:\training\Src\DeliverySystemSolution\DeliverySystemProject\Views\Booking\AcceptedBookings.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7338cd056608b6e13dc11528855e95e026661859"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Booking_AcceptedBookings), @"mvc.1.0.view", @"/Views/Booking/AcceptedBookings.cshtml")]
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
#line 1 "C:\training\Src\DeliverySystemSolution\DeliverySystemProject\Views\_ViewImports.cshtml"
using DeliverySystemProject;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\training\Src\DeliverySystemSolution\DeliverySystemProject\Views\_ViewImports.cshtml"
using DeliverySystemProject.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7338cd056608b6e13dc11528855e95e026661859", @"/Views/Booking/AcceptedBookings.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ae4c746d9b498caa44a0798c26b20f95bd7a9740", @"/Views/_ViewImports.cshtml")]
    public class Views_Booking_AcceptedBookings : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<DeliverySystemProject.Models.Booking>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Customer", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "MenuPageCustomer", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\training\Src\DeliverySystemSolution\DeliverySystemProject\Views\Booking\AcceptedBookings.cshtml"
  
    ViewData["Title"] = "AcceptedBookings";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Accepted Bookings</h1>\r\n<style>\r\n    .col {\r\n        width: 75%;\r\n       \r\n    }\r\n</style>\r\n<table class=\"table\">\r\n    <thead >\r\n        <tr class=\"col\">\r\n            <th >\r\n                ");
#nullable restore
#line 18 "C:\training\Src\DeliverySystemSolution\DeliverySystemProject\Views\Booking\AcceptedBookings.cshtml"
           Write(Html.DisplayNameFor(model => model.OrderID));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th >\r\n                ");
#nullable restore
#line 21 "C:\training\Src\DeliverySystemSolution\DeliverySystemProject\Views\Booking\AcceptedBookings.cshtml"
           Write(Html.DisplayNameFor(model => model.CustomerID));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 24 "C:\training\Src\DeliverySystemSolution\DeliverySystemProject\Views\Booking\AcceptedBookings.cshtml"
           Write(Html.DisplayNameFor(model => model.ExecutiveID));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th >\r\n                ");
#nullable restore
#line 27 "C:\training\Src\DeliverySystemSolution\DeliverySystemProject\Views\Booking\AcceptedBookings.cshtml"
           Write(Html.DisplayNameFor(model => model.PickUpDateTime));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th >\r\n                ");
#nullable restore
#line 30 "C:\training\Src\DeliverySystemSolution\DeliverySystemProject\Views\Booking\AcceptedBookings.cshtml"
           Write(Html.DisplayNameFor(model => model.PickUpAddress));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th >\r\n                ");
#nullable restore
#line 33 "C:\training\Src\DeliverySystemSolution\DeliverySystemProject\Views\Booking\AcceptedBookings.cshtml"
           Write(Html.DisplayNameFor(model => model.DeliveryAddress));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 36 "C:\training\Src\DeliverySystemSolution\DeliverySystemProject\Views\Booking\AcceptedBookings.cshtml"
           Write(Html.DisplayNameFor(model => model.BookingStatus));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 39 "C:\training\Src\DeliverySystemSolution\DeliverySystemProject\Views\Booking\AcceptedBookings.cshtml"
           Write(Html.DisplayNameFor(model => model.WeightOfPackage));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th >\r\n                ");
#nullable restore
#line 42 "C:\training\Src\DeliverySystemSolution\DeliverySystemProject\Views\Booking\AcceptedBookings.cshtml"
           Write(Html.DisplayNameFor(model => model.Price));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 48 "C:\training\Src\DeliverySystemSolution\DeliverySystemProject\Views\Booking\AcceptedBookings.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td >\r\n                    ");
#nullable restore
#line 52 "C:\training\Src\DeliverySystemSolution\DeliverySystemProject\Views\Booking\AcceptedBookings.cshtml"
               Write(Html.DisplayFor(modelItem => item.OrderID));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td >\r\n                    ");
#nullable restore
#line 55 "C:\training\Src\DeliverySystemSolution\DeliverySystemProject\Views\Booking\AcceptedBookings.cshtml"
               Write(Html.DisplayFor(modelItem => item.CustomerID));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td >\r\n                    ");
#nullable restore
#line 58 "C:\training\Src\DeliverySystemSolution\DeliverySystemProject\Views\Booking\AcceptedBookings.cshtml"
               Write(Html.DisplayFor(modelItem => item.ExecutiveID));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td >\r\n                    ");
#nullable restore
#line 61 "C:\training\Src\DeliverySystemSolution\DeliverySystemProject\Views\Booking\AcceptedBookings.cshtml"
               Write(Html.DisplayFor(modelItem => item.PickUpDateTime));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td >\r\n                    ");
#nullable restore
#line 64 "C:\training\Src\DeliverySystemSolution\DeliverySystemProject\Views\Booking\AcceptedBookings.cshtml"
               Write(Html.DisplayFor(modelItem => item.PickUpAddress));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td >\r\n                    ");
#nullable restore
#line 67 "C:\training\Src\DeliverySystemSolution\DeliverySystemProject\Views\Booking\AcceptedBookings.cshtml"
               Write(Html.DisplayFor(modelItem => item.DeliveryAddress));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td >\r\n                    ");
#nullable restore
#line 70 "C:\training\Src\DeliverySystemSolution\DeliverySystemProject\Views\Booking\AcceptedBookings.cshtml"
               Write(Html.DisplayFor(modelItem => item.BookingStatus));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td >\r\n                    ");
#nullable restore
#line 73 "C:\training\Src\DeliverySystemSolution\DeliverySystemProject\Views\Booking\AcceptedBookings.cshtml"
               Write(Html.DisplayFor(modelItem => item.WeightOfPackage));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td >\r\n                    ");
#nullable restore
#line 76 "C:\training\Src\DeliverySystemSolution\DeliverySystemProject\Views\Booking\AcceptedBookings.cshtml"
               Write(Html.DisplayFor(modelItem => item.Price));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td >\r\n                    ");
#nullable restore
#line 79 "C:\training\Src\DeliverySystemSolution\DeliverySystemProject\Views\Booking\AcceptedBookings.cshtml"
               Write(Html.ActionLink("BookingDetails", "BookingDetails", new { id = item.OrderID }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n            </tr>\r\n");
#nullable restore
#line 82 "C:\training\Src\DeliverySystemSolution\DeliverySystemProject\Views\Booking\AcceptedBookings.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n<div>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7338cd056608b6e13dc11528855e95e02666185911583", async() => {
                WriteLiteral("Menu page");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<DeliverySystemProject.Models.Booking>> Html { get; private set; }
    }
}
#pragma warning restore 1591
