#pragma checksum "D:\project\nikatak\Faraboom\faraboom\Views\Agancy\index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b06f10dea53e836c5ee1d44b5d8d650649f7ae1e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Agancy_index), @"mvc.1.0.view", @"/Views/Agancy/index.cshtml")]
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
#line 1 "D:\project\nikatak\Faraboom\faraboom\Views\_ViewImports.cshtml"
using faraboom;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\project\nikatak\Faraboom\faraboom\Views\_ViewImports.cshtml"
using faraboom.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b06f10dea53e836c5ee1d44b5d8d650649f7ae1e", @"/Views/Agancy/index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"579044271ce4d686d4ad757e422253e06801c350", @"/Views/_ViewImports.cshtml")]
    public class Views_Agancy_index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
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
            <h5 class=""mb-4 bt-color IRANSansWeb_Medium"">   معرفی نمایندگان  </h5>
            
            
<p style=""text-align: center;display:none"" >در حال بروزرسانی ...</p>
            <div class=""row"" >
");
#nullable restore
#line 18 "D:\project\nikatak\Faraboom\faraboom\Views\Agancy\index.cshtml"
           if (ViewBag.aganc != null)
    {
        foreach (var item in ViewBag.aganc)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("          <div class=\"col-lg-3 col-sm-6\">\r\n                    <div class=\"card\">\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "b06f10dea53e836c5ee1d44b5d8d650649f7ae1e4105", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 545, "~/fileupload/", 545, 13, true);
#nullable restore
#line 24 "D:\project\nikatak\Faraboom\faraboom\Views\Agancy\index.cshtml"
AddHtmlAttributeValue("", 558, item.ImageAg, 558, 13, false);

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
#line 26 "D:\project\nikatak\Faraboom\faraboom\Views\Agancy\index.cshtml"
                                                       Write(item.NameAg);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h6>\r\n                            <span>");
#nullable restore
#line 27 "D:\project\nikatak\Faraboom\faraboom\Views\Agancy\index.cshtml"
                             Write(Model.NamePersenA);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                            <hr>\r\n");
            WriteLiteral("                            <a");
            BeginWriteAttribute("href", " href=\"", 919, "\"", 950, 2);
            WriteAttributeValue("", 926, "/agancy/details/", 926, 16, true);
#nullable restore
#line 30 "D:\project\nikatak\Faraboom\faraboom\Views\Agancy\index.cshtml"
WriteAttributeValue("", 942, item.Id, 942, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><i class=\"fab fa-2x fa-whatsapp rounded text-success\"></i>مشاهده اطلاعات کامل </a>\r\n                            <a");
            BeginWriteAttribute("href", " href=\"", 1066, "\"", 1097, 2);
            WriteAttributeValue("", 1073, "/agancy/details/", 1073, 16, true);
#nullable restore
#line 31 "D:\project\nikatak\Faraboom\faraboom\Views\Agancy\index.cshtml"
WriteAttributeValue("", 1089, item.Id, 1089, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><i class=\"fab fa-2x fa-telegram rounded text-info\"></i></a>\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n");
#nullable restore
#line 35 "D:\project\nikatak\Faraboom\faraboom\Views\Agancy\index.cshtml"
              
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
