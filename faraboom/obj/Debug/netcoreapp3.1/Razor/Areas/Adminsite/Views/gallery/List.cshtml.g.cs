<<<<<<< HEAD
#pragma checksum "c:\Users\Neati\Desktop\nikatak\Faraboom\faraboom\Areas\Adminsite\Views\gallery\List.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "126a12de5c884426a74ab2987200bbb6e98e28c0"
=======
#pragma checksum "f:\Farabom\Faraboom\faraboom\Areas\Adminsite\Views\gallery\List.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "126a12de5c884426a74ab2987200bbb6e98e28c0"
>>>>>>> 4216de4f177eb32eced7335a9d6cd39fbeabac66
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Adminsite_Views_gallery_List), @"mvc.1.0.view", @"/Areas/Adminsite/Views/gallery/List.cshtml")]
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
<<<<<<< HEAD
#line 1 "c:\Users\Neati\Desktop\nikatak\Faraboom\faraboom\Areas\Adminsite\Views\_ViewImports.cshtml"
=======
#line 1 "f:\Farabom\Faraboom\faraboom\Areas\Adminsite\Views\_ViewImports.cshtml"
>>>>>>> 4216de4f177eb32eced7335a9d6cd39fbeabac66
using faraboom;

#line default
#line hidden
#nullable disable
#nullable restore
<<<<<<< HEAD
#line 2 "c:\Users\Neati\Desktop\nikatak\Faraboom\faraboom\Areas\Adminsite\Views\_ViewImports.cshtml"
=======
#line 2 "f:\Farabom\Faraboom\faraboom\Areas\Adminsite\Views\_ViewImports.cshtml"
>>>>>>> 4216de4f177eb32eced7335a9d6cd39fbeabac66
using faraboom.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"126a12de5c884426a74ab2987200bbb6e98e28c0", @"/Areas/Adminsite/Views/gallery/List.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8d5478c08d3cbdf2640418b2815a52ce99bbedf9", @"/Areas/Adminsite/Views/_ViewImports.cshtml")]
    public class Areas_Adminsite_Views_gallery_List : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("width: 60px;border-radius: 40px;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n\r\n    <!-- BEGIN: Content-->\r\n<section id=\"data-list-view\" class=\"data-list-view-header\">\r\n");
#nullable restore
<<<<<<< HEAD
#line 5 "c:\Users\Neati\Desktop\nikatak\Faraboom\faraboom\Areas\Adminsite\Views\gallery\List.cshtml"
=======
#line 5 "f:\Farabom\Faraboom\faraboom\Areas\Adminsite\Views\gallery\List.cshtml"
>>>>>>> 4216de4f177eb32eced7335a9d6cd39fbeabac66
    if (ViewBag.er != null)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("<p class=\"alert alert-success\">");
#nullable restore
<<<<<<< HEAD
#line 7 "c:\Users\Neati\Desktop\nikatak\Faraboom\faraboom\Areas\Adminsite\Views\gallery\List.cshtml"
=======
#line 7 "f:\Farabom\Faraboom\faraboom\Areas\Adminsite\Views\gallery\List.cshtml"
>>>>>>> 4216de4f177eb32eced7335a9d6cd39fbeabac66
                          Write(ViewBag.er);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n");
#nullable restore
<<<<<<< HEAD
#line 8 "c:\Users\Neati\Desktop\nikatak\Faraboom\faraboom\Areas\Adminsite\Views\gallery\List.cshtml"
=======
#line 8 "f:\Farabom\Faraboom\faraboom\Areas\Adminsite\Views\gallery\List.cshtml"
>>>>>>> 4216de4f177eb32eced7335a9d6cd39fbeabac66
}

#line default
#line hidden
#nullable disable
            WriteLiteral(@"  <!-- DataTable starts -->
  <div class=""table-responsive"">
    <table class=""table data-list-view"">
      <thead>
        <tr>
          <th></th>
          <th>ردیف</th>
          <th> عنوان  </th>
         
          <th> تصویر اصلی </th>
           <th>  زبان</th>
          <th> عملیات</th>
        </tr>
      </thead>
      <tbody>
");
#nullable restore
<<<<<<< HEAD
#line 24 "c:\Users\Neati\Desktop\nikatak\Faraboom\faraboom\Areas\Adminsite\Views\gallery\List.cshtml"
=======
#line 24 "f:\Farabom\Faraboom\faraboom\Areas\Adminsite\Views\gallery\List.cshtml"
>>>>>>> 4216de4f177eb32eced7335a9d6cd39fbeabac66
 if (ViewBag.list != null)
{
  int i=1;
     foreach (var item in ViewBag.list)
     {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n          <td></td>\r\n          <td class=\"product-category\"> ");
#nullable restore
<<<<<<< HEAD
#line 31 "c:\Users\Neati\Desktop\nikatak\Faraboom\faraboom\Areas\Adminsite\Views\gallery\List.cshtml"
=======
#line 31 "f:\Farabom\Faraboom\faraboom\Areas\Adminsite\Views\gallery\List.cshtml"
>>>>>>> 4216de4f177eb32eced7335a9d6cd39fbeabac66
                                   Write(i);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n          <td class=\"product-name\">");
#nullable restore
<<<<<<< HEAD
#line 32 "c:\Users\Neati\Desktop\nikatak\Faraboom\faraboom\Areas\Adminsite\Views\gallery\List.cshtml"
=======
#line 32 "f:\Farabom\Faraboom\faraboom\Areas\Adminsite\Views\gallery\List.cshtml"
>>>>>>> 4216de4f177eb32eced7335a9d6cd39fbeabac66
                              Write(item.TitleGal);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n           \r\n           <td class=\"product-category\">  ");
<<<<<<< HEAD
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "126a12de5c884426a74ab2987200bbb6e98e28c06100", async() => {
=======
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "126a12de5c884426a74ab2987200bbb6e98e28c05920", async() => {
>>>>>>> 4216de4f177eb32eced7335a9d6cd39fbeabac66
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 869, "~/fileupload/", 869, 13, true);
#nullable restore
<<<<<<< HEAD
#line 34 "c:\Users\Neati\Desktop\nikatak\Faraboom\faraboom\Areas\Adminsite\Views\gallery\List.cshtml"
=======
#line 34 "f:\Farabom\Faraboom\faraboom\Areas\Adminsite\Views\gallery\List.cshtml"
>>>>>>> 4216de4f177eb32eced7335a9d6cd39fbeabac66
AddHtmlAttributeValue("", 882, item.pathImage, 882, 15, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("  </td>\r\n                        <td class=\"product-category\">");
#nullable restore
<<<<<<< HEAD
#line 35 "c:\Users\Neati\Desktop\nikatak\Faraboom\faraboom\Areas\Adminsite\Views\gallery\List.cshtml"
=======
#line 35 "f:\Farabom\Faraboom\faraboom\Areas\Adminsite\Views\gallery\List.cshtml"
>>>>>>> 4216de4f177eb32eced7335a9d6cd39fbeabac66
                                                Write(item.Language);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\r\n           <td class=\"product-action\">\r\n             <div class=\"col-lg-3 col-md-3 mb-1\">\r\n                <div class=\"btn-group\" role=\"group\" aria-label=\"Basic example\">\r\n              \r\n                  <a");
            BeginWriteAttribute("href", " href=\"", 1198, "\"", 1236, 2);
            WriteAttributeValue("", 1205, "/adminsite/gallery/del/", 1205, 23, true);
#nullable restore
<<<<<<< HEAD
#line 40 "c:\Users\Neati\Desktop\nikatak\Faraboom\faraboom\Areas\Adminsite\Views\gallery\List.cshtml"
=======
#line 40 "f:\Farabom\Faraboom\faraboom\Areas\Adminsite\Views\gallery\List.cshtml"
>>>>>>> 4216de4f177eb32eced7335a9d6cd39fbeabac66
WriteAttributeValue("", 1228, item.Id, 1228, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" type=\"button\" class=\"btn btn-danger btn-sm\" onclick=\"return confirm(\'آیا از حذف رکورد مورد نظر مطمن هستید؟\')\">حذف</a>\r\n                \r\n                </div>\r\n              </div>\r\n          </td>\r\n        </tr>\r\n");
#nullable restore
<<<<<<< HEAD
#line 46 "c:\Users\Neati\Desktop\nikatak\Faraboom\faraboom\Areas\Adminsite\Views\gallery\List.cshtml"
=======
#line 46 "f:\Farabom\Faraboom\faraboom\Areas\Adminsite\Views\gallery\List.cshtml"
>>>>>>> 4216de4f177eb32eced7335a9d6cd39fbeabac66


         i++;
     }
}

#line default
#line hidden
#nullable disable
            WriteLiteral("  \r\n\r\n\r\n\r\n\r\n      </tbody>\r\n    </table>\r\n  </div>\r\n  <!-- DataTable ends -->\r\n\r\n  <!-- add new sidebar starts -->\r\n \r\n  <!-- add new sidebar ends -->\r\n</section>\r\n<!-- Data list view end -->\r\n");
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
