#pragma checksum "C:\Users\90545\Desktop\YAZILIM\19022022\Eticaret.PresentationEnSon\Eticaret.PresentationEnSon\Views\Shared\Components\MainMenuArea\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9bb4257312b56d1a986b4285e88c72a36577d0ec"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_MainMenuArea_Default), @"mvc.1.0.view", @"/Views/Shared/Components/MainMenuArea/Default.cshtml")]
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
#line 1 "C:\Users\90545\Desktop\YAZILIM\19022022\Eticaret.PresentationEnSon\Eticaret.PresentationEnSon\Views\_ViewImports.cshtml"
using Eticaret.PresentationEnSon;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\90545\Desktop\YAZILIM\19022022\Eticaret.PresentationEnSon\Eticaret.PresentationEnSon\Views\_ViewImports.cshtml"
using Eticaret.PresentationEnSon.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\90545\Desktop\YAZILIM\19022022\Eticaret.PresentationEnSon\Eticaret.PresentationEnSon\Views\Shared\Components\MainMenuArea\Default.cshtml"
using Eticaret.Entities;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9bb4257312b56d1a986b4285e88c72a36577d0ec", @"/Views/Shared/Components/MainMenuArea/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fa9e1c4e8929a18c8462bfb821432a7469d1ea22", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_MainMenuArea_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Category>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"
<div class=""mainmenu-area"">
    <div class=""container"">
        <div class=""row"">
            <div class=""navbar-header"">
                <button type=""button"" class=""navbar-toggle"" data-toggle=""collapse"" data-target="".navbar-collapse"">
                    <span class=""sr-only"">Toggle navigation</span>
                    <span class=""icon-bar""></span>
                    <span class=""icon-bar""></span>
                    <span class=""icon-bar""></span>
                </button>
            </div>
            <div class=""navbar-collapse collapse"">
                <ul class=""nav navbar-nav"">
");
#nullable restore
#line 17 "C:\Users\90545\Desktop\YAZILIM\19022022\Eticaret.PresentationEnSon\Eticaret.PresentationEnSon\Views\Shared\Components\MainMenuArea\Default.cshtml"
                     foreach (var item in Model)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <li");
            BeginWriteAttribute("class", " class=\"", 761, "\"", 769, 0);
            EndWriteAttribute();
            WriteLiteral("><a");
            BeginWriteAttribute("href", " href=\"", 773, "\"", 803, 2);
            WriteAttributeValue("", 780, "/kategori/", 780, 10, true);
#nullable restore
#line 19 "C:\Users\90545\Desktop\YAZILIM\19022022\Eticaret.PresentationEnSon\Eticaret.PresentationEnSon\Views\Shared\Components\MainMenuArea\Default.cshtml"
WriteAttributeValue("", 790, item.SeoName, 790, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 19 "C:\Users\90545\Desktop\YAZILIM\19022022\Eticaret.PresentationEnSon\Eticaret.PresentationEnSon\Views\Shared\Components\MainMenuArea\Default.cshtml"
                                                                  Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></li>\r\n");
#nullable restore
#line 20 "C:\Users\90545\Desktop\YAZILIM\19022022\Eticaret.PresentationEnSon\Eticaret.PresentationEnSon\Views\Shared\Components\MainMenuArea\Default.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    \r\n                </ul>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div> <!-- End mainmenu area -->\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Category>> Html { get; private set; }
    }
}
#pragma warning restore 1591
