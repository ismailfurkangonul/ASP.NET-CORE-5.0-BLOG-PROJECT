#pragma checksum "C:\Users\Nani1\OneDrive\Masaüstü\CoreDemo\CoreDemo\Views\Shared\Components\BlogLast3Post\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "07e06f38f8d25e4ae1c03427a9a3d80136027c63"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_BlogLast3Post_Default), @"mvc.1.0.view", @"/Views/Shared/Components/BlogLast3Post/Default.cshtml")]
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
#line 1 "C:\Users\Nani1\OneDrive\Masaüstü\CoreDemo\CoreDemo\Views\Shared\Components\BlogLast3Post\Default.cshtml"
using EntityLayer.Concrete;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"07e06f38f8d25e4ae1c03427a9a3d80136027c63", @"/Views/Shared/Components/BlogLast3Post/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ac82c3bbfca83888214775683b20655a0c3863c3", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Shared_Components_BlogLast3Post_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Blog>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n<div class=\"tech-btm\">\n    <h3>Last Posts</h3>\n");
#nullable restore
#line 6 "C:\Users\Nani1\OneDrive\Masaüstü\CoreDemo\CoreDemo\Views\Shared\Components\BlogLast3Post\Default.cshtml"
     foreach (var item in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"blog-grids row mb-3\">\n            <div class=\"col-md-5 blog-grid-left\">\n                <a");
            BeginWriteAttribute("href", " href=\"", 243, "\"", 280, 2);
            WriteAttributeValue("", 250, "/Blog/BlogReadAll/", 250, 18, true);
#nullable restore
#line 10 "C:\Users\Nani1\OneDrive\Masaüstü\CoreDemo\CoreDemo\Views\Shared\Components\BlogLast3Post\Default.cshtml"
WriteAttributeValue("", 268, item.BlogId, 268, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\n                    <img");
            BeginWriteAttribute("src", " src=\"", 307, "\"", 328, 1);
#nullable restore
#line 11 "C:\Users\Nani1\OneDrive\Masaüstü\CoreDemo\CoreDemo\Views\Shared\Components\BlogLast3Post\Default.cshtml"
WriteAttributeValue("", 313, item.BlogImage, 313, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"card-img-top img-fluid\"");
            BeginWriteAttribute("alt", " alt=\"", 360, "\"", 366, 0);
            EndWriteAttribute();
            WriteLiteral(">\n                </a>\n            </div>\n\n\n            <div class=\"col-md-7 blog-grid-right\">\n\n                <h5>\n                    <a");
            BeginWriteAttribute("href", " href=\"", 506, "\"", 543, 2);
            WriteAttributeValue("", 513, "/Blog/BlogReadAll/", 513, 18, true);
#nullable restore
#line 19 "C:\Users\Nani1\OneDrive\Masaüstü\CoreDemo\CoreDemo\Views\Shared\Components\BlogLast3Post\Default.cshtml"
WriteAttributeValue("", 531, item.BlogId, 531, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 19 "C:\Users\Nani1\OneDrive\Masaüstü\CoreDemo\CoreDemo\Views\Shared\Components\BlogLast3Post\Default.cshtml"
                                                        Write(item.BlogContent.Substring(0, item.BlogContent.Substring(0, 50).LastIndexOf(" ")));

#line default
#line hidden
#nullable disable
            WriteLiteral("... </a>\n                </h5>\n                <div class=\"sub-meta\">\n                    <span>\n                        <i class=\"far fa-clock\"></i> ");
#nullable restore
#line 23 "C:\Users\Nani1\OneDrive\Masaüstü\CoreDemo\CoreDemo\Views\Shared\Components\BlogLast3Post\Default.cshtml"
                                                 Write(((DateTime)item.BlogCreateDate).ToString("dd-MMM-yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                    </span>\n                </div>\n            </div>\n\n        </div>\n");
#nullable restore
#line 29 "C:\Users\Nani1\OneDrive\Masaüstü\CoreDemo\CoreDemo\Views\Shared\Components\BlogLast3Post\Default.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\n</div>\n");
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
