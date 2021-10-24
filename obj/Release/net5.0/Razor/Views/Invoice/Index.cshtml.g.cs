#pragma checksum "C:\GitHub\ShopWithMe\Views\Invoice\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5e3a3d3cf354142e8feb308b1ac224453c478cf6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Invoice_Index), @"mvc.1.0.view", @"/Views/Invoice/Index.cshtml")]
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
#line 1 "C:\GitHub\ShopWithMe\Views\_ViewImports.cshtml"
using ShopWithMe;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\GitHub\ShopWithMe\Views\_ViewImports.cshtml"
using ShopWithMe.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5e3a3d3cf354142e8feb308b1ac224453c478cf6", @"/Views/Invoice/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"932a8f895a1cb0a4f1e46f1557aee7e0045d2161", @"/Views/_ViewImports.cshtml")]
    public class Views_Invoice_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<ShopWithMe.Models.Cart>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("background-image: url(https://smallaxepeppers.com/wp-content/uploads/2019/05/Fresh-farmers-market-fruit-and-vegetable-from-above-with-copy-space-e1432779252529.jpg)"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\GitHub\ShopWithMe\Views\Invoice\Index.cshtml"
  
    ViewData["Title"] = "Invoice";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5e3a3d3cf354142e8feb308b1ac224453c478cf63907", async() => {
                WriteLiteral(@"
    <style>
        h1 {
            text-shadow: 2px 2px 5px gold;
            font-family: Garamond, serif;
        }

        .div {
            width: 150px;
            height: auto;
            opacity: 60%;
            margin: 10px 10px 10px 10px;
        }

            .div:hover {
                opacity: 100%;
            }

        .div_scroll {
            width: 100%;
            height: 300px;
            overflow: auto;
        }

        .div_marquee {
            box-shadow: 5px 10px gold;
            background-color: darkgrey;
            font-family: 'Copperplate Gothic';
            font-size: x-large;
            text-shadow: 2px 2px 8px gold;
            height: 30px;
            margin: 40px;
            opacity: 90%;
        }

        .item_table {
            background-color: lightgray;
            text-align: center;
            width: 100%;
            border: 5px double gold;
        }

        .table {
            width: 100%;
      ");
                WriteLiteral("      display: flex;\r\n            justify-content: space-around;\r\n        }\r\n    </style>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5e3a3d3cf354142e8feb308b1ac224453c478cf66028", async() => {
                WriteLiteral("\r\n    <div style=\"opacity:90%;background-color:darkgrey\">\r\n        <center>\r\n\r\n");
                WriteLiteral("            <div>\r\n                <h1>.:: My Invoices ::.</h1>\r\n                <hr />\r\n            </div>\r\n\r\n");
                WriteLiteral("            <div class=\"div_scroll\">\r\n                <table class=\"table\">\r\n                    <tbody>\r\n");
#nullable restore
#line 71 "C:\GitHub\ShopWithMe\Views\Invoice\Index.cshtml"
                         for (int i = 0, j = 0; i < Model.ToArray().Length;)
                        {

#line default
#line hidden
#nullable disable
                WriteLiteral("                            <tr>\r\n");
#nullable restore
#line 74 "C:\GitHub\ShopWithMe\Views\Invoice\Index.cshtml"
                                 while (j <= 2)
                                {

#line default
#line hidden
#nullable disable
                WriteLiteral(@"                                    <td>
                                        <div class=""div"">
                                            <table class=""item_table"">
                                                <tr>
                                                    <td>
                                                        ");
#nullable restore
#line 81 "C:\GitHub\ShopWithMe\Views\Invoice\Index.cshtml"
                                                   Write(Html.ActionLink($"{Model.ToArray()[i].NameCart} {Model.ToArray()[i].Date_Time.ToString("dd/MM/yyyy")}", "Details", new { Id = Model.ToArray()[i].Id }, new { @class = "btn-rounded btn btn-info " }));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
                                                    </td>
                                                </tr>
                                            </table>
                                        </div>
                                    </td>
");
#nullable restore
#line 87 "C:\GitHub\ShopWithMe\Views\Invoice\Index.cshtml"
                                    j++;
                                    i++;
                                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 89 "C:\GitHub\ShopWithMe\Views\Invoice\Index.cshtml"
                                     if (i >= Model.ToArray().Length)
                                        break;

#line default
#line hidden
#nullable disable
#nullable restore
#line 90 "C:\GitHub\ShopWithMe\Views\Invoice\Index.cshtml"
                                              
                                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 92 "C:\GitHub\ShopWithMe\Views\Invoice\Index.cshtml"
                                 if (j > 2)
                                {
                                    j = 0;
                                }

#line default
#line hidden
#nullable disable
                WriteLiteral("                            </tr>\r\n");
#nullable restore
#line 97 "C:\GitHub\ShopWithMe\Views\Invoice\Index.cshtml"
                        }

#line default
#line hidden
#nullable disable
                WriteLiteral("                    </tbody>\r\n                </table>\r\n            </div>\r\n        </center>\r\n    </div>\r\n\r\n");
                WriteLiteral("    <div class=\"div_marquee\">\r\n        <marquee behavior=\"scroll\" direction=\"right\" scrollamount=\"12\">\r\n            <p> .:: Shop With Me Always With You ::. </p>\r\n        </marquee>\r\n    </div>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<ShopWithMe.Models.Cart>> Html { get; private set; }
    }
}
#pragma warning restore 1591