#pragma checksum "C:\training\Src\DeliverySystemSolution\DeliverySystemProject\Views\Booking\MenuPageAdmin.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "72aff73c154b8f78775710e42d99c86e5b2a4fcb"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Booking_MenuPageAdmin), @"mvc.1.0.view", @"/Views/Booking/MenuPageAdmin.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"72aff73c154b8f78775710e42d99c86e5b2a4fcb", @"/Views/Booking/MenuPageAdmin.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ae4c746d9b498caa44a0798c26b20f95bd7a9740", @"/Views/_ViewImports.cshtml")]
    public class Views_Booking_MenuPageAdmin : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/Admin.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("height", new global::Microsoft.AspNetCore.Html.HtmlString("500"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("width", new global::Microsoft.AspNetCore.Html.HtmlString("500"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("    <style>\r\n        ul {\r\n            margin: 0\r\n        }\r\n\r\n            ul li {\r\n                float: left;\r\n            }\r\n\r\n            ul li {\r\n                padding: 20px;\r\n                list-style: none;\r\n            }\r\n    </style>\r\n");
            WriteLiteral("    <div class=\"navbar navbar-expand-sm bg-light navbar-light\">\r\n        <ul class=\"nav navbar-nav\">\r\n            <li>\r\n                <a");
            BeginWriteAttribute("href", " href=\"", 523, "\"", 561, 1);
#nullable restore
#line 27 "C:\training\Src\DeliverySystemSolution\DeliverySystemProject\Views\Booking\MenuPageAdmin.cshtml"
WriteAttributeValue("", 530, Url.Action("Index","Customer"), 530, 31, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                    <b>List of Customers  </b><br />\r\n                </a>\r\n            </li>\r\n            <li>\r\n                <a");
            BeginWriteAttribute("href", " href=\"", 696, "\"", 735, 1);
#nullable restore
#line 32 "C:\training\Src\DeliverySystemSolution\DeliverySystemProject\Views\Booking\MenuPageAdmin.cshtml"
WriteAttributeValue("", 703, Url.Action("Index","Executive"), 703, 32, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                    <b>List of Executives</b>\r\n                </a>\r\n            </li>\r\n            <li>\r\n                <a");
            BeginWriteAttribute("href", " href=\"", 863, "\"", 902, 1);
#nullable restore
#line 37 "C:\training\Src\DeliverySystemSolution\DeliverySystemProject\Views\Booking\MenuPageAdmin.cshtml"
WriteAttributeValue("", 870, Url.Action("LogOut", "Booking"), 870, 32, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                    <b>LogOut</b>\r\n                </a>\r\n            </li>\r\n        </ul>\r\n    </div>\r\n");
            WriteLiteral("    <Center>\r\n        <h1><b><font size=\"30\">Admin Portal</font></b> </h1>\r\n        <br />\r\n        <br />\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "72aff73c154b8f78775710e42d99c86e5b2a4fcb6412", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n    </Center>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
