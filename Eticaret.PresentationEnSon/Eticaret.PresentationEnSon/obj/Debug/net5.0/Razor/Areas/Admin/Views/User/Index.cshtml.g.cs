#pragma checksum "C:\Users\90545\Desktop\YAZILIM\19022022\Eticaret.PresentationEnSon\Eticaret.PresentationEnSon\Areas\Admin\Views\User\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "16631e2dd1928a11d5374b02b39752c6d9070b27"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_User_Index), @"mvc.1.0.view", @"/Areas/Admin/Views/User/Index.cshtml")]
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
#line 1 "C:\Users\90545\Desktop\YAZILIM\19022022\Eticaret.PresentationEnSon\Eticaret.PresentationEnSon\Areas\Admin\Views\_ViewImports.cshtml"
using Eticaret.PresentationEnSon;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\90545\Desktop\YAZILIM\19022022\Eticaret.PresentationEnSon\Eticaret.PresentationEnSon\Areas\Admin\Views\_ViewImports.cshtml"
using Eticaret.PresentationEnSon.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\90545\Desktop\YAZILIM\19022022\Eticaret.PresentationEnSon\Eticaret.PresentationEnSon\Areas\Admin\Views\User\Index.cshtml"
using Eticaret.PresentationEnSon.Areas.Admin.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"16631e2dd1928a11d5374b02b39752c6d9070b27", @"/Areas/Admin/Views/User/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fa9e1c4e8929a18c8462bfb821432a7469d1ea22", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_User_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<UserListViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 4 "C:\Users\90545\Desktop\YAZILIM\19022022\Eticaret.PresentationEnSon\Eticaret.PresentationEnSon\Areas\Admin\Views\User\Index.cshtml"
   
    Layout = "_Layout";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<div class=""content-wrapper"">
    <!-- Content Header (Page header) -->
    <section class=""content-header"">
        <div class=""container-fluid"">
            <div class=""row mb-2"">
                <div class=""col-sm-6"">
                    <h1>DataTables</h1>
                </div>
                <div class=""col-sm-6"">
                    <ol class=""breadcrumb float-sm-right"">
                        <li class=""breadcrumb-item""><a href=""#"">Home</a></li>
                        <li class=""breadcrumb-item active"">DataTables</li>
                    </ol>
                </div>
            </div>
        </div><!-- /.container-fluid -->
    </section>

    <!-- Main content -->
    <section class=""content"">
        <div class=""container-fluid"">
            <div class=""row"">
                <div class=""col-12"">
                    
                    <!-- /.card -->

                    <div class=""card"">
                        <div class=""card-header"">
                            ");
            WriteLiteral(@"<h3 class=""card-title"">Kullanıcı Listesi</h3>
                        </div>
                        <!-- /.card-header -->
                        <div class=""card-body"">
                            <table id=""example1"" class=""table table-bordered table-striped"">
                                <thead>
                                    <tr>
                                        <th>Id</th>
                                        <th>Email</th>
                                        <th>Admin Özelliği</th>
                                        <th>İşlemler</th>
                                        
                                    </tr>
                                </thead>
                                <tbody>
");
#nullable restore
#line 50 "C:\Users\90545\Desktop\YAZILIM\19022022\Eticaret.PresentationEnSon\Eticaret.PresentationEnSon\Areas\Admin\Views\User\Index.cshtml"
                                     foreach (var item in Model.List)
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <tr>\r\n                                            <td>");
#nullable restore
#line 53 "C:\Users\90545\Desktop\YAZILIM\19022022\Eticaret.PresentationEnSon\Eticaret.PresentationEnSon\Areas\Admin\Views\User\Index.cshtml"
                                           Write(item.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                            <td>");
#nullable restore
#line 54 "C:\Users\90545\Desktop\YAZILIM\19022022\Eticaret.PresentationEnSon\Eticaret.PresentationEnSon\Areas\Admin\Views\User\Index.cshtml"
                                           Write(item.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                            <td>");
#nullable restore
#line 55 "C:\Users\90545\Desktop\YAZILIM\19022022\Eticaret.PresentationEnSon\Eticaret.PresentationEnSon\Areas\Admin\Views\User\Index.cshtml"
                                           Write(Html.Raw(item.IsAdmin==true ? "Admin":"Normal User"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                            <td><a");
            BeginWriteAttribute("href", " href=\"", 2337, "\"", 2369, 2);
            WriteAttributeValue("", 2344, "/admin/user/edit/", 2344, 17, true);
#nullable restore
#line 56 "C:\Users\90545\Desktop\YAZILIM\19022022\Eticaret.PresentationEnSon\Eticaret.PresentationEnSon\Areas\Admin\Views\User\Index.cshtml"
WriteAttributeValue("", 2361, item.Id, 2361, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Düzenle</a> | <a");
            BeginWriteAttribute("href", " href=\"", 2387, "\"", 2421, 2);
            WriteAttributeValue("", 2394, "/admin/user/delete/", 2394, 19, true);
#nullable restore
#line 56 "C:\Users\90545\Desktop\YAZILIM\19022022\Eticaret.PresentationEnSon\Eticaret.PresentationEnSon\Areas\Admin\Views\User\Index.cshtml"
WriteAttributeValue("", 2413, item.Id, 2413, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Sil</a></td>\r\n                                        </tr>\r\n");
#nullable restore
#line 58 "C:\Users\90545\Desktop\YAZILIM\19022022\Eticaret.PresentationEnSon\Eticaret.PresentationEnSon\Areas\Admin\Views\User\Index.cshtml"
                                    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                </tbody>
                                <tfoot>
                                    <tr>
                                        <th>Id</th>
                                        <th>Email</th>
                                        <th>Admin Özelliği</th>
                                        <th>İşlemler</th>
                                    </tr>
                                </tfoot>
                            </table>
                        </div>
                        <!-- /.card-body -->
                    </div>
                    <!-- /.card -->
                </div>
                <!-- /.col -->
            </div>
            <!-- /.row -->
        </div>
        <!-- /.container-fluid -->
    </section>
    <!-- /.content -->
</div>
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<UserListViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
