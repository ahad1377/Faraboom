#pragma checksum "c:\Users\Neati\Desktop\nikatak\Faraboom\faraboom\Views\Expert\index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2844fef2677d8602919feb3ad35be0708405f249"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Expert_index), @"mvc.1.0.view", @"/Views/Expert/index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2844fef2677d8602919feb3ad35be0708405f249", @"/Views/Expert/index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"579044271ce4d686d4ad757e422253e06801c350", @"/Views/_ViewImports.cshtml")]
    public class Views_Expert_index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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









    <section class=""container-fluid mt-3"">
        <div class=""container p-md-5 box p-4"">
            <h5 class=""mb-4 bt-color IRANSansWeb_Medium""> مدیران و نمایندگان </h5>
            
            
<p style=""text-align: center;"" style=""display:none"">در حال بروزرسانی ...</p>
            <div class=""row"" >
");
#nullable restore
#line 18 "c:\Users\Neati\Desktop\nikatak\Faraboom\faraboom\Views\Expert\index.cshtml"
           if (ViewBag.expert != null)
    {
        foreach (var item in ViewBag.expert)
        {
            

        
                

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"col-lg-3 col-sm-6\">\r\n\r\n\r\n                    <div class=\"card\">\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "2844fef2677d8602919feb3ad35be0708405f2494223", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 609, "~/fileupload/", 609, 13, true);
#nullable restore
#line 30 "c:\Users\Neati\Desktop\nikatak\Faraboom\faraboom\Views\Expert\index.cshtml"
AddHtmlAttributeValue("", 622, item.ImageEx, 622, 13, false);

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
            WriteLiteral("\r\n                        <div class=\"data\">\r\n                            <h6 class=\"IRANSansWeb_Medium\"> ");
#nullable restore
#line 32 "c:\Users\Neati\Desktop\nikatak\Faraboom\faraboom\Views\Expert\index.cshtml"
                                                       Write(item.NameEx);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h6>\r\n                            <span>نیکاتک</span>\r\n                            <hr>\r\n");
            WriteLiteral("                            <a");
            BeginWriteAttribute("href", " href=\"", 971, "\"", 1002, 2);
            WriteAttributeValue("", 978, "/expert/details/", 978, 16, true);
#nullable restore
#line 36 "c:\Users\Neati\Desktop\nikatak\Faraboom\faraboom\Views\Expert\index.cshtml"
WriteAttributeValue("", 994, item.Id, 994, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><i class=\"fab fa-2x fa-whatsapp rounded text-success\"></i></a>\r\n                            <a");
            BeginWriteAttribute("href", " href=\"", 1098, "\"", 1129, 2);
            WriteAttributeValue("", 1105, "/expert/details/", 1105, 16, true);
#nullable restore
#line 37 "c:\Users\Neati\Desktop\nikatak\Faraboom\faraboom\Views\Expert\index.cshtml"
WriteAttributeValue("", 1121, item.Id, 1121, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><i class=\"fab fa-2x fa-telegram rounded text-info\"></i></a>\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n");
#nullable restore
#line 41 "c:\Users\Neati\Desktop\nikatak\Faraboom\faraboom\Views\Expert\index.cshtml"
              
        }
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("               \r\n              \r\n             \r\n\r\n\r\n\r\n            </div>\r\n       \r\n         </div>\r\n    </section>\r\n\r\n\r\n");
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