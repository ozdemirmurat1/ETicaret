#pragma checksum "C:\Users\90545\Desktop\YAZILIM\19022022\Eticaret.PresentationEnSon\Eticaret.PresentationEnSon\Views\Product\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "753fa56e15d8db75f8ee694ac12d0b7ed618d23f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Product_Index), @"mvc.1.0.view", @"/Views/Product/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"753fa56e15d8db75f8ee694ac12d0b7ed618d23f", @"/Views/Product/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fa9e1c4e8929a18c8462bfb821432a7469d1ea22", @"/Views/_ViewImports.cshtml")]
    public class Views_Product_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ProductViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("cart"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<div class=\"product-big-title-area\">\r\n    <div class=\"container\">\r\n        <div class=\"row\">\r\n            <div class=\"col-md-12\">\r\n                <div class=\"product-bit-title text-center\">\r\n                    <h2>");
#nullable restore
#line 8 "C:\Users\90545\Desktop\YAZILIM\19022022\Eticaret.PresentationEnSon\Eticaret.PresentationEnSon\Views\Product\Index.cshtml"
                   Write(Model.ProductDetail.Name.ToUpper());

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h2>
                </div>
            </div>
        </div>
    </div>
</div>


<div class=""single-product-area"">
    <div class=""zigzag-bottom""></div>
    <div class=""container"">
        <div class=""row"">

            <div class=""col-md-12"">
                <div class=""product-content-right"">
                    <div class=""product-breadcroumb"">
                        <a");
            BeginWriteAttribute("href", " href=\"", 672, "\"", 679, 0);
            EndWriteAttribute();
            WriteLiteral(">Home</a>\r\n");
            WriteLiteral("                        <a");
            BeginWriteAttribute("href", " href=\"", 775, "\"", 782, 0);
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 26 "C:\Users\90545\Desktop\YAZILIM\19022022\Eticaret.PresentationEnSon\Eticaret.PresentationEnSon\Views\Product\Index.cshtml"
                              Write(Model.ProductDetail.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</a>
                            </div>

                            <div class=""row"">
                                <div class=""col-sm-6"">
                                    <div class=""product-images"">
                                        <div class=""product-main-img"">
                                            <img");
            BeginWriteAttribute("src", " src=\"", 1142, "\"", 1183, 2);
            WriteAttributeValue("", 1148, "/product/", 1148, 9, true);
#nullable restore
#line 33 "C:\Users\90545\Desktop\YAZILIM\19022022\Eticaret.PresentationEnSon\Eticaret.PresentationEnSon\Views\Product\Index.cshtml"
WriteAttributeValue("", 1157, Model.Images.First().Name, 1157, 26, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 1184, "\"", 1190, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                                        </div>\r\n\r\n                                        <div class=\"product-gallery\">\r\n");
#nullable restore
#line 37 "C:\Users\90545\Desktop\YAZILIM\19022022\Eticaret.PresentationEnSon\Eticaret.PresentationEnSon\Views\Product\Index.cshtml"
                                             foreach (var item in Model.Images)
                                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                <img");
            BeginWriteAttribute("src", " src=\"", 1495, "\"", 1520, 2);
            WriteAttributeValue("", 1501, "/product/", 1501, 9, true);
#nullable restore
#line 39 "C:\Users\90545\Desktop\YAZILIM\19022022\Eticaret.PresentationEnSon\Eticaret.PresentationEnSon\Views\Product\Index.cshtml"
WriteAttributeValue("", 1510, item.Name, 1510, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 1521, "\"", 1527, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n");
#nullable restore
#line 40 "C:\Users\90545\Desktop\YAZILIM\19022022\Eticaret.PresentationEnSon\Eticaret.PresentationEnSon\Views\Product\Index.cshtml"
                                            }                                           

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                        </div>
                                    </div>
                                </div>

                                <div class=""col-sm-6"">
                                    <div class=""product-inner"">
                                        <h2 class=""product-name"">");
#nullable restore
#line 48 "C:\Users\90545\Desktop\YAZILIM\19022022\Eticaret.PresentationEnSon\Eticaret.PresentationEnSon\Views\Product\Index.cshtml"
                                                            Write(Model.ProductDetail.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n                                        <div class=\"product-inner-price\">\r\n                                            <ins>");
#nullable restore
#line 50 "C:\Users\90545\Desktop\YAZILIM\19022022\Eticaret.PresentationEnSon\Eticaret.PresentationEnSon\Views\Product\Index.cshtml"
                                            Write(Model.ProductDetail.Price.ToString("C"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</ins> <del>");
#nullable restore
#line 50 "C:\Users\90545\Desktop\YAZILIM\19022022\Eticaret.PresentationEnSon\Eticaret.PresentationEnSon\Views\Product\Index.cshtml"
                                                                                                Write(Html.Raw((Model.ProductDetail.Price-10).ToString("C")));

#line default
#line hidden
#nullable disable
            WriteLiteral("</del>\r\n                                        </div>\r\n\r\n                                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "753fa56e15d8db75f8ee694ac12d0b7ed618d23f9675", async() => {
                WriteLiteral(@"
                                            <div class=""quantity"">
                                                <input type=""number"" size=""4"" class=""input-text qty text"" title=""Qty"" value=""1"" name=""quantity"" min=""1"" step=""1"">
                                            </div>
                                            <button class=""add_to_cart_button"" type=""submit"">Add to cart</button>
                                        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n                                        <div class=\"product-inner-category\">\r\n                                            <p>Category: <a");
            BeginWriteAttribute("href", " href=\"", 2921, "\"", 2928, 0);
            EndWriteAttribute();
            WriteLiteral(">Summer</a>. Tags: <a");
            BeginWriteAttribute("href", " href=\"", 2950, "\"", 2957, 0);
            EndWriteAttribute();
            WriteLiteral(">awesome</a>, <a");
            BeginWriteAttribute("href", " href=\"", 2974, "\"", 2981, 0);
            EndWriteAttribute();
            WriteLiteral(">best</a>, <a");
            BeginWriteAttribute("href", " href=\"", 2995, "\"", 3002, 0);
            EndWriteAttribute();
            WriteLiteral(">sale</a>, <a");
            BeginWriteAttribute("href", " href=\"", 3016, "\"", 3023, 0);
            EndWriteAttribute();
            WriteLiteral(@">shoes</a>. </p>
                                        </div>

                                        <div role=""tabpanel"">
                                            <ul class=""product-tab"" role=""tablist"">
                                                <li role=""presentation"" class=""active""><a href=""#home"" aria-controls=""home"" role=""tab"" data-toggle=""tab"">Description</a></li>
                                                <li role=""presentation""><a href=""#profile"" aria-controls=""profile"" role=""tab"" data-toggle=""tab"">Reviews</a></li>
                                            </ul>
                                            <div class=""tab-content"">
                                                <div role=""tabpanel"" class=""tab-pane fade in active"" id=""home"">
                                                    <h2>Product Description</h2>
                                                    <p>");
#nullable restore
#line 72 "C:\Users\90545\Desktop\YAZILIM\19022022\Eticaret.PresentationEnSon\Eticaret.PresentationEnSon\Views\Product\Index.cshtml"
                                                  Write(Model.ProductDetail.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</p>

                                                </div>
                                                <div role=""tabpanel"" class=""tab-pane fade"" id=""profile"">
                                                    <h2>Reviews</h2>
                                                    <div class=""submit-review"">
                                                        <p><label for=""name"">Name</label> <input name=""name"" type=""text""></p>
                                                        <p><label for=""email"">Email</label> <input name=""email"" type=""email""></p>
                                                        <div class=""rating-chooser"">
                                                            <p>Your rating</p>

                                                            <div class=""rating-wrap-post"">
                                                                <i class=""fa fa-star""></i>
                                                                <i class=""fa fa-star""></i>
 ");
            WriteLiteral(@"                                                               <i class=""fa fa-star""></i>
                                                                <i class=""fa fa-star""></i>
                                                                <i class=""fa fa-star""></i>
                                                            </div>
                                                        </div>
                                                        <p><label for=""review"">Your review</label> <textarea name=""review""");
            BeginWriteAttribute("id", " id=\"", 5534, "\"", 5539, 0);
            EndWriteAttribute();
            WriteLiteral(@" cols=""30"" rows=""10""></textarea></p>
                                                        <p><input type=""submit"" value=""Submit""></p>
                                                    </div>
                                                </div>
                                            </div>
                                        </div>

                                    </div>
                                </div>
                            </div>


                            <div class=""related-products-wrapper"">
                                <h2 class=""related-products-title"">Related Products</h2>
                                <div class=""related-products-carousel"">
                                    <div class=""single-product"">
                                        <div class=""product-f-image"">
                                            <img src=""img/product-1.jpg""");
            BeginWriteAttribute("alt", " alt=\"", 6461, "\"", 6467, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                                            <div class=\"product-hover\">\r\n                                                <a");
            BeginWriteAttribute("href", " href=\"", 6594, "\"", 6601, 0);
            EndWriteAttribute();
            WriteLiteral(" class=\"add-to-cart-link\"><i class=\"fa fa-shopping-cart\"></i> Add to cart</a>\r\n                                                <a");
            BeginWriteAttribute("href", " href=\"", 6731, "\"", 6738, 0);
            EndWriteAttribute();
            WriteLiteral(" class=\"view-details-link\"><i class=\"fa fa-link\"></i> See details</a>\r\n                                            </div>\r\n                                        </div>\r\n\r\n                                        <h2><a");
            BeginWriteAttribute("href", " href=\"", 6958, "\"", 6965, 0);
            EndWriteAttribute();
            WriteLiteral(@">Sony Smart TV - 2015</a></h2>

                                        <div class=""product-carousel-price"">
                                            <ins>$700.00</ins> <del>$100.00</del>
                                        </div>
                                    </div>
                                    <div class=""single-product"">
                                        <div class=""product-f-image"">
                                            <img src=""img/product-2.jpg""");
            BeginWriteAttribute("alt", " alt=\"", 7462, "\"", 7468, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                                            <div class=\"product-hover\">\r\n                                                <a");
            BeginWriteAttribute("href", " href=\"", 7595, "\"", 7602, 0);
            EndWriteAttribute();
            WriteLiteral(" class=\"add-to-cart-link\"><i class=\"fa fa-shopping-cart\"></i> Add to cart</a>\r\n                                                <a");
            BeginWriteAttribute("href", " href=\"", 7732, "\"", 7739, 0);
            EndWriteAttribute();
            WriteLiteral(" class=\"view-details-link\"><i class=\"fa fa-link\"></i> See details</a>\r\n                                            </div>\r\n                                        </div>\r\n\r\n                                        <h2><a");
            BeginWriteAttribute("href", " href=\"", 7959, "\"", 7966, 0);
            EndWriteAttribute();
            WriteLiteral(@">Apple new mac book 2015 March :P</a></h2>
                                        <div class=""product-carousel-price"">
                                            <ins>$899.00</ins> <del>$999.00</del>
                                        </div>
                                    </div>
                                    <div class=""single-product"">
                                        <div class=""product-f-image"">
                                            <img src=""img/product-3.jpg""");
            BeginWriteAttribute("alt", " alt=\"", 8473, "\"", 8479, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                                            <div class=\"product-hover\">\r\n                                                <a");
            BeginWriteAttribute("href", " href=\"", 8606, "\"", 8613, 0);
            EndWriteAttribute();
            WriteLiteral(" class=\"add-to-cart-link\"><i class=\"fa fa-shopping-cart\"></i> Add to cart</a>\r\n                                                <a");
            BeginWriteAttribute("href", " href=\"", 8743, "\"", 8750, 0);
            EndWriteAttribute();
            WriteLiteral(" class=\"view-details-link\"><i class=\"fa fa-link\"></i> See details</a>\r\n                                            </div>\r\n                                        </div>\r\n\r\n                                        <h2><a");
            BeginWriteAttribute("href", " href=\"", 8970, "\"", 8977, 0);
            EndWriteAttribute();
            WriteLiteral(@">Apple new i phone 6</a></h2>

                                        <div class=""product-carousel-price"">
                                            <ins>$400.00</ins> <del>$425.00</del>
                                        </div>
                                    </div>
                                    <div class=""single-product"">
                                        <div class=""product-f-image"">
                                            <img src=""img/product-4.jpg""");
            BeginWriteAttribute("alt", " alt=\"", 9473, "\"", 9479, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                                            <div class=\"product-hover\">\r\n                                                <a");
            BeginWriteAttribute("href", " href=\"", 9606, "\"", 9613, 0);
            EndWriteAttribute();
            WriteLiteral(" class=\"add-to-cart-link\"><i class=\"fa fa-shopping-cart\"></i> Add to cart</a>\r\n                                                <a");
            BeginWriteAttribute("href", " href=\"", 9743, "\"", 9750, 0);
            EndWriteAttribute();
            WriteLiteral(" class=\"view-details-link\"><i class=\"fa fa-link\"></i> See details</a>\r\n                                            </div>\r\n                                        </div>\r\n\r\n                                        <h2><a");
            BeginWriteAttribute("href", " href=\"", 9970, "\"", 9977, 0);
            EndWriteAttribute();
            WriteLiteral(@">Sony playstation microsoft</a></h2>

                                        <div class=""product-carousel-price"">
                                            <ins>$200.00</ins> <del>$225.00</del>
                                        </div>
                                    </div>
                                    <div class=""single-product"">
                                        <div class=""product-f-image"">
                                            <img src=""img/product-5.jpg""");
            BeginWriteAttribute("alt", " alt=\"", 10480, "\"", 10486, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                                            <div class=\"product-hover\">\r\n                                                <a");
            BeginWriteAttribute("href", " href=\"", 10613, "\"", 10620, 0);
            EndWriteAttribute();
            WriteLiteral(" class=\"add-to-cart-link\"><i class=\"fa fa-shopping-cart\"></i> Add to cart</a>\r\n                                                <a");
            BeginWriteAttribute("href", " href=\"", 10750, "\"", 10757, 0);
            EndWriteAttribute();
            WriteLiteral(" class=\"view-details-link\"><i class=\"fa fa-link\"></i> See details</a>\r\n                                            </div>\r\n                                        </div>\r\n\r\n                                        <h2><a");
            BeginWriteAttribute("href", " href=\"", 10977, "\"", 10984, 0);
            EndWriteAttribute();
            WriteLiteral(@">Sony Smart Air Condtion</a></h2>

                                        <div class=""product-carousel-price"">
                                            <ins>$1200.00</ins> <del>$1355.00</del>
                                        </div>
                                    </div>
                                    <div class=""single-product"">
                                        <div class=""product-f-image"">
                                            <img src=""img/product-6.jpg""");
            BeginWriteAttribute("alt", " alt=\"", 11486, "\"", 11492, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                                            <div class=\"product-hover\">\r\n                                                <a");
            BeginWriteAttribute("href", " href=\"", 11619, "\"", 11626, 0);
            EndWriteAttribute();
            WriteLiteral(" class=\"add-to-cart-link\"><i class=\"fa fa-shopping-cart\"></i> Add to cart</a>\r\n                                                <a");
            BeginWriteAttribute("href", " href=\"", 11756, "\"", 11763, 0);
            EndWriteAttribute();
            WriteLiteral(" class=\"view-details-link\"><i class=\"fa fa-link\"></i> See details</a>\r\n                                            </div>\r\n                                        </div>\r\n\r\n                                        <h2><a");
            BeginWriteAttribute("href", " href=\"", 11983, "\"", 11990, 0);
            EndWriteAttribute();
            WriteLiteral(@">Samsung gallaxy note 4</a></h2>

                                        <div class=""product-carousel-price"">
                                            <ins>$400.00</ins>
                                        </div>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ProductViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
