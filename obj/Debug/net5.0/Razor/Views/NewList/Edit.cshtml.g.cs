#pragma checksum "C:\GitHub\ShopWithMe\Views\NewList\Edit.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e9a574573eab2f1841565bb4709e4a34f381c4c3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_NewList_Edit), @"mvc.1.0.view", @"/Views/NewList/Edit.cshtml")]
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
#line 2 "C:\GitHub\ShopWithMe\Views\_ViewImports.cshtml"
using ShopWithMe.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\GitHub\ShopWithMe\Views\NewList\Edit.cshtml"
using ShopWithMe;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e9a574573eab2f1841565bb4709e4a34f381c4c3", @"/Views/NewList/Edit.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"932a8f895a1cb0a4f1e46f1557aee7e0045d2161", @"/Views/_ViewImports.cshtml")]
    public class Views_NewList_Edit : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n");
#nullable restore
#line 5 "C:\GitHub\ShopWithMe\Views\NewList\Edit.cshtml"
  
    ViewData["Title"] = "Edit";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Update</h1>\r\n");
#nullable restore
#line 11 "C:\GitHub\ShopWithMe\Views\NewList\Edit.cshtml"
Write(Html.ActionLink("Delete list", "Delete", "NewList", new { id = Model.ID }, new { @class = "btn btn-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

<div>
    <table class=""table table-bordered"">
        <thead>
            <tr>
                <th scope=""col"">New list</th>
                <th scope=""col"">Favorites</th>
            </tr>
        </thead>
        <tbody>
            <tr>
                <th scope=""row"">
                    <ul class=""list-group"">

");
#nullable restore
#line 26 "C:\GitHub\ShopWithMe\Views\NewList\Edit.cshtml"
                         foreach (string product in Model.Products)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <li class=\"list-group-item\">\r\n                                ");
#nullable restore
#line 29 "C:\GitHub\ShopWithMe\Views\NewList\Edit.cshtml"
                           Write(Html.DisplayFor(modelItem => product));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n                                ");
#nullable restore
#line 31 "C:\GitHub\ShopWithMe\Views\NewList\Edit.cshtml"
                           Write(Html.ActionLink("Delete", "Delete_product", "NewList", new { Page_type = "Edit", id = Model.ID, Nameproduct = product, listproducts = Model.Products, favorites = Model.Favorites }, new { @class = "btn btn-primary" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </li>\r\n");
#nullable restore
#line 33 "C:\GitHub\ShopWithMe\Views\NewList\Edit.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </ul>\r\n                </th>\r\n\r\n                <th scope=\"row\">\r\n                    <ul class=\"list-group\">\r\n");
#nullable restore
#line 40 "C:\GitHub\ShopWithMe\Views\NewList\Edit.cshtml"
                         foreach (string item in Model.Favorites)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <li class=\"list-group-item\">\r\n                                ");
#nullable restore
#line 43 "C:\GitHub\ShopWithMe\Views\NewList\Edit.cshtml"
                           Write(Html.DisplayFor(modelItem => item));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 44 "C:\GitHub\ShopWithMe\Views\NewList\Edit.cshtml"
                                 using (Html.BeginForm("Add_Update", "NewList", new { Page_type = "Edit", id = Model.ID, Nameproduct = item, listproducts = Model.Products, favorites = Model.Favorites }))
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <input type=\"number\" value=\"1\" name=\"quantity\" />\r\n                                    <input type=\"submit\" value=\"add\" class=\"btn btn-primary\" />\r\n");
#nullable restore
#line 48 "C:\GitHub\ShopWithMe\Views\NewList\Edit.cshtml"
                                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                            </li>\r\n");
#nullable restore
#line 50 "C:\GitHub\ShopWithMe\Views\NewList\Edit.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </ul>\r\n                </th>\r\n            </tr>\r\n\r\n        </tbody>\r\n\r\n    </table>\r\n\r\n");
#nullable restore
#line 59 "C:\GitHub\ShopWithMe\Views\NewList\Edit.cshtml"
     using (Html.BeginForm("Add_Update", "NewList", new { Page_type = "Edit", id = Model.ID, listproducts = Model.Products, favorites = Model.Favorites }))
    {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"        <div class=""form-group"">
            <a>Add/Update Product</a>
            <input type=""text"" name=""Nameproduct"" required />
            <input type=""number"" value=""1"" name=""quantity"" />
            <input type=""submit"" value=""add"" class=""btn btn-primary"" />
        </div>
");
#nullable restore
#line 67 "C:\GitHub\ShopWithMe\Views\NewList\Edit.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n<div>\r\n");
#nullable restore
#line 70 "C:\GitHub\ShopWithMe\Views\NewList\Edit.cshtml"
     using (Html.BeginForm("Update", "NewList", new { id = Model.ID, listproducts = Model.Products, favorites = Model.Favorites }))
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"form-group\">\r\n            <a>Update</a>\r\n            <input type=\"text\" name=\"listname\" required />\r\n            <input type=\"submit\" value=\"Save\" class=\"btn btn-primary\" />\r\n        </div>\r\n");
#nullable restore
#line 77 "C:\GitHub\ShopWithMe\Views\NewList\Edit.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>");
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
