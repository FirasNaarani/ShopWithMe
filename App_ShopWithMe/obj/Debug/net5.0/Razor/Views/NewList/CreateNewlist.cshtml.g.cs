#pragma checksum "C:\Git\GitHub\ShopWithMe\App_ShopWithMe\Views\NewList\CreateNewlist.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "08f1804700da1e7dbbea54d007833daa0949cfd1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_NewList_CreateNewlist), @"mvc.1.0.view", @"/Views/NewList/CreateNewlist.cshtml")]
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
#line 2 "C:\Git\GitHub\ShopWithMe\App_ShopWithMe\Views\_ViewImports.cshtml"
using App_ShopWithMe.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Git\GitHub\ShopWithMe\App_ShopWithMe\Views\NewList\CreateNewlist.cshtml"
using App_ShopWithMe;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"08f1804700da1e7dbbea54d007833daa0949cfd1", @"/Views/NewList/CreateNewlist.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f6a0525d812b189ca1cd8297e4e8898ac559ed9b", @"/Views/_ViewImports.cshtml")]
    public class Views_NewList_CreateNewlist : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 4 "C:\Git\GitHub\ShopWithMe\App_ShopWithMe\Views\NewList\CreateNewlist.cshtml"
  
    ViewData["Title"] = "CreateNewlist";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<h1>CreateNewlist</h1>
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
#line 23 "C:\Git\GitHub\ShopWithMe\App_ShopWithMe\Views\NewList\CreateNewlist.cshtml"
                         foreach (string product in Model.Products)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <li class=\"list-group-item\">\r\n                                ");
#nullable restore
#line 26 "C:\Git\GitHub\ShopWithMe\App_ShopWithMe\Views\NewList\CreateNewlist.cshtml"
                           Write(Html.DisplayFor(modelItem => product));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n                                ");
#nullable restore
#line 28 "C:\Git\GitHub\ShopWithMe\App_ShopWithMe\Views\NewList\CreateNewlist.cshtml"
                           Write(Html.ActionLink("Delete", "Delete_product", "NewList", new { Page_type = "CreateNewlist", Nameproduct = product, listproducts = Model.Products, favorites = Model.Favorites }, new { @class = "btn btn-primary" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </li>\r\n");
#nullable restore
#line 30 "C:\Git\GitHub\ShopWithMe\App_ShopWithMe\Views\NewList\CreateNewlist.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </ul>\r\n                </th>\r\n\r\n                <th scope=\"row\">\r\n                    <ul class=\"list-group\">\r\n");
#nullable restore
#line 37 "C:\Git\GitHub\ShopWithMe\App_ShopWithMe\Views\NewList\CreateNewlist.cshtml"
                         foreach (string item in Model.Favorites)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <li class=\"list-group-item\">\r\n                                ");
#nullable restore
#line 40 "C:\Git\GitHub\ShopWithMe\App_ShopWithMe\Views\NewList\CreateNewlist.cshtml"
                           Write(Html.DisplayFor(modelItem => item));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                ");
#nullable restore
#line 41 "C:\Git\GitHub\ShopWithMe\App_ShopWithMe\Views\NewList\CreateNewlist.cshtml"
                           Write(Html.ActionLink("Add", "Add_Update", "NewList", new { Page_type = "CreateNewlist", Nameproduct = item, quantity = 1, listproducts = Model.Products, favorites = Model.Favorites }, new { @class = "btn btn-primary" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n                            </li>\r\n");
#nullable restore
#line 44 "C:\Git\GitHub\ShopWithMe\App_ShopWithMe\Views\NewList\CreateNewlist.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </ul>\r\n                </th>\r\n            </tr>\r\n\r\n        </tbody>\r\n\r\n    </table>\r\n\r\n");
#nullable restore
#line 53 "C:\Git\GitHub\ShopWithMe\App_ShopWithMe\Views\NewList\CreateNewlist.cshtml"
     using (Html.BeginForm("Add_Update", "NewList", new { Page_type = "CreateNewlist", listproducts = Model.Products, favorites = Model.Favorites }))
    {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"        <div class=""form-group"">
            <a>Add/Update Product</a>
            <input type=""text"" name=""Nameproduct"" />
            <input type=""number"" value=""1"" name=""quantity"" />
            <input type=""submit"" value=""add"" class=""btn btn-primary"" />
        </div>
");
#nullable restore
#line 61 "C:\Git\GitHub\ShopWithMe\App_ShopWithMe\Views\NewList\CreateNewlist.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n<div>\r\n");
#nullable restore
#line 64 "C:\Git\GitHub\ShopWithMe\App_ShopWithMe\Views\NewList\CreateNewlist.cshtml"
     using (Html.BeginForm("Save", "NewList", new { listproducts = Model.Products, favorites = Model.Favorites }))
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"form-group\">\r\n            <a>List Name</a>\r\n\r\n            <input type=\"text\" name=\"namelist\" />\r\n            <input type=\"submit\" value=\"Save\" class=\"btn btn-primary\" />\r\n        </div>\r\n");
#nullable restore
#line 72 "C:\Git\GitHub\ShopWithMe\App_ShopWithMe\Views\NewList\CreateNewlist.cshtml"
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
