#pragma checksum "D:\Trainning\Asp.net\WA\WebApp\Pages\Shared\_ProductPartial.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5de8d8d34696a331d90892f281922481b53f6a8a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(WebApp.Pages.Shared.Pages_Shared__ProductPartial), @"mvc.1.0.view", @"/Pages/Shared/_ProductPartial.cshtml")]
namespace WebApp.Pages.Shared
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
#line 2 "D:\Trainning\Asp.net\WA\WebApp\Pages\_ViewImports.cshtml"
using WebApp.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5de8d8d34696a331d90892f281922481b53f6a8a", @"/Pages/Shared/_ProductPartial.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"89200d1c42b8de9ce4c0b017051217c34884f0db", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Shared__ProductPartial : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Product>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<div class=\"m-2\">\r\n    <table class=\"table table-sm table-striped table-bordered\">\r\n        <tbody>\r\n            <tr><th>Name</th><td>");
#nullable restore
#line 5 "D:\Trainning\Asp.net\WA\WebApp\Pages\Shared\_ProductPartial.cshtml"
                            Write(Model.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td></tr>\r\n            <tr><th>Price</th><td>");
#nullable restore
#line 6 "D:\Trainning\Asp.net\WA\WebApp\Pages\Shared\_ProductPartial.cshtml"
                             Write(Model.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td></tr>\r\n        </tbody>\r\n    </table>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Product> Html { get; private set; }
    }
}
#pragma warning restore 1591
