#pragma checksum "C:\Users\Korisnik\Desktop\Hidromil\Hidromil\Hidromil\Hidromil\Views\Admin\AdminKontakt.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0f37ee2bab9f6bef17013b44bf688c9bd2b17818"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_AdminKontakt), @"mvc.1.0.view", @"/Views/Admin/AdminKontakt.cshtml")]
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
#line 1 "C:\Users\Korisnik\Desktop\Hidromil\Hidromil\Hidromil\Hidromil\Views\_ViewImports.cshtml"
using Hidromil;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Korisnik\Desktop\Hidromil\Hidromil\Hidromil\Hidromil\Views\_ViewImports.cshtml"
using Hidromil.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0f37ee2bab9f6bef17013b44bf688c9bd2b17818", @"/Views/Admin/AdminKontakt.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ab2fb480d316bf50f70d3cb1e3d2a394f5da1547", @"/Views/_ViewImports.cshtml")]
    public class Views_Admin_AdminKontakt : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Hidromil.Models.Slika>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("submit"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", new global::Microsoft.AspNetCore.Html.HtmlString("Ukloni napomenu"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Admin", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "UkloniNapomenu", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", new global::Microsoft.AspNetCore.Html.HtmlString("Izmeni informacije"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "IzmeniInformacije", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", new global::Microsoft.AspNetCore.Html.HtmlString("Dodaj napomenu"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "DodajNapomenu", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormActionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\Korisnik\Desktop\Hidromil\Hidromil\Hidromil\Hidromil\Views\Admin\AdminKontakt.cshtml"
  
    Layout = "_LayoutGalerijaAdmin";
    ViewData["Title"] = "Kontakt";

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Korisnik\Desktop\Hidromil\Hidromil\Hidromil\Hidromil\Views\Admin\AdminKontakt.cshtml"
   
    Kontakt kontakt = ViewBag.Kontakt;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0f37ee2bab9f6bef17013b44bf688c9bd2b178186801", async() => {
                WriteLiteral(@"
    <div class=""body-inner"">
        <div class=""banner-carousel banner-carousel-2 mb-0"">
            <div class=""banner-area"" style=""        background-image: url(../images/Images/Heavy.jpg)"">
                <div class=""banner-text"">
                    <div class=""container"">
                    
                        <div class=""row"">
                            <div class=""col-lg-12"">
                                <div class=""banner-heading"">
                                    <div class=""box-slider-text"">
                                        <h1 class=""banner-title"">Kontakt</h1>
                                    </div>
                                </div>
                            </div><!-- Col end -->
                        </div><!-- Row end -->
                    </div><!-- Container end -->
                </div><!-- Banner text end -->
            </div>
        </div>


        <section id=""facts"" class=""facts-area dark-bg"">
            <div class=""containe");
                WriteLiteral("r\">\r\n");
#nullable restore
#line 33 "C:\Users\Korisnik\Desktop\Hidromil\Hidromil\Hidromil\Hidromil\Views\Admin\AdminKontakt.cshtml"
                 if (kontakt.Napomena != null)
                {

#line default
#line hidden
#nullable disable
                WriteLiteral("                    <div class=\"container\">\r\n                        <div");
                BeginWriteAttribute("class", " class=\"", 1348, "\"", 1356, 0);
                EndWriteAttribute();
                WriteLiteral(">\r\n                            <div class=\"text-warning\">\r\n                                ");
#nullable restore
#line 38 "C:\Users\Korisnik\Desktop\Hidromil\Hidromil\Hidromil\Hidromil\Views\Admin\AdminKontakt.cshtml"
                           Write(kontakt.Napomena);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                            </div>\r\n                            <div>\r\n                                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "0f37ee2bab9f6bef17013b44bf688c9bd2b178189129", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormActionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.Action = (string)__tagHelperAttribute_3.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                            </div>\r\n                        </div>\r\n                    </div>\r\n");
#nullable restore
#line 45 "C:\Users\Korisnik\Desktop\Hidromil\Hidromil\Hidromil\Hidromil\Views\Admin\AdminKontakt.cshtml"
                }

#line default
#line hidden
#nullable disable
                WriteLiteral("                <div class=\"gap-30\"></div>\r\n                <div class=\"row\" style=\"margin-left:1.5%;\">\r\n                    <div>\r\n                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "0f37ee2bab9f6bef17013b44bf688c9bd2b1781811208", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormActionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.Action = (string)__tagHelperAttribute_5.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                    </div>\r\n                    <div style=\"margin-left:2%;\">\r\n                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "0f37ee2bab9f6bef17013b44bf688c9bd2b1781812898", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormActionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.Action = (string)__tagHelperAttribute_7.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
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
                <div class=""gap-30""></div>
            </div>
            <div class=""container"">
                
                <div class=""facts-wrapper"">
                    <div class=""row"">

                        <div class=""col-sm-3 col-md-5 ts-facts mt-5 mt-sm-0"">
                            <div class=""ts-facts-content"" style=""margin-top:30px;"">
                                <p><i class=""fas fa-envelope-square""> </i> ");
#nullable restore
#line 64 "C:\Users\Korisnik\Desktop\Hidromil\Hidromil\Hidromil\Hidromil\Views\Admin\AdminKontakt.cshtml"
                                                                      Write(kontakt.Email);

#line default
#line hidden
#nullable disable
                WriteLiteral(" </p>\r\n                                <p><i class=\"fas fa-mobile-alt\"> </i> ");
#nullable restore
#line 65 "C:\Users\Korisnik\Desktop\Hidromil\Hidromil\Hidromil\Hidromil\Views\Admin\AdminKontakt.cshtml"
                                                                 Write(kontakt.MobilniBr);

#line default
#line hidden
#nullable disable
                WriteLiteral(" </p>\r\n                                <p><i class=\"fas fa-phone-square-alt\"></i> ");
#nullable restore
#line 66 "C:\Users\Korisnik\Desktop\Hidromil\Hidromil\Hidromil\Hidromil\Views\Admin\AdminKontakt.cshtml"
                                                                      Write(kontakt.FiksniBr);

#line default
#line hidden
#nullable disable
                WriteLiteral(@" </p>
                                <p><i class=""fas fa-map-marker-alt""></i> Srpskih Vladara 54 Stubica, Paraćin</p>
                                <p><i class=""fas fa-business-time""></i> Pon-Pet 08:00 - 17:00h</p>
                                <p> Sub 08:00 - 14:00h</p>
                            </div>
                        </div><!-- Col end -->
");
                WriteLiteral(@"                    <div class=""col-md-7 col-sm-9 ts-facts mt-5 mt-md-0"">
                        <div class=""ts-facts-content"">
                            <iframe src=""https://www.google.com/maps/embed?pb=!1m23!1m12!1m3!1d2158.430376284576!2d21.493706214675882!3d43.940340441834834!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!4m8!3e6!4m0!4m5!1s0x4756bbc4cbeeb6dd%3A0xc6811ccbf734bd0e!2sSrpskih%20vladara%2C%20Stubica!3m2!1d43.940336599999995!2d21.4958949!5e1!3m2!1ssr!2srs!4v1639260788760!5m2!1ssr!2srs"" width=""330"" height=""300"" style=""border:0;""");
                BeginWriteAttribute("allowfullscreen", " allowfullscreen=\"", 4021, "\"", 4039, 0);
                EndWriteAttribute();
                WriteLiteral(@" loading=""lazy""></iframe>
                        </div>
                    </div>
                        </div><!-- Col end -->
                   
                    </div> <!-- Facts end -->

                </div>
                <!--/ Content row end -->
            </div>
            <!--/ Container end -->
        </section><!-- Facts end -->

    </div>
");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_8.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_8);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Hidromil.Models.Slika> Html { get; private set; }
    }
}
#pragma warning restore 1591
