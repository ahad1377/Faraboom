#pragma checksum "f:\Farabom\Faraboom\faraboom\Areas\Admin\Views\Home\form.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8b1858af82ff45288f1a85c2a242f59329de8c0e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Home_form), @"mvc.1.0.view", @"/Areas/Admin/Views/Home/form.cshtml")]
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
#line 1 "f:\Farabom\Faraboom\faraboom\Areas\Admin\Views\_ViewImports.cshtml"
using faraboom;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "f:\Farabom\Faraboom\faraboom\Areas\Admin\Views\_ViewImports.cshtml"
using faraboom.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8b1858af82ff45288f1a85c2a242f59329de8c0e", @"/Areas/Admin/Views/Home/form.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"579044271ce4d686d4ad757e422253e06801c350", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Home_form : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "male", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "woman", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "marid", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "single", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/admin/assets/img/circle.svg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("card-img-absolute"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("circle-image"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<div class=\"row\">\r\n\t<!-- BASIC WIZARD -->\r\n\t<div class=\"col-xl-12\">\r\n\t\t<div class=\"card m-b-20\">\r\n\t\t\t<div class=\"card-header\">\r\n\t\t\t\t<h2 class=\"mb-0\">تکمیل اطلاعات </h2>\r\n\t\t\t</div>\r\n\t\t\t<div class=\"card-body\">\r\n\t\t\t\t");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8b1858af82ff45288f1a85c2a242f59329de8c0e6025", async() => {
                WriteLiteral(@"
					<div id=""basicwizard"" class=""border pt-0"">
						<ul class=""nav nav-tabs nav-justified"">
							<li class=""nav-item""><a href=""#tab1"" data-toggle=""tab"" class=""nav-link "">اطلاعات هویتی </a>
							</li>
							<li class=""nav-item""><a href=""#tab2"" data-toggle=""tab"" class=""nav-link "">اطلاعات ارتباطی
								</a></li>
							<li class=""nav-item""><a href=""#tab3"" data-toggle=""tab"" class=""nav-link"">اطلاعات حساب</a>
							</li>
							<li class=""nav-item""><a href=""#tab4"" data-toggle=""tab"" class=""nav-link "">میزان تحصیلات</a>
							</li>
							<li class=""nav-item""><a href=""#tab5"" data-toggle=""tab"" class=""nav-link "">سوابق کاری
								</a></li>
							<li class=""nav-item""><a href=""#tab6"" data-toggle=""tab"" class=""nav-link"">الصاق مدارک</a></li>
							<li class=""nav-item""><a href=""#tab7"" data-toggle=""tab"" class=""nav-link"">پرداخت هزینه</a>
							</li>
						</ul>
						<div class=""tab-content card-body  b-0 mb-0"">
							<div class=""tab-pane fade"" id=""tab1"">
								<div class=""row"">
									<");
                WriteLiteral(@"div class=""col-12"">
										<div class=""form-group clearfix"">

											<div class=""row mt-1"">

												<div class=""col-lg-3"">
													<input class=""form-control required"" placeholder=""نام به فارسی""
														type=""text"">
												</div>
												<div class=""col-lg-3"">
													<input class=""form-control required""
														placeholder=""نام خانوادگی به فارسی"" type=""text"">
												</div>
												<div class=""col-lg-3"">
													<input class=""form-control required"" placeholder=""نام پدر به فارسی""
														type=""text"">
												</div>
												<div class=""col-lg-3"">
													<input class=""form-control required"" placeholder=""کد ملی""
														type=""text"">
												</div>

											</div>




											<div class=""row mt-1"">

												<div class=""col-lg-3"">
													<input class=""form-control required"" placeholder=""نام به لاتین""
														type=""text"">
												</div>
												<div class=""col-lg-3"">
");
                WriteLiteral(@"													<input class=""form-control required""
														placeholder=""نام خانوادگی به لاتین"" type=""text"">
												</div>
												<div class=""col-lg-3"">
													<input class=""form-control required"" placeholder=""نام پدر به لاتین""
														type=""text"">
												</div>
												<div class=""col-lg-3"">
													<input class=""form-control required"" placeholder=""کد ملی ""
														type=""text"">
												</div>

											</div>



											<div class=""row mt-1"">


												<div class=""col-lg-3"">
													<input class=""form-control required"" placeholder=""محل صدور""
														type=""text"">
												</div>
												<div class=""col-lg-3"">
													<input class=""form-control required"" placeholder=""سریال شناسنامه""
														type=""text"">
												</div>
												<div class=""col-lg-3"">
													<input class=""form-control required"" placeholder=""مذهب"" type=""text"">
												</div>
												<div class=""col-lg-3"">
			");
                WriteLiteral("\t\t\t\t\t\t\t\t\t\t<input class=\"form-control required\" placeholder=\"ایمیل\"\r\n\t\t\t\t\t\t\t\t\t\t\t\t\t\ttype=\"text\">\r\n\t\t\t\t\t\t\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t\t\t\t\t\t</div>\r\n\r\n\t\t\t\t\t\t\t\t\t\t\t<div class=\"row mt-2\">\r\n\r\n\t\t\t\t\t\t\t\t\t\t\t\t<div class=\"col-lg-4\">\r\n\t\t\t\t\t\t\t\t\t\t\t\t\t");
#nullable restore
#line 102 "f:\Farabom\Faraboom\faraboom\Areas\Admin\Views\Home\form.cshtml"
                                               Write(await Html.PartialAsync("_PrtialBirth"));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
												</div>
												<div class=""col-lg-3"">
													<div class=""form-group"">
														<label class=""form-label"">انتخاب جنسیت</label>
														<select name=""country"" id=""select-countries""
															class=""form-control custom-select"">
															");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8b1858af82ff45288f1a85c2a242f59329de8c0e10537", async() => {
                    WriteLiteral("مرد\r\n\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8b1858af82ff45288f1a85c2a242f59329de8c0e11822", async() => {
                    WriteLiteral("زن\r\n\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                BeginWriteTagHelperAttribute();
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __tagHelperExecutionContext.AddHtmlAttribute("d", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"

														</select>
													</div>
												</div>
												<div class=""col-lg-3"">
													<div class=""form-group"">
														<label class=""form-label"">وضعیت تاهل</label>
														<select name=""country"" id=""select-countries""
															class=""form-control custom-select"">
															");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8b1858af82ff45288f1a85c2a242f59329de8c0e13733", async() => {
                    WriteLiteral("متاهل\r\n\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8b1858af82ff45288f1a85c2a242f59329de8c0e15020", async() => {
                    WriteLiteral("مجرد\r\n\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_3.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
                BeginWriteTagHelperAttribute();
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __tagHelperExecutionContext.AddHtmlAttribute("d", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"

														</select>
													</div>
												</div>


											</div>

										</div>

									</div>
								</div>
							</div>
							<div class=""tab-pane fade"" id=""tab2"">
								<div class=""row"">
									<div class=""col-12"">
										<div class=""form-group clearfix"">

											<div class=""row mt-1"">

												<div class=""col-lg-3"">
													<input class=""form-control required"" placeholder=""	تلفن همراه ""
														type=""text"">
												</div>
												<div class=""col-lg-3"">
													<input class=""form-control required""
														placeholder=""	تلفن ثابت منزل با کد"" type=""text"">
												</div>
												<div class=""col-lg-3"">
													<input class=""form-control required""
														placeholder=""	تلفن ثابت محل نمایندگی با کد"" type=""text"">
												</div>
												<div class=""col-lg-3"">
													<input class=""form-control required""
														placeholder=""تلفن نمایندگی نیکا تک"" type=""text"">
										");
                WriteLiteral(@"		</div>

											</div>




											<div class=""row mt-1"">

												<div class=""col-lg-3"">
													<input class=""form-control required"" placeholder=""	استان ""
														type=""text"">
												</div>
												<div class=""col-lg-3"">
													<input class=""form-control required"" placeholder=""شهر"" type=""text"">
												</div>
												<div class=""col-lg-3"">
													<input class=""form-control required"" placeholder=""	کدپستی""
														type=""text"">
												</div>
												<div class=""col-lg-3"">
													<input class=""form-control required"" placeholder=""	ادرس منزل""
														type=""text"">
												</div>

											</div>



											<div class=""row mt-1"">


												<div class=""col-lg-3"">
													<input class=""form-control required"" placeholder=""کدپستی""
														type=""text"">
												</div>
												<div class=""col-lg-3"">
													<input class=""form-control required"" placeholder=""ادرس محل فعالیت");
                WriteLiteral(@"""
														type=""text"">
												</div>

											</div>


										</div>

									</div>
								</div>
							</div>
							<div class=""tab-pane fade"" id=""tab3"">
								<div class=""row"">
									<div class=""col-12"">
										<div class=""form-group clearfix"">

											<div class=""row mt-1"">

												<div class=""col-lg-3"">
													<input class=""form-control required"" placeholder=""		نام بانک ""
														type=""text"">
												</div>
												<div class=""col-lg-3"">
													<input class=""form-control required"" placeholder=""		کد بانک""
														type=""text"">
												</div>
												<div class=""col-lg-3"">
													<input class=""form-control required"" placeholder=""		نام شعبه""
														type=""text"">
												</div>
												<div class=""col-lg-3"">
													<input class=""form-control required""
														placeholder=""	نوع حساب(سپرده – جاری )"" type=""text"">
												</div>

											</div>




									");
                WriteLiteral(@"		<div class=""row mt-1"">

												<div class=""col-lg-3"">
													<input class=""form-control required""
														placeholder=""	شماره کارت عابر بانک  "" type=""text"">
												</div>
												<div class=""col-lg-3"">
													<input class=""form-control required"" placeholder=""	شماره شبا""
														type=""text"">
												</div>
												<div class=""col-lg-3"">
													<input class=""form-control required"" placeholder=""		شماره حساب""
														type=""text"">
												</div>
												<div class=""col-lg-3"">
													<input class=""form-control required"" placeholder=""		نام دارنده حساب""
														type=""text"">
												</div>

											</div>



											<div class=""row mt-1"">


												<div class=""col-lg-3"">
													<input class=""form-control required text-center ""
														placeholder=""کد پستی"" type=""text"">
												</div>
												<div class=""col-lg-3"">
													<input class=""form-control required"" placeholder=");
                WriteLiteral(@"""ادرس محل فعالیت""
														type=""text"">
												</div>

											</div>


										</div>

									</div>
								</div>
							</div>
							<div class=""tab-pane fade"" id=""tab4"">
								<div class=""row"">
									<div class=""col-12"">
										<div class=""form-group clearfix"">

											<div class=""row mt-1"">

												<div class=""col-lg-3"">
													<input class=""form-control required"" type=""text"" value=""دیپلم""
														disabled>
												</div>
												<div class=""col-lg-3"">
													<input class=""form-control required"" placeholder=""		تاریخ اخذ مدرک""
														type=""text"">
												</div>
												<div class=""col-lg-3"">
													<input class=""form-control required"" placeholder=""		محل اخذ مدرک
														type="" text"">
												</div>


											</div>

											<div class=""row mt-1"">

												<div class=""col-lg-3"">
													<input class=""form-control required"" type=""text"" value=""کاردانی""
											");
                WriteLiteral(@"			disabled>
												</div>
												<div class=""col-lg-3"">
													<input class=""form-control required"" placeholder=""		تاریخ اخذ مدرک""
														type=""text"">
												</div>
												<div class=""col-lg-3"">
													<input class=""form-control required"" placeholder=""		محل اخذ مدرک
														type="" text"">
												</div>


											</div>


											<div class=""row mt-1"">

												<div class=""col-lg-3"">
													<input class=""form-control required"" type=""text"" value=""کارشناسی""
														disabled>
												</div>
												<div class=""col-lg-3"">
													<input class=""form-control required"" placeholder=""		تاریخ اخذ مدرک""
														type=""text"">
												</div>
												<div class=""col-lg-3"">
													<input class=""form-control required"" placeholder=""		محل اخذ مدرک
														type="" text"">
												</div>


											</div>


											<div class=""row mt-1"">

												<div class=""col-lg-3"">
					");
                WriteLiteral(@"								<input class=""form-control required"" type=""text"" value=""ارشد""
														disabled>
												</div>
												<div class=""col-lg-3"">
													<input class=""form-control required"" placeholder=""		تاریخ اخذ مدرک""
														type=""text"">
												</div>
												<div class=""col-lg-3"">
													<input class=""form-control required"" placeholder=""		محل اخذ مدرک
														type="" text"">
												</div>


											</div>

											<div class=""row mt-1"">

												<div class=""col-lg-3"">
													<input class=""form-control required"" type=""text"" value=""دکترا""
														disabled>
												</div>
												<div class=""col-lg-3"">
													<input class=""form-control required"" placeholder=""		تاریخ اخذ مدرک""
														type=""text"">
												</div>
												<div class=""col-lg-3"">
													<input class=""form-control required"" placeholder=""		محل اخذ مدرک
														type="" text"">
												</div>


											</div>


");
                WriteLiteral(@"



										</div>

									</div>
								</div>
							</div>
							<div class=""tab-pane fade"" id=""tab5"">
								<div class=""row"">
									<div class=""col-12"">
										<div class=""form-group clearfix"">

											<div class=""row mt-1"">

												<div class=""col-lg-3"">
													<input class=""form-control required"" placeholder=""		نام شرکت  ""
														type=""text"">
												</div>
												<div class=""col-lg-3"">
													<input class=""form-control required"" placeholder=""			شروع همکاری""
														type=""text"">
												</div>
												<div class=""col-lg-3"">
													<input class=""form-control required"" placeholder=""			خاتمه همکاری""
														type=""text"">
												</div>
												<div class=""col-lg-3"">
													<input class=""form-control required"" placeholder=""		نوع فعالیت""
														type=""text"">
												</div>

											</div>

											<div class=""row mt-1"">

												<div class=""col-lg-3"">
												");
                WriteLiteral(@"	<input class=""form-control required"" placeholder=""		نام شرکت  ""
														type=""text"">
												</div>
												<div class=""col-lg-3"">
													<input class=""form-control required"" placeholder=""			شروع همکاری""
														type=""text"">
												</div>
												<div class=""col-lg-3"">
													<input class=""form-control required"" placeholder=""			خاتمه همکاری""
														type=""text"">
												</div>
												<div class=""col-lg-3"">
													<input class=""form-control required"" placeholder=""		نوع فعالیت""
														type=""text"">
												</div>

											</div>
											<div class=""row mt-1"">

												<div class=""col-lg-3"">
													<input class=""form-control required"" placeholder=""		نام شرکت  ""
														type=""text"">
												</div>
												<div class=""col-lg-3"">
													<input class=""form-control required"" placeholder=""			شروع همکاری""
														type=""text"">
												</div>
												<div class=""col-lg-3"">");
                WriteLiteral(@"
													<input class=""form-control required"" placeholder=""			خاتمه همکاری""
														type=""text"">
												</div>
												<div class=""col-lg-3"">
													<input class=""form-control required"" placeholder=""		نوع فعالیت""
														type=""text"">
												</div>

											</div>
											<div class=""row mt-1"">

												<div class=""col-lg-3"">
													<input class=""form-control required"" placeholder=""		نام شرکت  ""
														type=""text"">
												</div>
												<div class=""col-lg-3"">
													<input class=""form-control required"" placeholder=""			شروع همکاری""
														type=""text"">
												</div>
												<div class=""col-lg-3"">
													<input class=""form-control required"" placeholder=""			خاتمه همکاری""
														type=""text"">
												</div>
												<div class=""col-lg-3"">
													<input class=""form-control required"" placeholder=""		نوع فعالیت""
														type=""text"">
												</div>

											</div>
");
                WriteLiteral(@"											<div class=""row mt-1"">

												<div class=""col-lg-3"">
													<input class=""form-control required"" placeholder=""		نام شرکت  ""
														type=""text"">
												</div>
												<div class=""col-lg-3"">
													<input class=""form-control required"" placeholder=""			شروع همکاری""
														type=""text"">
												</div>
												<div class=""col-lg-3"">
													<input class=""form-control required"" placeholder=""			خاتمه همکاری""
														type=""text"">
												</div>
												<div class=""col-lg-3"">
													<input class=""form-control required"" placeholder=""		نوع فعالیت""
														type=""text"">
												</div>

											</div>
											<div class=""row mt-1"">

												<div class=""col-lg-3"">
													<input class=""form-control required"" placeholder=""		نام شرکت  ""
														type=""text"">
												</div>
												<div class=""col-lg-3"">
													<input class=""form-control required"" placeholder=""			شروع همکاری""");
                WriteLiteral(@"
														type=""text"">
												</div>
												<div class=""col-lg-3"">
													<input class=""form-control required"" placeholder=""			خاتمه همکاری""
														type=""text"">
												</div>
												<div class=""col-lg-3"">
													<input class=""form-control required"" placeholder=""		نوع فعالیت""
														type=""text"">
												</div>

											</div>






										</div>

									</div>
								</div>
							</div>
							<div class=""tab-pane fade"" id=""tab6"">
								");
#nullable restore
#line 527 "f:\Farabom\Faraboom\faraboom\Areas\Admin\Views\Home\form.cshtml"
                           Write(await Html.PartialAsync("_Partialupload"));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
							</div>


							<div class=""tab-pane fade"" id=""tab7"">
								<div class=""row"">
									<div class=""col-12"">
										<div class=""form-group clearfix"">

											<div class=""row mt-1"">

												<div class=""col-lg-6"">
													<div class=""card pull-up shadow bg-gradient-primary"">
														<a");
                BeginWriteAttribute("href", " href=\"", 16583, "\"", 16590, 0);
                EndWriteAttribute();
                WriteLiteral(">\r\n\r\n\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t<div class=\"card-content\">\r\n\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t<div class=\"card-body\">\r\n\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "8b1858af82ff45288f1a85c2a242f59329de8c0e30251", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
																	<div class=""media d-flex"">
																		<div class=""media-body text-right"">
																			<h4 class=""text-white"">مراکز استان</h4>
																			<h2 class=""text-white mb-0"">60,000,000 تومان
																			</h2>
																		</div>
																		<div class=""align-self-center"">
																			<i
																				class=""fe fe-shopping-cart text-white font-large-2 float-right""></i>
																		</div>
																	</div>
																</div>
															</div>
														</a>
													</div>
												</div>

												<div class=""col-lg-6"">
													<a");
                BeginWriteAttribute("href", " href=\"", 17457, "\"", 17464, 0);
                EndWriteAttribute();
                WriteLiteral(">\r\n\r\n\t\t\t\t\t\t\t\t\t\t\t\t\t<div class=\"card pull-up shadow bg-gradient-warning\">\r\n\t\t\t\t\t\t\t\t\t\t\t\t\t\t<div class=\"card-content\">\r\n\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t<div class=\"card-body\">\r\n\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "8b1858af82ff45288f1a85c2a242f59329de8c0e32578", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
																<div class=""media d-flex"">
																	<div class=""media-body text-right"">
																		<h4 class=""text-white"">سایر شهرستان ها</h4>
																		<h2 class=""text-white mb-0"">40,000,000 تومان
																		</h2>
																	</div>
																	<div class=""align-self-center"">
																		<i
																			class=""fe fe-bar-chart text-white font-large-2 float-right""></i>
																	</div>
																</div>
															</div>
														</div>
													</div>
													</a>

												</div>


											</div>








										</div>

									</div>
								</div>
							</div>





							<ul class=""list-inline wizard mb-0"">
								<li class=""previous list-inline-item""><a href=""#""
										class=""btn btn-primary mb-0 waves-effect waves-light"">قبلی</a>
								</li>
								<li class=""next list-inline-item float-left""><a href=""#""
										class=""btn btn-primary mb-0 waves-effect waves-l");
                WriteLiteral("ight\">بعدی</a>\r\n\t\t\t\t\t\t\t\t</li>\r\n\t\t\t\t\t\t\t</ul>\r\n\t\t\t\t\t\t</div>\r\n\t\t\t\t\t</div>\r\n\t\t\t\t");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\t\t\t</div>\r\n\t\t</div>\r\n\t</div>\r\n</div>\r\n<!-- end row -->");
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
