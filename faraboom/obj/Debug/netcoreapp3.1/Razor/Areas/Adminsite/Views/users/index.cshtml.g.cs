#pragma checksum "c:\Users\Neati\Desktop\nikatak\Faraboom\faraboom\Areas\Adminsite\Views\users\index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3eaf6e8cd403215e0dc141273762ce030775e3c0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Adminsite_Views_users_index), @"mvc.1.0.view", @"/Areas/Adminsite/Views/users/index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3eaf6e8cd403215e0dc141273762ce030775e3c0", @"/Areas/Adminsite/Views/users/index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8d5478c08d3cbdf2640418b2815a52ce99bbedf9", @"/Areas/Adminsite/Views/_ViewImports.cshtml")]
    public class Areas_Adminsite_Views_users_index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("    <!-- BEGIN: Content-->\r\n<section id=\"data-list-view\" class=\"data-list-view-header\">\r\n");
#nullable restore
#line 3 "c:\Users\Neati\Desktop\nikatak\Faraboom\faraboom\Areas\Adminsite\Views\users\index.cshtml"
   if (ViewBag.er != null)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <p class=\"alert alert-success\">");
#nullable restore
#line 5 "c:\Users\Neati\Desktop\nikatak\Faraboom\faraboom\Areas\Adminsite\Views\users\index.cshtml"
                              Write(ViewBag.er);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n");
#nullable restore
#line 6 "c:\Users\Neati\Desktop\nikatak\Faraboom\faraboom\Areas\Adminsite\Views\users\index.cshtml"
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
          <th>نام و نام خانوادگی</th>
          <th> نام  کاربر </th>
          <th> شماره تماس  </th>
           <th>  رمز </th>
             <th>  آدرس </th>
          <th>کارت ملی</th>
          <th>عملیات </th>
        </tr>
      </thead>
      <tbody>
");
#nullable restore
#line 24 "c:\Users\Neati\Desktop\nikatak\Faraboom\faraboom\Areas\Adminsite\Views\users\index.cshtml"
 if (ViewBag.list != null)
{
  int i=1;
    foreach (var item in ViewBag.list)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("          <tr>\r\n          <td></td>\r\n          <td class=\"product-category\"> ");
#nullable restore
#line 31 "c:\Users\Neati\Desktop\nikatak\Faraboom\faraboom\Areas\Adminsite\Views\users\index.cshtml"
                                   Write(i);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n           <td class=\"product-category\"> ");
#nullable restore
#line 32 "c:\Users\Neati\Desktop\nikatak\Faraboom\faraboom\Areas\Adminsite\Views\users\index.cshtml"
                                    Write(item.NameFamily);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td> \r\n          <td class=\"product-name\">");
#nullable restore
#line 33 "c:\Users\Neati\Desktop\nikatak\Faraboom\faraboom\Areas\Adminsite\Views\users\index.cshtml"
                              Write(item.UserNameUs);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td class=\"product-category\">");
#nullable restore
#line 34 "c:\Users\Neati\Desktop\nikatak\Faraboom\faraboom\Areas\Adminsite\Views\users\index.cshtml"
                                    Write(item.PhoneUs);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\r\n            <td class=\"product-category\">");
#nullable restore
#line 35 "c:\Users\Neati\Desktop\nikatak\Faraboom\faraboom\Areas\Adminsite\Views\users\index.cshtml"
                                    Write(item.PasswordUs);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\r\n            <td class=\"product-category\">");
#nullable restore
#line 36 "c:\Users\Neati\Desktop\nikatak\Faraboom\faraboom\Areas\Adminsite\Views\users\index.cshtml"
                                    Write(item.AddressUs);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\r\n            \r\n             <td class=\"product-category\">\r\n               <a");
            BeginWriteAttribute("href", " href=\"", 1190, "\"", 1229, 2);
            WriteAttributeValue("", 1197, "/fileupload/", 1197, 12, true);
#nullable restore
#line 39 "c:\Users\Neati\Desktop\nikatak\Faraboom\faraboom\Areas\Adminsite\Views\users\index.cshtml"
WriteAttributeValue("", 1209, item.ProfileImageUs, 1209, 20, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" target=""blank"">مشاهده</a>
               
                </td>
           <td class=""product-action"">
             <div class=""col-lg-3 col-md-3 mb-1"">
                <div class=""btn-group"" role=""group"" aria-label=""Basic example"">
                  
                    <a");
            BeginWriteAttribute("href", " href=\"", 1512, "\"", 1548, 2);
            WriteAttributeValue("", 1519, "/adminsite/users/del/", 1519, 21, true);
#nullable restore
#line 46 "c:\Users\Neati\Desktop\nikatak\Faraboom\faraboom\Areas\Adminsite\Views\users\index.cshtml"
WriteAttributeValue("", 1540, item.Id, 1540, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-danger btn-sm\" onclick=\"return confirm(\'آیا از حذف رکورد مورد نظر مطمئن هستید؟\')\">حذف</a>\r\n");
            WriteLiteral("                </div>\r\n              </div>\r\n          </td>\r\n        </tr>\r\n");
#nullable restore
#line 53 "c:\Users\Neati\Desktop\nikatak\Faraboom\faraboom\Areas\Adminsite\Views\users\index.cshtml"
        i++;

    }
}

#line default
#line hidden
#nullable disable
            WriteLiteral("      \r\n\r\n       \r\n\r\n\r\n\r\n\r\n      </tbody>\r\n    </table>\r\n  </div>\r\n  <!-- DataTable ends -->\r\n\r\n  <!-- add new sidebar starts -->\r\n \r\n  <!-- add new sidebar ends -->\r\n</section>\r\n<!-- Data list view end -->\r\n");
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
