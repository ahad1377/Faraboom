#pragma checksum "c:\Users\Neati\Desktop\nikatak\Faraboom\faraboom\Views\Blog\details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "aa830919b8076dd09cbdcb1ef145be9b8254f92a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Blog_details), @"mvc.1.0.view", @"/Views/Blog/details.cshtml")]
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
#line 1 "c:\Users\Neati\Desktop\nikatak\Faraboom\faraboom\Views\_ViewImports.cshtml"
using faraboom;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "c:\Users\Neati\Desktop\nikatak\Faraboom\faraboom\Views\_ViewImports.cshtml"
using faraboom.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"aa830919b8076dd09cbdcb1ef145be9b8254f92a", @"/Views/Blog/details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"579044271ce4d686d4ad757e422253e06801c350", @"/Views/_ViewImports.cshtml")]
    public class Views_Blog_details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<DataLayer.AdminEntities.Blog.Tb_Blog>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("img-fluid rad25 pb-3 w-75"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/site/Images/avatar.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("img-fluid mb-2 rounded-circle"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"
<section class=""container-fluid mt-3 pb-4 pb-lg-0"">
    <div class=""container p-5 box"">
        <div class=""row"">
            <div class=""col-lg-12"">
                <nav aria-label=""breadcrumb "">
                    <ol class=""breadcrumb mb-0 rad25"">
                        <li class=""breadcrumb-item""><a href=""#"">صفحه اصلی</a></li>
                        <li class=""breadcrumb-item""><a href=""#"">وبلاگ</a></li>
                        <li class=""breadcrumb-item active"" aria-current=""page"">جزئیات وبلاگ نیکاتک</li>
                    </ol>
                </nav>
                <div id=""blog_details"">
                    <h5 class=""pt-3 IRANSansWeb_Medium"">");
#nullable restore
#line 15 "c:\Users\Neati\Desktop\nikatak\Faraboom\faraboom\Views\Blog\details.cshtml"
                                                   Write(Model.TitleBLo);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n                    <p\r\n                                        style=\"text-align: ;line-height: 40px;font-size: 14px;text-align: justify;padding-left: 20px;\">\r\n                                        ");
#nullable restore
#line 18 "c:\Users\Neati\Desktop\nikatak\Faraboom\faraboom\Views\Blog\details.cshtml"
                                   Write(Model.SummaryBlo);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n                                    </p>\r\n");
            WriteLiteral("                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "aa830919b8076dd09cbdcb1ef145be9b8254f92a5738", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1133, "~/fileupload/", 1133, 13, true);
#nullable restore
#line 23 "c:\Users\Neati\Desktop\nikatak\Faraboom\faraboom\Views\Blog\details.cshtml"
AddHtmlAttributeValue("", 1146, Model.ImageMainBlo, 1146, 19, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 24 "c:\Users\Neati\Desktop\nikatak\Faraboom\faraboom\Views\Blog\details.cshtml"
                     if (Model.FullTextBlo != null)
                    {
                                              

#line default
#line hidden
#nullable disable
#nullable restore
#line 26 "c:\Users\Neati\Desktop\nikatak\Faraboom\faraboom\Views\Blog\details.cshtml"
                                         Write(Html.Raw(Model.FullTextBlo.Replace("contenteditable=", "").Replace("left: 388.859px; top: 107.899px","display:none").Replace("ql-tooltip ql-hidden"," d-none")));

#line default
#line hidden
#nullable disable
#nullable restore
#line 26 "c:\Users\Neati\Desktop\nikatak\Faraboom\faraboom\Views\Blog\details.cshtml"
                                                                                                                                                                                                              

                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                   \r\n                </div>\r\n\r\n\r\n\r\n                <div class=\"mx-wh comment p-3\">\r\n                    <h6 class=\"IRANSans-Bold pl-2 ml-3 IRANSansWeb_Medium\">ارسال دیدگاه :</h6>\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "aa830919b8076dd09cbdcb1ef145be9b8254f92a8613", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                    <div class=""form-group"">
                        <input class=""form-control w-75"" type=""text"" placeholder=""نـام"">
                        <input class=""form-control w-75"" type=""email"" placeholder=""ایـمیل"">
                        <textarea class=""form-control area"" cols=""60"" rows=""9"" placeholder=""دیدگاه""
                            style=""height: 150px!important""></textarea>
                    </div>
                    <button type=""submit"" class=""btn btn-warning"">ارسـال &nbsp;<i
                            class=""fa fa-paper-plane""></i></button>
                </div>

                <!-- نمایش نظرات -->
                <!--<div class=""mt-4 p-3  mx-wh"">
                        <h5 class=""IRANSansWeb_Medium bg-light py-2 px-3  mb-4 rad25"">نظرات کاربران</h5>

                        <ul>
                            <li>
                                <div class=""d-flex flex-row flex-wrap justify-content-between dash rad25 m-md-3 m-1 p-3"">
                             ");
            WriteLiteral(@"       <div>
                                        <span class=""IRANSansWeb_Medium pl-4"">علی حمیدی</span>
                                        <span>
                                            <i class=""fas fa-star text-warning""></i>
                                            <i class=""fas fa-star text-warning""></i>
                                            <i class=""fas fa-star text-warning""></i>
                                            <i class=""fas fa-star text-warning""></i>
                                        </span>
                                        <p class=""mb-0"">پاسخ گویی شون عالی و خوب بود</p>
                                    </div>

                                    <div class=""float-left"">
                                        <span>22 : 16</span> -
                                        <span>1398/4/25</span>
                                    </div>

                                </div>
                            </li>
                          ");
            WriteLiteral(@"  <li>
                                <div class=""d-flex flex-row flex-wrap justify-content-between dash rad25 m-md-3 m-1 p-3"">
                                    <div>
                                        <span class=""IRANSansWeb_Medium pl-4"">مهسا حمیدی</span>
                                        <span>

                                            <i class=""fas fa-star text-warning""></i>
                                            <i class=""fas fa-star text-warning""></i>
                                        </span>
                                        <p class=""mb-0"">خوبه راضی ام</p>
                                    </div>

                                    <div class=""float-left"">
                                        <span>22 : 16</span> -
                                        <span>1398/4/25</span>
                                    </div>

                                </div>
                            </li>
                            <li>
                 ");
            WriteLiteral(@"               <div class=""d-flex flex-row flex-wrap justify-content-between dash rad25 m-md-3 m-1 p-3"">
                                    <div>
                                        <span class=""IRANSansWeb_Medium pl-4"">علی رضایی</span>
                                        <span>
                                            <i class=""fas fa-star text-warning""></i>
                                            <i class=""fas fa-star text-warning""></i>
                                            <i class=""fas fa-star text-warning""></i>

                                        </span>
                                        <p class=""mb-0"">تخصص شون عالی بود ممنون</p>
                                    </div>

                                    <div class=""float-left"">
                                        <span>22 : 16</span> -
                                        <span>1398/4/25</span>
                                    </div>

                                </div>
               ");
            WriteLiteral("             </li>\r\n                        </ul>\r\n\r\n\r\n                                         </div>-->\r\n\r\n            </div>\r\n        </div>\r\n    </div>\r\n</section>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<DataLayer.AdminEntities.Blog.Tb_Blog> Html { get; private set; }
    }
}
#pragma warning restore 1591