#pragma checksum "D:\Trainning\Asp.net\WA\WebApp\Views\Shared\Components\CitySummary\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5e7a36d71f9993ef772c4b389b6f5ae950173600"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_CitySummary_Default), @"mvc.1.0.view", @"/Views/Shared/Components/CitySummary/Default.cshtml")]
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
#line 1 "D:\Trainning\Asp.net\WA\WebApp\Views\_ViewImports.cshtml"
using WebApp.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Trainning\Asp.net\WA\WebApp\Views\_ViewImports.cshtml"
using WebApp.Components;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5e7a36d71f9993ef772c4b389b6f5ae950173600", @"/Views/Shared/Components/CitySummary/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7bf1e0455853615219468aa211163c948856cd27", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_CitySummary_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<CityViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<table");
            BeginWriteAttribute("class", " class=\"", 28, "\"", 94, 6);
            WriteAttributeValue("", 36, "table", 36, 5, true);
            WriteAttributeValue(" ", 41, "table-sm", 42, 9, true);
            WriteAttributeValue(" ", 50, "table-bordered", 51, 15, true);
            WriteAttributeValue(" ", 65, "text-white", 66, 11, true);
            WriteAttributeValue(" ", 76, "bg-", 77, 4, true);
#nullable restore
#line 2 "D:\Trainning\Asp.net\WA\WebApp\Views\Shared\Components\CitySummary\Default.cshtml"
WriteAttributeValue("", 80, ViewBag.Theme, 80, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n    <thead>\r\n        <tr><th colspan=\"2\">Cities Summary</th></tr>\r\n    </thead>\r\n    <tbody>\r\n        <tr>\r\n            <td>Cities:</td>\r\n            <td class=\"text-right\">\r\n                ");
#nullable restore
#line 10 "D:\Trainning\Asp.net\WA\WebApp\Views\Shared\Components\CitySummary\Default.cshtml"
           Write(Model.Cities);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n        <tr>\r\n            <td>Population:</td>\r\n            <td class=\"text-right\">\r\n                ");
#nullable restore
#line 16 "D:\Trainning\Asp.net\WA\WebApp\Views\Shared\Components\CitySummary\Default.cshtml"
           Write(Model.Population.ToString("#,###"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n    </tbody>\r\n</table>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<CityViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
