#pragma checksum "c:\Users\Neati\Desktop\nikatak\Faraboom\faraboom\Areas\Adminsite\Views\teaser\List.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4f83fac847d6dd56417233853f9bd4fedce27d28"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Adminsite_Views_teaser_List), @"mvc.1.0.view", @"/Areas/Adminsite/Views/teaser/List.cshtml")]
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
#line 1 "c:\Users\Neati\Desktop\nikatak\Faraboom\faraboom\Areas\Adminsite\Views\_ViewImports.cshtml"
using faraboom;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "c:\Users\Neati\Desktop\nikatak\Faraboom\faraboom\Areas\Adminsite\Views\_ViewImports.cshtml"
using faraboom.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4f83fac847d6dd56417233853f9bd4fedce27d28", @"/Areas/Adminsite/Views/teaser/List.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8d5478c08d3cbdf2640418b2815a52ce99bbedf9", @"/Areas/Adminsite/Views/_ViewImports.cshtml")]
    public class Areas_Adminsite_Views_teaser_List : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "c:\Users\Neati\Desktop\nikatak\Faraboom\faraboom\Areas\Adminsite\Views\teaser\List.cshtml"
    if (ViewBag.er != null)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("<p class=\"alert alert-success\">");
#nullable restore
#line 4 "c:\Users\Neati\Desktop\nikatak\Faraboom\faraboom\Areas\Adminsite\Views\teaser\List.cshtml"
                          Write(ViewBag.er);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n");
#nullable restore
#line 5 "c:\Users\Neati\Desktop\nikatak\Faraboom\faraboom\Areas\Adminsite\Views\teaser\List.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    <!-- BEGIN: Content-->
<section id=""data-list-view"" class=""data-list-view-header"">
  <!-- DataTable starts -->
  <div class=""table-responsive"">
    <table class=""table data-list-view"">
      <thead>


        <tr>
          <th></th>
          <th>ردیف</th>
          <th> عنوان  </th>
        
           <th>  زبان</th>
          <th> عملیات</th>
        </tr>
       
      </thead>
      <tbody>

");
#nullable restore
#line 26 "c:\Users\Neati\Desktop\nikatak\Faraboom\faraboom\Areas\Adminsite\Views\teaser\List.cshtml"
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
#line 33 "c:\Users\Neati\Desktop\nikatak\Faraboom\faraboom\Areas\Adminsite\Views\teaser\List.cshtml"
                                   Write(i);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n          <td class=\"product-name\">");
#nullable restore
#line 34 "c:\Users\Neati\Desktop\nikatak\Faraboom\faraboom\Areas\Adminsite\Views\teaser\List.cshtml"
                              Write(item.TitleTeaser);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</td>
            
              <td class=""product-category"">فارسی </td>
           <td class=""product-action"">
             <div class=""col-lg-3 col-md-3 mb-1"">
                <div class=""btn-group"" role=""group"" aria-label=""Basic example"">
                        <a");
            BeginWriteAttribute("href", " href=\"", 1021, "\"", 1058, 2);
            WriteAttributeValue("", 1028, "/adminsite/teaser/del/", 1028, 22, true);
#nullable restore
#line 40 "c:\Users\Neati\Desktop\nikatak\Faraboom\faraboom\Areas\Adminsite\Views\teaser\List.cshtml"
WriteAttributeValue("", 1050, item.Id, 1050, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" type=\"button\" class=\"btn btn-danger btn-sm\" onclick=\"return confirm(\'آیا از حذف رکورد مورد نظر مطمن هستید؟\')\">حذف</a>\r\n                </div>\r\n              </div>\r\n          </td>\r\n        </tr>\r\n");
#nullable restore
#line 45 "c:\Users\Neati\Desktop\nikatak\Faraboom\faraboom\Areas\Adminsite\Views\teaser\List.cshtml"

  i++;
     }
}

#line default
#line hidden
#nullable disable
            WriteLiteral("    \r\n\r\n\r\n\r\n      </tbody>\r\n    </table>\r\n  </div>\r\n  <!-- DataTable ends -->\r\n\r\n  <!-- add new sidebar starts -->\r\n \r\n  <!-- add new sidebar ends -->\r\n</section>\r\n<!-- Data list view end -->\r\n");
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