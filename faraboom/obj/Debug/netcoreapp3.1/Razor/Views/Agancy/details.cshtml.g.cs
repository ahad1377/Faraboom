#pragma checksum "c:\Users\Neati\Desktop\nikatak\Faraboom\faraboom\Views\Agancy\details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "30714ffdbf621724e207d47eb463f3259756e9c0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Agancy_details), @"mvc.1.0.view", @"/Views/Agancy/details.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"30714ffdbf621724e207d47eb463f3259756e9c0", @"/Views/Agancy/details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"579044271ce4d686d4ad757e422253e06801c350", @"/Views/_ViewImports.cshtml")]
    public class Views_Agancy_details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<DataLayer.AdminEntities.Agency.Tb_Agency>
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
            WriteLiteral(@"   <link rel=""stylesheet"" href=""https://unpkg.com/leaflet@1.3.4/dist/leaflet.css"" />
<script src=""https://unpkg.com/leaflet@1.3.4/dist/leaflet.js""></script>
   
    <style>
        #map { height:300px; width:100%; }
       

    </style>
        </style>
");
            WriteLiteral(@"    <section class=""container-fluid mt-3 pb-4 pb-lg-0"">
     
            <div class=""container mb-5 p-5 box"">
                <h5 class=""mb-4 bt-color"">درباره</h5>
                <div class=""row"">
                     
                    <div class=""col-md-7 pr-md-4"">

                        

                        <p><span class=""IRANSansWeb_Medium  text-lightgreen""><i class=""fas fa-2x fa-map-marker-alt ml-2""></i>
                         نام نمایندگی : ");
#nullable restore
#line 22 "c:\Users\Neati\Desktop\nikatak\Faraboom\faraboom\Views\Agancy\details.cshtml"
                                   Write(Model.NameAg);

#line default
#line hidden
#nullable disable
            WriteLiteral(@" </p>
                        </p>
                                                          
                        <p><span class=""IRANSansWeb_Medium  text-lightgreen""><i class=""fas fa-2x fa-phone pl-2""></i> 
                         نام و نام خانوادگی : ");
#nullable restore
#line 26 "c:\Users\Neati\Desktop\nikatak\Faraboom\faraboom\Views\Agancy\details.cshtml"
                                         Write(Model.NamePersenAg);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                         </p>
                       
                                                        
                        <p><span class=""IRANSansWeb_Medium  text-lightgreen""><i class=""fas fa-2x fa-phone pl-2""></i> 
                        شماره تلفن ثابت:");
#nullable restore
#line 31 "c:\Users\Neati\Desktop\nikatak\Faraboom\faraboom\Views\Agancy\details.cshtml"
                                   Write(Model.OfficetelAg);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                         </p>\r\n\r\n                          <p><span class=\"IRANSansWeb_Medium  text-lightgreen\"><i class=\"fas fa-2x fa-phone pl-2\"></i> \r\n                        آدرس:");
#nullable restore
#line 35 "c:\Users\Neati\Desktop\nikatak\Faraboom\faraboom\Views\Agancy\details.cshtml"
                        Write(Model.Adress);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                         </p>\r\n\r\n\r\n                          \r\n\r\n                          <p><span class=\"IRANSansWeb_Medium  text-lightgreen\"><i class=\"fas fa-2x fa-phone pl-2\"></i> \r\n                        شماره تماس همراه:");
#nullable restore
#line 42 "c:\Users\Neati\Desktop\nikatak\Faraboom\faraboom\Views\Agancy\details.cshtml"
                                    Write(Model.TelAg);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                         </p>\r\n\r\n\r\n\r\n                       \r\n                           <input type=\"text\"");
            BeginWriteAttribute("value", " value=\"", 1929, "\"", 1954, 1);
#nullable restore
#line 48 "c:\Users\Neati\Desktop\nikatak\Faraboom\faraboom\Views\Agancy\details.cshtml"
WriteAttributeValue("", 1937, Model.LocationAg, 1937, 17, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" id=""location"" style=""display:none;"">


                        <div class=""col-sm-12 col-12"">
                               <div id=""map""></div>
                            </div>
                    </div>
                   
                             
                             

                    <div class=""col-md-5 mb-4 p-4 brr"">
                         <div class=""col-lg-6 col-sm-12"">
            <div class=""card"" >

                <div class=""card-content"">
                    <div class=""card-body"">
                        <ul class=""activity-timeline timeline-left list-unstyled"" style=""margin-right: 0px !important;"">
                            <li>
                                <div class=""timeline-icon bg-primary"">
                                    <i class=""feather icon-check font-medium-2""></i>
                                </div>
                                <div class=""timeline-info"">
                                    <p class=""font-weight-bold"" styl");
            WriteLiteral("e=\"text-align: right;\"> عکس \r\n                                      </p>\r\n                                    <br>\r\n\r\n                                    <div class=\"footer-btn alert alert-primary text-center \">\r\n\r\n                                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "30714ffdbf621724e207d47eb463f3259756e9c08322", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 3244, "~/fileupload/", 3244, 13, true);
#nullable restore
#line 77 "c:\Users\Neati\Desktop\nikatak\Faraboom\faraboom\Views\Agancy\details.cshtml"
AddHtmlAttributeValue("", 3257, Model.ImageAg, 3257, 14, false);

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
            WriteLiteral(@"
                                    </div>


                                </div>

                            </li>

                        </ul>
                    </div>
                </div>
            </div>
        </div>
                    </div>
                </div>

            </div>
   
        <!--<object class=""d-none d-xl-block"" type=""image/svg+xml"" data=""Images/Svg/desktop-wave.svg""></object>-->
    
     </section>

       <script>
                                  var locationToStringed=document.getElementById('location').value;
                                 
var input = locationToStringed.replace('(', '');
var latlngStr = input.split("","", 2);
var lat = parseFloat(latlngStr[0]);
var lng = parseFloat(latlngStr[1]);

                                 debugger
         // Creating map options
         var mapOptions = {
            center: [lat,lng],
            zoom: 12
         }
         // Creating a map object
         var map = new L.map('ma");
            WriteLiteral(@"p', mapOptions);

         // Creating a Layer object
         var layer = new L.TileLayer('http://{s}.tile.openstreetmap.org/{z}/{x}/{y}.png');

         // Adding layer to the map
         map.addLayer(layer);

         // Creating a Marker
         var markerOptions = {
            title: ""MyLocation"",
            clickable: true,
            draggable: false
         }
         // Creating a marker
         var marker = L.marker([lat,lng], markerOptions);

         // Adding marker to the map
         marker.addTo(map);


        



      </script>
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<DataLayer.AdminEntities.Agency.Tb_Agency> Html { get; private set; }
    }
}
#pragma warning restore 1591