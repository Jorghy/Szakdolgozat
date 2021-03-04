#pragma checksum "D:\Project\Szakdolgozat\Szakdolgozat\Views\Book\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "04d78b31e6ed48311df936b05d1039efb8e02eb0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Book_Index), @"mvc.1.0.view", @"/Views/Book/Index.cshtml")]
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
#line 1 "D:\Project\Szakdolgozat\Szakdolgozat\Views\_ViewImports.cshtml"
using Szakdolgozat;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Project\Szakdolgozat\Szakdolgozat\Views\_ViewImports.cshtml"
using Szakdolgozat.DTO.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"04d78b31e6ed48311df936b05d1039efb8e02eb0", @"/Views/Book/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9c6886786c869dda2af7a0af72aed3f59e141bb7", @"/Views/_ViewImports.cshtml")]
    public class Views_Book_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Szakdolgozat.DTO.ViewModels.BookVm>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "D:\Project\Szakdolgozat\Szakdolgozat\Views\Book\Index.cshtml"
  
    ViewData["Title"] = "Könyv";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 6 "D:\Project\Szakdolgozat\Szakdolgozat\Views\Book\Index.cshtml"
 if (ViewData["Message"] != null)
{

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    <div class=""alert alert-success alert-dismissible fade show text-center"" role=""alert"">
        <button type=""button"" class=""close"" data-dismiss=""alert"" aria-label=""Bezár"">
            <span aria-hidden=""true"">&times;</span>
        </button>
        ");
#nullable restore
#line 12 "D:\Project\Szakdolgozat\Szakdolgozat\Views\Book\Index.cshtml"
   Write(ViewData["Message"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n");
#nullable restore
#line 14 "D:\Project\Szakdolgozat\Szakdolgozat\Views\Book\Index.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Könyvek</h1>\r\n\r\n<p>\r\n    ");
#nullable restore
#line 19 "D:\Project\Szakdolgozat\Szakdolgozat\Views\Book\Index.cshtml"
Write(Html.ActionLink("Hozzáadás", "Create", new { }, new { @class = "btn btn-success" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</p>\r\n\r\n<table class=\"table\">\r\n    <tr>\r\n");
            WriteLiteral("        <th style=\"width: 300px; text-align: center;\">");
#nullable restore
#line 25 "D:\Project\Szakdolgozat\Szakdolgozat\Views\Book\Index.cshtml"
                                                 Write(Html.DisplayNameFor(model => model.Title));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n        <th>");
#nullable restore
#line 26 "D:\Project\Szakdolgozat\Szakdolgozat\Views\Book\Index.cshtml"
       Write(Html.DisplayNameFor(model => model.Type));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n        <th>");
#nullable restore
#line 27 "D:\Project\Szakdolgozat\Szakdolgozat\Views\Book\Index.cshtml"
       Write(Html.DisplayNameFor(model => model.Publisher.PublisherName));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n        <th>");
#nullable restore
#line 28 "D:\Project\Szakdolgozat\Szakdolgozat\Views\Book\Index.cshtml"
       Write(Html.DisplayNameFor(model => model.Price));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n        <th>");
#nullable restore
#line 29 "D:\Project\Szakdolgozat\Szakdolgozat\Views\Book\Index.cshtml"
       Write(Html.DisplayNameFor(model => model.Royality));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n        <th style=\"width: 140px; text-align: center;\">");
#nullable restore
#line 30 "D:\Project\Szakdolgozat\Szakdolgozat\Views\Book\Index.cshtml"
                                                 Write(Html.DisplayNameFor(model => model.YtdSales));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n        <th style=\"width: 500px; text-align: center;\">");
#nullable restore
#line 31 "D:\Project\Szakdolgozat\Szakdolgozat\Views\Book\Index.cshtml"
                                                 Write(Html.DisplayNameFor(model => model.Notes));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n        <th>");
#nullable restore
#line 32 "D:\Project\Szakdolgozat\Szakdolgozat\Views\Book\Index.cshtml"
       Write(Html.DisplayNameFor(model => model.PublishedDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n        <th style=\"width: 300px\"></th>\r\n    </tr>\r\n");
#nullable restore
#line 35 "D:\Project\Szakdolgozat\Szakdolgozat\Views\Book\Index.cshtml"
     foreach(var item in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n");
            WriteLiteral("            <td>");
#nullable restore
#line 39 "D:\Project\Szakdolgozat\Szakdolgozat\Views\Book\Index.cshtml"
           Write(Html.DisplayFor(model => item.Title));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 40 "D:\Project\Szakdolgozat\Szakdolgozat\Views\Book\Index.cshtml"
           Write(Html.DisplayFor(model => item.Type));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 41 "D:\Project\Szakdolgozat\Szakdolgozat\Views\Book\Index.cshtml"
           Write(Html.DisplayFor(model => item.Publisher.PublisherName));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 42 "D:\Project\Szakdolgozat\Szakdolgozat\Views\Book\Index.cshtml"
           Write(Html.DisplayFor(model => item.Price));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td style=\"text-align: center\">");
#nullable restore
#line 43 "D:\Project\Szakdolgozat\Szakdolgozat\Views\Book\Index.cshtml"
                                      Write(Html.DisplayFor(model => item.Royality));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td style=\"text-align: center\">");
#nullable restore
#line 44 "D:\Project\Szakdolgozat\Szakdolgozat\Views\Book\Index.cshtml"
                                      Write(Html.DisplayFor(model => item.YtdSales));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 45 "D:\Project\Szakdolgozat\Szakdolgozat\Views\Book\Index.cshtml"
           Write(Html.DisplayFor(model => item.Notes));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 46 "D:\Project\Szakdolgozat\Szakdolgozat\Views\Book\Index.cshtml"
           Write(Html.DisplayFor(model => item.PublishedDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>\r\n                ");
#nullable restore
#line 48 "D:\Project\Szakdolgozat\Szakdolgozat\Views\Book\Index.cshtml"
           Write(Html.ActionLink("Részletek", "Details", new { id = item.BookId }, new { @class = "btn btn-info" }));

#line default
#line hidden
#nullable disable
            WriteLiteral(" |\r\n                ");
#nullable restore
#line 49 "D:\Project\Szakdolgozat\Szakdolgozat\Views\Book\Index.cshtml"
           Write(Html.ActionLink("Szerkesztés", "Edit", new { id = item.BookId }, new { @class = "btn btn-secondary" }));

#line default
#line hidden
#nullable disable
            WriteLiteral(" |\r\n                ");
#nullable restore
#line 50 "D:\Project\Szakdolgozat\Szakdolgozat\Views\Book\Index.cshtml"
           Write(Html.ActionLink("Törlés", "Delete", new { id = item.BookId }, new { @class = "btn btn-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n");
#nullable restore
#line 53 "D:\Project\Szakdolgozat\Szakdolgozat\Views\Book\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</table>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Szakdolgozat.DTO.ViewModels.BookVm>> Html { get; private set; }
    }
}
#pragma warning restore 1591
