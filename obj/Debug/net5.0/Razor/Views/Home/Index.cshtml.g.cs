#pragma checksum "D:\drace\novaplocha\jedno\KlubPratelTaborovychOhnu\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "36c43373215d6e39f0c39c9ba5a19bca8ab48f18"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#line 1 "D:\drace\novaplocha\jedno\KlubPratelTaborovychOhnu\Views\_ViewImports.cshtml"
using KlubPrátelTaborovychOhnu;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\drace\novaplocha\jedno\KlubPratelTaborovychOhnu\Views\_ViewImports.cshtml"
using KlubPrátelTaborovychOhnu.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\drace\novaplocha\jedno\KlubPratelTaborovychOhnu\Views\_ViewImports.cshtml"
using KlubPrátelTaborovychOhnu.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"36c43373215d6e39f0c39c9ba5a19bca8ab48f18", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"759356c31cec525b3cf8bb7da92da5e8b310147e", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "D:\drace\novaplocha\jedno\KlubPratelTaborovychOhnu\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Domovská Stránka";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"text-center\">\r\n    <h1 class=\"display-4\">");
#nullable restore
#line 6 "D:\drace\novaplocha\jedno\KlubPratelTaborovychOhnu\Views\Home\Index.cshtml"
                     Write(ViewData["Title"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h1>
</div>
    <h6>ToDo List:</h6>
    <ul>
        <li>
            Repozitáře pro modely
        </li>
        <li>
            Zkusit si dependency injection
        </li>
        <li>
            Unit of work
        </li>
        <li>
            Unit testing
        </li>       
    </ul>

");
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
