#pragma checksum "D:\Project\Szakdolgozat\Szakdolgozat\Views\Role\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a6c50ca6380d90f1be522a61a7ce32f4cf35095d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Role_Index), @"mvc.1.0.view", @"/Views/Role/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a6c50ca6380d90f1be522a61a7ce32f4cf35095d", @"/Views/Role/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9c6886786c869dda2af7a0af72aed3f59e141bb7", @"/Views/_ViewImports.cshtml")]
    public class Views_Role_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Szakdolgozat.DTO.ViewModels.RoleVm>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "D:\Project\Szakdolgozat\Szakdolgozat\Views\Role\Index.cshtml"
  
    ViewData["Title"] = "Szerepkör";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"container\">\r\n\r\n");
#nullable restore
#line 8 "D:\Project\Szakdolgozat\Szakdolgozat\Views\Role\Index.cshtml"
     if (ViewData["Message"] != null)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"        <div class=""alert alert-success alert-dismissible fade show text-center"" role=""alert"">
            <button type=""button"" class=""close"" data-dismiss=""alert"" aria-label=""Bezár"">
                <span aria-hidden=""true"">&times;</span>
            </button>
            ");
#nullable restore
#line 14 "D:\Project\Szakdolgozat\Szakdolgozat\Views\Role\Index.cshtml"
       Write(ViewData["Message"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n");
#nullable restore
#line 16 "D:\Project\Szakdolgozat\Szakdolgozat\Views\Role\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    <h1>Szerepkörök</h1>\r\n\r\n    <p>\r\n        ");
#nullable restore
#line 21 "D:\Project\Szakdolgozat\Szakdolgozat\Views\Role\Index.cshtml"
   Write(Html.ActionLink("Hozzáadás", "Create", new { }, new { @class = "btn btn-success" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </p>\r\n\r\n    <table class=\"table\">\r\n        <tr>\r\n            <th>");
#nullable restore
#line 26 "D:\Project\Szakdolgozat\Szakdolgozat\Views\Role\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.RoleId));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n            <th>");
#nullable restore
#line 27 "D:\Project\Szakdolgozat\Szakdolgozat\Views\Role\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.RoleDesc));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n            <th></th>\r\n        </tr>\r\n");
#nullable restore
#line 30 "D:\Project\Szakdolgozat\Szakdolgozat\Views\Role\Index.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>");
#nullable restore
#line 33 "D:\Project\Szakdolgozat\Szakdolgozat\Views\Role\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.RoleId));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 34 "D:\Project\Szakdolgozat\Szakdolgozat\Views\Role\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.RoleDesc));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>\r\n                    ");
#nullable restore
#line 36 "D:\Project\Szakdolgozat\Szakdolgozat\Views\Role\Index.cshtml"
               Write(Html.ActionLink("Részletek", "Details", new { id = item.RoleId }, new { @class = "btn btn-info" }));

#line default
#line hidden
#nullable disable
            WriteLiteral(" |\r\n                    ");
#nullable restore
#line 37 "D:\Project\Szakdolgozat\Szakdolgozat\Views\Role\Index.cshtml"
               Write(Html.ActionLink("Szerkesztés", "Edit", new { id = item.RoleId }, new { @class = "btn btn-secondary" }));

#line default
#line hidden
#nullable disable
            WriteLiteral(" |\r\n                    ");
#nullable restore
#line 38 "D:\Project\Szakdolgozat\Szakdolgozat\Views\Role\Index.cshtml"
               Write(Html.ActionLink("Törlés", "Delete", new { id = item.RoleId }, new { @class = "btn btn-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n            </tr>\r\n");
#nullable restore
#line 41 "D:\Project\Szakdolgozat\Szakdolgozat\Views\Role\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </table>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Szakdolgozat.DTO.ViewModels.RoleVm>> Html { get; private set; }
    }
}
#pragma warning restore 1591