#pragma checksum "C:\GitHub\ShopWithMe\Views\Invoice\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "89ef5e4c0ee9a4fc6c3b410b881db22b11e079df"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Invoice_Details), @"mvc.1.0.view", @"/Views/Invoice/Details.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"89ef5e4c0ee9a4fc6c3b410b881db22b11e079df", @"/Views/Invoice/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"932a8f895a1cb0a4f1e46f1557aee7e0045d2161", @"/Views/_ViewImports.cshtml")]
    public class Views_Invoice_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ShopWithMe.Models.Cart>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\GitHub\ShopWithMe\Views\Invoice\Details.cshtml"
  
    ViewData["Title"] = "Details";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "89ef5e4c0ee9a4fc6c3b410b881db22b11e079df3834", async() => {
                WriteLiteral(@"
    <style>
        body {
            background-image: url(https://smallaxepeppers.com/wp-content/uploads/2019/05/Fresh-farmers-market-fruit-and-vegetable-from-above-with-copy-space-e1432779252529.jpg);
            background-position: center;
            background-repeat: no-repeat;
            background-size: cover;
        }

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
            height: 250px;
            overflow: auto;
        }

        .div_marquee {
            box-shadow: 5px 10px gold;
            background-color: darkgrey;
            font-family: 'Copperplate Gothic';
            font-size: x-large;
            text-shadow: 2px 2px ");
                WriteLiteral(@"8px gold;
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
            font-family: 'Copperplate Gothic';
        }

            .table th {
                background-color: gray;
                text-shadow: 2px 2px 5px #ffffff;
            }

        tr:hover {
            background-color: #f2f2f2;
        }
    </style>
");
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
            WriteLiteral("\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "89ef5e4c0ee9a4fc6c3b410b881db22b11e079df6465", async() => {
                WriteLiteral("\r\n    <div style=\"opacity:90%;background-color:darkgrey\">\r\n        <center>\r\n\r\n");
                WriteLiteral("            <div>\r\n                <h1>.:: Shop With Me ::.</h1>\r\n                <hr />\r\n            </div>\r\n\r\n");
                WriteLiteral(@"            <table class=""table"">
                <thead>
                    <tr>
                        <th scope=""col"">Bill ID</th>
                        <th scope=""col"">Bill To</th>
                        <th scope=""col"">Invoice Date</th>
                        <th scope=""col"">Cart Name</th>
                    </tr>
                </thead>
                <tbody>
                    <tr>
                        <td>");
#nullable restore
#line 95 "C:\GitHub\ShopWithMe\Views\Invoice\Details.cshtml"
                       Write(Html.DisplayFor(model => model.Id));

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 96 "C:\GitHub\ShopWithMe\Views\Invoice\Details.cshtml"
                       Write(Html.DisplayFor(model => model.UserId));

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 97 "C:\GitHub\ShopWithMe\Views\Invoice\Details.cshtml"
                       Write(Html.DisplayFor(model => model.Date_Time));

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 98 "C:\GitHub\ShopWithMe\Views\Invoice\Details.cshtml"
                       Write(Html.DisplayFor(model => model.NameCart));

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                    </tr>\r\n                </tbody>\r\n            </table>\r\n\r\n");
                WriteLiteral(@"            <table class=""table"">
                <thead>
                    <tr>
                        <th scope=""col"">Qty</th>
                        <th scope=""col"">Description</th>
                        <th scope=""col"">Unit Price</th>
                        <th scope=""col"">Amount</th>
                    </tr>
                </thead>
                <tbody>
");
#nullable restore
#line 114 "C:\GitHub\ShopWithMe\Views\Invoice\Details.cshtml"
                     foreach (Proudct proudct in Model.Proudcts)
                    {

#line default
#line hidden
#nullable disable
                WriteLiteral("                        <tr>\r\n                            <td>");
#nullable restore
#line 117 "C:\GitHub\ShopWithMe\Views\Invoice\Details.cshtml"
                           Write(Html.DisplayFor(modelItem => proudct.Quantity));

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 118 "C:\GitHub\ShopWithMe\Views\Invoice\Details.cshtml"
                           Write(Html.DisplayFor(modelItem => proudct.Name));

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                            <td>\r\n                                <script>\r\n                                        var a = (");
#nullable restore
#line 121 "C:\GitHub\ShopWithMe\Views\Invoice\Details.cshtml"
                                            Write(proudct.Price);

#line default
#line hidden
#nullable disable
                WriteLiteral(") / (");
#nullable restore
#line 121 "C:\GitHub\ShopWithMe\Views\Invoice\Details.cshtml"
                                                               Write(proudct.Quantity);

#line default
#line hidden
#nullable disable
                WriteLiteral(");\r\n                                        document.write(a);\r\n                                </script>\r\n\r\n                            </td>\r\n                            <td>");
#nullable restore
#line 126 "C:\GitHub\ShopWithMe\Views\Invoice\Details.cshtml"
                           Write(proudct.Price.ToString("₪#,##0.00"));

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                        </tr>\r\n");
#nullable restore
#line 128 "C:\GitHub\ShopWithMe\Views\Invoice\Details.cshtml"
                    }

#line default
#line hidden
#nullable disable
                WriteLiteral("                </tbody>\r\n            </table>\r\n\r\n");
                WriteLiteral("            <table class=\"table\" style=\"text-align:center\">\r\n                <thead>\r\n                    <tr>\r\n                        <th scope=\"col\">Total</th>\r\n                        <th scope=\"col\">");
#nullable restore
#line 137 "C:\GitHub\ShopWithMe\Views\Invoice\Details.cshtml"
                                   Write(Model.Total.ToString("₪#,##0.00"));

#line default
#line hidden
#nullable disable
                WriteLiteral("</th>\r\n                    </tr>\r\n                </thead>\r\n            </table>\r\n\r\n\r\n            <div>\r\n                <a> ");
#nullable restore
#line 144 "C:\GitHub\ShopWithMe\Views\Invoice\Details.cshtml"
               Write(Html.ActionLink("Delete", "Delete", new { id = Model.Id }, new { @class = "btn btn-danger" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("</a>\r\n                <hr />\r\n                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "89ef5e4c0ee9a4fc6c3b410b881db22b11e079df12211", async() => {
                    WriteLiteral(">> Back to List <<");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n            </div>\r\n        </center>\r\n    </div>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ShopWithMe.Models.Cart> Html { get; private set; }
    }
}
#pragma warning restore 1591
