#pragma checksum "C:\Users\Nani1\OneDrive\Masaüstü\CoreDemo\CoreDemo\Views\Shared\Components\WriterNotification\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "87efc504267ceb0f55f996727b17ea4e5b4aaf81"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_WriterNotification_Default), @"mvc.1.0.view", @"/Views/Shared/Components/WriterNotification/Default.cshtml")]
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
#line 1 "C:\Users\Nani1\OneDrive\Masaüstü\CoreDemo\CoreDemo\Views\Shared\Components\WriterNotification\Default.cshtml"
using EntityLayer.Concrete;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"87efc504267ceb0f55f996727b17ea4e5b4aaf81", @"/Views/Shared/Components/WriterNotification/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ac82c3bbfca83888214775683b20655a0c3863c3", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Shared_Components_WriterNotification_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Notification>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n<div class=\"dropdown-menu dropdown-menu-right navbar-dropdown preview-list\" aria-labelledby=\"notificationDropdown\">\n    <h6 class=\"p-3 mb-0\">Bildirimler</h6>\n");
#nullable restore
#line 6 "C:\Users\Nani1\OneDrive\Masaüstü\CoreDemo\CoreDemo\Views\Shared\Components\WriterNotification\Default.cshtml"
     foreach (var item in Model.Where(x => x.NotificationStatus == true).OrderByDescending(x => x.NotificationId).Take(4))
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"dropdown-divider\"></div>\n        <a class=\"dropdown-item preview-item\">\n            <div class=\"preview-thumbnail\">\n                <div");
            BeginWriteAttribute("class", " class=\"", 498, "\"", 529, 1);
#nullable restore
#line 11 "C:\Users\Nani1\OneDrive\Masaüstü\CoreDemo\CoreDemo\Views\Shared\Components\WriterNotification\Default.cshtml"
WriteAttributeValue("", 506, item.NotificationColor, 506, 23, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\n                    <i");
            BeginWriteAttribute("class", " class=\"", 554, "\"", 590, 1);
#nullable restore
#line 12 "C:\Users\Nani1\OneDrive\Masaüstü\CoreDemo\CoreDemo\Views\Shared\Components\WriterNotification\Default.cshtml"
WriteAttributeValue("", 562, item.NotificationTypeSymbol, 562, 28, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("></i>\n                </div>\n            </div>\n            <div class=\"preview-item-content d-flex align-items-start flex-column justify-content-center\">\n                <h6 class=\"preview-subject font-weight-normal mb-1\">");
#nullable restore
#line 16 "C:\Users\Nani1\OneDrive\Masaüstü\CoreDemo\CoreDemo\Views\Shared\Components\WriterNotification\Default.cshtml"
                                                               Write(item.NotificationType);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h6>\n                <p class=\"text-gray ellipsis mb-0\">");
#nullable restore
#line 17 "C:\Users\Nani1\OneDrive\Masaüstü\CoreDemo\CoreDemo\Views\Shared\Components\WriterNotification\Default.cshtml"
                                              Write(item.NotificationDetails);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n            </div>\n        </a>\n");
#nullable restore
#line 20 "C:\Users\Nani1\OneDrive\Masaüstü\CoreDemo\CoreDemo\Views\Shared\Components\WriterNotification\Default.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\n    <div class=\"dropdown-divider\"></div>\n    <h6 class=\"p-3 mb-0 text-center\">Tüm Bildirimleri Gör</h6>\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Notification>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591