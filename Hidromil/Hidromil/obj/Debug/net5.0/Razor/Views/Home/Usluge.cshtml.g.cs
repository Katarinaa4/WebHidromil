#pragma checksum "C:\Users\Korisnik\OneDrive\Desktop\Hidromil\Hidromil\Hidromil\Hidromil\Views\Home\Usluge.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0186f599877f0e2ab53a0b6672abef4a33903aa2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Usluge), @"mvc.1.0.view", @"/Views/Home/Usluge.cshtml")]
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
#line 1 "C:\Users\Korisnik\OneDrive\Desktop\Hidromil\Hidromil\Hidromil\Hidromil\Views\_ViewImports.cshtml"
using Hidromil;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Korisnik\OneDrive\Desktop\Hidromil\Hidromil\Hidromil\Hidromil\Views\_ViewImports.cshtml"
using Hidromil.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0186f599877f0e2ab53a0b6672abef4a33903aa2", @"/Views/Home/Usluge.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ab2fb480d316bf50f70d3cb1e3d2a394f5da1547", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Usluge : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Hidromil.Models.Usluga>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("enctype", new global::Microsoft.AspNetCore.Html.HtmlString("multipart/form-data"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\Korisnik\OneDrive\Desktop\Hidromil\Hidromil\Hidromil\Hidromil\Views\Home\Usluge.cshtml"
  
    Layout = "_LayoutIndex";
    ViewData["Title"] = "Usluge";

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Korisnik\OneDrive\Desktop\Hidromil\Hidromil\Hidromil\Hidromil\Views\Home\Usluge.cshtml"
  
    IList<Usluga> usluge = ViewBag.usluge;

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""banner-carousel banner-carousel-2 mb-0"">
    <div class=""banner-area"" style=""        background-image: url(../images/Images/5.jpg)"">

        <div class=""banner-text"">
            <div class=""container"">
                <div class=""row"">
                    <div class=""col-lg-12"">
                        <div class=""banner-heading"">
                            <div class=""box-slider-text"">
                                <h1 class=""banner-title"">Usluge</h1>

                            </div>
                        </div><!-- Col end -->
                    </div><!-- Row end -->
                </div><!-- Container end -->
            </div><!-- Banner text end -->
        </div>
    </div>
</div>
<div style=""width: 100%; background-color:black; height: 2px;""></div>

");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0186f599877f0e2ab53a0b6672abef4a33903aa25237", async() => {
                WriteLiteral(@"
    <section id=""main-container"" class=""main-container"">
        <div class=""container"">
            <div class=""gap-30""></div>
            <div style=""width: 100%; background-color:black; height: 2px;""></div>
            <div style=""width: 100%; background-color:white; height: 1px;""></div>
            <div style=""width: 100%; background-color:#ffb600; height: 12px;""></div>

");
#nullable restore
#line 39 "C:\Users\Korisnik\OneDrive\Desktop\Hidromil\Hidromil\Hidromil\Hidromil\Views\Home\Usluge.cshtml"
             foreach (var u in @usluge)
            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                <div class=\"gap-30\"></div>\r\n                <div class=\"row\">\r\n\r\n                    <div class=\"col-lg-6\">\r\n                        <div");
                BeginWriteAttribute("class", " class=\"", 1616, "\"", 1624, 0);
                EndWriteAttribute();
                WriteLiteral(" style=\"margin-left:10%;\">\r\n                            <div><h4>");
#nullable restore
#line 46 "C:\Users\Korisnik\OneDrive\Desktop\Hidromil\Hidromil\Hidromil\Hidromil\Views\Home\Usluge.cshtml"
                                Write(u.Naziv);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h4></div>\r\n                            <div>");
#nullable restore
#line 47 "C:\Users\Korisnik\OneDrive\Desktop\Hidromil\Hidromil\Hidromil\Hidromil\Views\Home\Usluge.cshtml"
                            Write(u.Opis);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"</div>
                        </div>
                    </div><!-- Col end -->

                    <div class=""col-lg-6 mt-5 mt-lg-0"">

                        <div class=""small-bg"">

                            <div class=""item"">
                                <div class=""container usluga"">
                                    <a class=""gallery-popup gallery""");
                BeginWriteAttribute("src", " src=\"", 2126, "\"", 2164, 2);
                WriteAttributeValue("", 2132, "data:image/png;base64,", 2132, 22, true);
#nullable restore
#line 57 "C:\Users\Korisnik\OneDrive\Desktop\Hidromil\Hidromil\Hidromil\Hidromil\Views\Home\Usluge.cshtml"
WriteAttributeValue("", 2154, u.Putanja, 2154, 10, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" aria-label=\"project-img\">\r\n                                        <img");
                BeginWriteAttribute("src", " src=\"", 2237, "\"", 2275, 2);
                WriteAttributeValue("", 2243, "data:image/png;base64,", 2243, 22, true);
#nullable restore
#line 58 "C:\Users\Korisnik\OneDrive\Desktop\Hidromil\Hidromil\Hidromil\Hidromil\Views\Home\Usluge.cshtml"
WriteAttributeValue("", 2265, u.Putanja, 2265, 10, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@" class=""img-lg"" alt=""Free HTML5 Bootstrap Template by FreeHTML5.co"" style=""height:200px; width:250px; margin-left:10%;"">

                                    </a>
                                </div>
                            </div><!-- Item 1 end -->

                        </div><!-- Page slider end-->

                        <div class=""gap-30""></div>
                    </div><!-- Col end -->


                </div><!-- Content row end -->
                <div style=""width: 100%; background-color:black; height: 2px;""></div>
                <div style=""width: 100%; background-color:white; height: 1px;""></div>
                <div style=""width: 100%; background-color:#ffb600; height: 12px;""></div>
");
#nullable restore
#line 74 "C:\Users\Korisnik\OneDrive\Desktop\Hidromil\Hidromil\Hidromil\Hidromil\Views\Home\Usluge.cshtml"
            }

#line default
#line hidden
#nullable disable
                WriteLiteral("        </div><!-- Container end -->\r\n    </section><!-- Main container end -->\r\n    <div style=\"width: 100%; background-color:black; height: 2px;\"></div>\r\n\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n<style scoped>\r\n    .usluga {\r\n        width: 100%;\r\n        align-content: center;\r\n    }\r\n</style>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Hidromil.Models.Usluga> Html { get; private set; }
    }
}
#pragma warning restore 1591
