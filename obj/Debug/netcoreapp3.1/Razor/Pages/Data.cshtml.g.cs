#pragma checksum "D:\Trainning\Asp.net\WA\WebApp\Pages\Data.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "89ce4cc42cdaafbd811fc6ff5007a09960c1c830"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(WebApp.Pages.Pages_Data), @"mvc.1.0.razor-page", @"/Pages/Data.cshtml")]
namespace WebApp.Pages
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
#nullable restore
#line 3 "D:\Trainning\Asp.net\WA\WebApp\Pages\Data.cshtml"
using Microsoft.AspNetCore.Mvc.RazorPages;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"89ce4cc42cdaafbd811fc6ff5007a09960c1c830", @"/Pages/Data.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"89200d1c42b8de9ce4c0b017051217c34884f0db", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Data : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<h5 class=\"bg-primary  text-white text-center m-2 p-2\">Categories</h5>\r\n<ul class=\"list-group m-2\">\r\n");
#nullable restore
#line 7 "D:\Trainning\Asp.net\WA\WebApp\Pages\Data.cshtml"
     foreach(Category  c in Model.Categories)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <li class=\"list-group-item\">");
#nullable restore
#line 9 "D:\Trainning\Asp.net\WA\WebApp\Pages\Data.cshtml"
                               Write(c.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n");
#nullable restore
#line 10 "D:\Trainning\Asp.net\WA\WebApp\Pages\Data.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</ul>\r\n\r\n");
        }
        #pragma warning restore 1998
#nullable restore
#line 13 "D:\Trainning\Asp.net\WA\WebApp\Pages\Data.cshtml"
            
    public class DataPageModel : PageModel
    {
        private DataContext context;
        public IEnumerable<Category> Categories { set; get; }
        public DataPageModel(DataContext ctx)
        {
            context = ctx;
        }

        public void OnGet()
        {
            Categories = context.Categories;
        }
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<DataPageModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<DataPageModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<DataPageModel>)PageContext?.ViewData;
        public DataPageModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591