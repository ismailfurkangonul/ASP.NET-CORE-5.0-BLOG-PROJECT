#pragma checksum "C:\Users\Nani1\OneDrive\Masaüstü\CoreDemo\CoreDemo\Views\Shared\Components\BlogListDashboard\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9c147af61c0cf29ce232a681bc3ce92c565d1b6a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_BlogListDashboard_Default), @"mvc.1.0.view", @"/Views/Shared/Components/BlogListDashboard/Default.cshtml")]
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
#line 1 "C:\Users\Nani1\OneDrive\Masaüstü\CoreDemo\CoreDemo\Views\_ViewImports.cshtml"
using CoreDemo;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Nani1\OneDrive\Masaüstü\CoreDemo\CoreDemo\Views\_ViewImports.cshtml"
using CoreDemo.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\Nani1\OneDrive\Masaüstü\CoreDemo\CoreDemo\Views\Shared\Components\BlogListDashboard\Default.cshtml"
using EntityLayer.Concrete;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9c147af61c0cf29ce232a681bc3ce92c565d1b6a", @"/Views/Shared/Components/BlogListDashboard/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ac82c3bbfca83888214775683b20655a0c3863c3", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Shared_Components_BlogListDashboard_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Blog>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"
<div class=""row"">
    <div class=""col-12 grid-margin"">
        <div class=""card"">
            <div class=""card-body"">
                <h4 class=""card-title"">Son Bloglar</h4>
                <div class=""table-responsive"">
                    <table class=""table"">
                        <thead>
                            <tr>
                                <th> # </th>
                                <th> Başlık </th>
                                <th> Kategori </th>
                                <th> Tarih </th>
                                <th> Detaylar </th>
                            </tr>
                        </thead>
                        <tbody>
");
#nullable restore
#line 21 "C:\Users\Nani1\OneDrive\Masaüstü\CoreDemo\CoreDemo\Views\Shared\Components\BlogListDashboard\Default.cshtml"
                             foreach (var item in Model)
                            {


#line default
#line hidden
#nullable disable
            WriteLiteral("                                <tr>\n                                    <td> <img");
            BeginWriteAttribute("src", " src=\"", 892, "\"", 913, 1);
#nullable restore
#line 25 "C:\Users\Nani1\OneDrive\Masaüstü\CoreDemo\CoreDemo\Views\Shared\Components\BlogListDashboard\Default.cshtml"
WriteAttributeValue("", 898, item.BlogImage, 898, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"mr-2\" alt=\"image\"></td>\n                                    <td>");
#nullable restore
#line 26 "C:\Users\Nani1\OneDrive\Masaüstü\CoreDemo\CoreDemo\Views\Shared\Components\BlogListDashboard\Default.cshtml"
                                   Write(item.BlogTitle);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                                    <td><label class=\"badge badge-gradient-success\">");
#nullable restore
#line 27 "C:\Users\Nani1\OneDrive\Masaüstü\CoreDemo\CoreDemo\Views\Shared\Components\BlogListDashboard\Default.cshtml"
                                                                               Write(item.Category.CategoryName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</label></td>\n                                    <td>");
#nullable restore
#line 28 "C:\Users\Nani1\OneDrive\Masaüstü\CoreDemo\CoreDemo\Views\Shared\Components\BlogListDashboard\Default.cshtml"
                                    Write(((DateTime)item.BlogCreateDate).ToString("dd-MMM-yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                                    <td><a");
            BeginWriteAttribute("href", " href=\"", 1278, "\"", 1315, 2);
            WriteAttributeValue("", 1285, "/Blog/BlogReadAll/", 1285, 18, true);
#nullable restore
#line 29 "C:\Users\Nani1\OneDrive\Masaüstü\CoreDemo\CoreDemo\Views\Shared\Components\BlogListDashboard\Default.cshtml"
WriteAttributeValue("", 1303, item.BlogId, 1303, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn-sm btn-dark\">Detaylar</a></td>\n                                </tr>\n");
#nullable restore
#line 31 "C:\Users\Nani1\OneDrive\Masaüstü\CoreDemo\CoreDemo\Views\Shared\Components\BlogListDashboard\Default.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                        </tbody>\n                    </table>\n                </div>\n            </div>\n        </div>\n    </div>\n</div>");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Blog>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
