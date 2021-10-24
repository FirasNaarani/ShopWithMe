#pragma checksum "C:\GitHub\ShopWithMe\Views\Item\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bdcee6746f87d79289e71ffa4127f9a4507e3e00"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Item_Index), @"mvc.1.0.view", @"/Views/Item/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bdcee6746f87d79289e71ffa4127f9a4507e3e00", @"/Views/Item/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"932a8f895a1cb0a4f1e46f1557aee7e0045d2161", @"/Views/_ViewImports.cshtml")]
    public class Views_Item_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<ShopWithMe.Models.Item>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("background-image: url(https://smallaxepeppers.com/wp-content/uploads/2019/05/Fresh-farmers-market-fruit-and-vegetable-from-above-with-copy-space-e1432779252529.jpg)"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 3 "C:\GitHub\ShopWithMe\Views\Item\Index.cshtml"
  
    ViewData["Title"] = "My Items";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bdcee6746f87d79289e71ffa4127f9a4507e3e004323", async() => {
                WriteLiteral(@"
    <style>
        h1 {
            text-shadow: 2px 2px 5px gold;
            font-family: Garamond, serif;
        }

        th {
            font-family: Garamond, serif;
            text-shadow: 2px 2px 5px gold;
            font-size: large;
        }

        td {
            font-family: Garamond, serif;
            text-shadow: 2px 2px 5px gold;
        }

        .div {
            width: 200px;
            opacity: 60%;
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
            text-shadow: 2px 2px 8px gold;
            height: 30px;
            margin: 40px;
            opacity: 90%;
        }

        .item_table {
            ");
                WriteLiteral("background-color: lightgray;\r\n            text-align: center;\r\n            width: 100%;\r\n            border: 5px double gold;\r\n            margin: 20px;\r\n            padding: 20px;\r\n        }\r\n    </style>\r\n");
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bdcee6746f87d79289e71ffa4127f9a4507e3e006572", async() => {
                WriteLiteral("\r\n    <div style=\"opacity:90%;background-color:darkgrey\">\r\n        <center>\r\n\r\n");
                WriteLiteral("            <div>\r\n                <h1>.:: My Items ::.</h1>\r\n                <hr />\r\n                <p>\r\n                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bdcee6746f87d79289e71ffa4127f9a4507e3e007085", async() => {
                    WriteLiteral(">> Create New Item <<");
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
                WriteLiteral("\r\n                </p>\r\n                <hr />\r\n            </div>\r\n\r\n");
                WriteLiteral("            <div class=\"div_scroll\">\r\n                <table class=\"table\">\r\n                    <tbody>\r\n");
#nullable restore
#line 81 "C:\GitHub\ShopWithMe\Views\Item\Index.cshtml"
                         for (int i = 0, j = 0; i < Model.ToArray().Length;)
                        {

#line default
#line hidden
#nullable disable
                WriteLiteral("                            <tr>\r\n");
#nullable restore
#line 84 "C:\GitHub\ShopWithMe\Views\Item\Index.cshtml"
                                 while (j <= 4)
                                {

#line default
#line hidden
#nullable disable
                WriteLiteral(@"                                    <td>
                                        <div class=""div"">
                                            <table class=""item_table"">
                                                <thead>
                                                    <tr>
                                                        <th colspan=""3"">
                                                            ");
#nullable restore
#line 92 "C:\GitHub\ShopWithMe\Views\Item\Index.cshtml"
                                                       Write(Html.DisplayFor(modelItem => Model.ToArray()[i].Name));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
                                                        </th>
                                                    </tr>
                                                    <tr>
                                                        <td colspan=""3"">
                                                            ");
#nullable restore
#line 97 "C:\GitHub\ShopWithMe\Views\Item\Index.cshtml"
                                                       Write(Html.DisplayFor(modelItem => Model.ToArray()[i].Type));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
                                                        </td>
                                                    </tr>
                                                </thead>
                                                <tbody>
                                                    <tr>
                                                        <td colspan=""3"">
                                                            <img");
                BeginWriteAttribute("src", " src=\"", 3557, "\"", 3586, 1);
#nullable restore
#line 104 "C:\GitHub\ShopWithMe\Views\Item\Index.cshtml"
WriteAttributeValue("", 3563, Model.ToArray()[i].Url, 3563, 23, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@" alt=""Empty Photo"" width=""100"" height=""100"" />
                                                        </td>
                                                    </tr>
                                                    <tr>
                                                        <td>
                                                            ");
#nullable restore
#line 109 "C:\GitHub\ShopWithMe\Views\Item\Index.cshtml"
                                                       Write(Html.ActionLink("Edit", "Edit", new { id = Model.ToArray()[i].Id, name = Model.ToArray()[i].Name }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\r\n                                                        </td>\r\n                                                        <td>\r\n                                                            ");
#nullable restore
#line 113 "C:\GitHub\ShopWithMe\Views\Item\Index.cshtml"
                                                       Write(Html.ActionLink("Details", "Details", new { id = Model.ToArray()[i].Id, name = Model.ToArray()[i].Name }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                                                        </td>\r\n                                                        <td>\r\n                                                            ");
#nullable restore
#line 116 "C:\GitHub\ShopWithMe\Views\Item\Index.cshtml"
                                                       Write(Html.ActionLink("Delete", "Delete", new { id = Model.ToArray()[i].Id, name = Model.ToArray()[i].Name }));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
                                                        </td>
                                                    </tr>
                                                </tbody>

                                            </table>
                                        </div>
                                    </td>
");
#nullable restore
#line 124 "C:\GitHub\ShopWithMe\Views\Item\Index.cshtml"
                                    j++;
                                    i++;
                                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 126 "C:\GitHub\ShopWithMe\Views\Item\Index.cshtml"
                                     if (i >= Model.ToArray().Length)
                                        break;

#line default
#line hidden
#nullable disable
#nullable restore
#line 127 "C:\GitHub\ShopWithMe\Views\Item\Index.cshtml"
                                              
                                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 129 "C:\GitHub\ShopWithMe\Views\Item\Index.cshtml"
                                 if (j > 4)
                                {
                                    j = 0;
                                }

#line default
#line hidden
#nullable disable
                WriteLiteral("                            </tr>\r\n");
#nullable restore
#line 134 "C:\GitHub\ShopWithMe\Views\Item\Index.cshtml"
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
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<ShopWithMe.Models.Item>> Html { get; private set; }
    }
}
#pragma warning restore 1591