#pragma checksum "c:\Users\123\Desktop\Nikatak\faraboom\Views\Home\ContactUs.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a9150112c2098e51c3c736cd10a5d9aee3dc685f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_ContactUs), @"mvc.1.0.view", @"/Views/Home/ContactUs.cshtml")]
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
#line 1 "c:\Users\123\Desktop\Nikatak\faraboom\Views\_ViewImports.cshtml"
using faraboom;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "c:\Users\123\Desktop\Nikatak\faraboom\Views\_ViewImports.cshtml"
using faraboom.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a9150112c2098e51c3c736cd10a5d9aee3dc685f", @"/Views/Home/ContactUs.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"790e3bbc59f2e8cee0785b39a448bcba963a7b96", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_ContactUs : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"
    <section class=""container-fluid mt-3 pb-4 pb-lg-0"">
     
            <div class=""container mb-5 p-5 box"">
                <h5 class=""mb-4 bt-color"">ارتباط با ما</h5>
                <div class=""row"">
                    <div class=""col-md-7 pr-md-4"">

                        <p>

                            لورم ایپسوم متن ساختگی با تولید سادگی نامفهوم از صنعت چاپ و گرافیک است لورم ایپسوم متن ساختگی با تولید سادگی نامفهوم از صنعت چاپ و گرافیک است لورم ایپسوم متن ساختگی با تولید سادگی نامفهوم از صنعت چاپ و گرافیک است.
                        </p>

                        <p><span class=""IRANSansWeb_Medium  text-lightgreen""><i class=""fas fa-2x fa-map-marker-alt ml-2""></i>آدرس :</span> تهران  - بلوار میرداماد میدان مادر خیابان وزیری پور پلاک2 واحد 7  </p>
                        <p><span class=""IRANSansWeb_Medium  text-lightgreen""><i class=""fas fa-2x fa-phone pl-2""></i>تلفن : </span>02191316789</p>
                        <div>
                            <iframe src=""https://www.google.com/maps/embed?pb=!");
            WriteLiteral(@"1m18!1m12!1m3!1d3175.7976205896916!2d55.17228501478392!3d37.2525088798578!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x3f82bf1ba6cc2105%3A0x6f7802585af2473f!2zVGFsZWdoYW5pIEhvc3BpdGFsINio24zZhdin2LHYs9iq2KfZhiDYt9in2YTZgtin2YbbjCDar9mG2KjYrw!5e0!3m2!1sen!2s!4v1571678211268!5m2!1sen!2s"" class=""my-4 rad12 map""");
            BeginWriteAttribute("allowfullscreen", " allowfullscreen=\"", 1340, "\"", 1358, 0);
            EndWriteAttribute();
            WriteLiteral(@" frameborder=""0""></iframe>
                        </div>
                    </div>

                    <div class=""col-md-5 mb-4 p-4 brr"">
                        <p class=""mb-3"">جهت ارتباط با ما و ارسال نظـرات و پیشنهادات خود می توانید از فرم زیر استفاده نمایید</p>

                        <div class=""form-group"">
                            <!--<input class=""form-control w-75 mb-2"" type=""text"" placeholder=""نـام کامل"" />-->
                            <input class=""form-control w-75 mb-2"" type=""email"" placeholder=""ایمیل معتـبر"">
                            <input class=""form-control w-75 mb-2"" type=""tel"" placeholder=""شمـاره موبایل"">
                            <input class=""form-control w-75 mb-2"" type=""text"" placeholder=""موضوع پیام"">
                            <textarea class=""form-control area mb-2"" cols=""60"" rows=""9"" placeholder=""متن پیام"" style=""height: 150px!important""></textarea>
                        </div>

                        <button class=""btn btn btn-teal mb-3 text-white"" type=""submit"">ا");
            WriteLiteral(@"رسـال پیـام<i class=""fa fa-paper-plane fa-2x pr-2""></i></button>

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
         var map = new L.map('map', mapOptions);

         // Creating a Layer object
         var layer = new L.TileLayer('http://{s}.tile.openstreetmap.org/{z}/{x}/{y}.png');

         // Adding layer to the map
         map.addLayer(l");
            WriteLiteral(@"ayer);

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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
