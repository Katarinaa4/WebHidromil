#pragma checksum "C:\Users\Korisnik\Desktop\Hidromil\Hidromil\Hidromil\Hidromil\Views\Admin\AdminUsluge.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a42e4833e7f636b21d0fd2aa7c46c465c92600b3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_AdminUsluge), @"mvc.1.0.view", @"/Views/Admin/AdminUsluge.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a42e4833e7f636b21d0fd2aa7c46c465c92600b3", @"/Views/Admin/AdminUsluge.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ab2fb480d316bf50f70d3cb1e3d2a394f5da1547", @"/Views/_ViewImports.cshtml")]
    public class Views_Admin_AdminUsluge : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Hidromil.Models.Slika>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("submit"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", new global::Microsoft.AspNetCore.Html.HtmlString("Dodaj novu uslugu"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "AdminDodajUslugu", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Admin", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", new global::Microsoft.AspNetCore.Html.HtmlString("Obrisi uslugu"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "ObrisiUslugu", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("enctype", new global::Microsoft.AspNetCore.Html.HtmlString("multipart/form-data"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 2 "C:\Users\Korisnik\Desktop\Hidromil\Hidromil\Hidromil\Hidromil\Views\Admin\AdminUsluge.cshtml"
  
    Layout = "_LayoutGalerijaAdmin";
    ViewData["Title"] = "Usluge";

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Korisnik\Desktop\Hidromil\Hidromil\Hidromil\Hidromil\Views\Admin\AdminUsluge.cshtml"
  
    IList<Usluga> uslugee = ViewBag.Usluge;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a42e4833e7f636b21d0fd2aa7c46c465c92600b36525", async() => {
                WriteLiteral("\r\n    <section id=\"main-container\" class=\"main-container\">\r\n        <div class=\"container\">\r\n            <div class=\"gap-40\"></div>\r\n            <div>\r\n                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "a42e4833e7f636b21d0fd2aa7c46c465c92600b36965", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormActionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.Action = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
            </div>
            <div class=""gap-40""></div>
            <div style=""width: 100%; background-color:black; height: 2px;""></div>
            <div style=""width: 100%; background-color:white; height: 1px;""></div>
            <div style=""width: 100%; background-color:#ffb600; height: 12px;""></div>
");
#nullable restore
#line 21 "C:\Users\Korisnik\Desktop\Hidromil\Hidromil\Hidromil\Hidromil\Views\Admin\AdminUsluge.cshtml"
             foreach (var u in @uslugee)
            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                <div class=\"row\">\r\n\r\n                    <div class=\"col-lg-6\">\r\n                        <div class=\"gap-40\"></div>\r\n\r\n                        <div");
                BeginWriteAttribute("class", " class=\"", 1018, "\"", 1026, 0);
                EndWriteAttribute();
                WriteLiteral(" style=\"margin-left:10%;\">\r\n                            <div><h4>");
#nullable restore
#line 29 "C:\Users\Korisnik\Desktop\Hidromil\Hidromil\Hidromil\Hidromil\Views\Admin\AdminUsluge.cshtml"
                                Write(u.Naziv);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h4></div>\r\n                            <div>");
#nullable restore
#line 30 "C:\Users\Korisnik\Desktop\Hidromil\Hidromil\Hidromil\Hidromil\Views\Admin\AdminUsluge.cshtml"
                            Write(u.Opis);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"</div>
                        </div>
                    </div><!-- Col end -->

                    <div class=""col-lg-6 mt-5 mt-lg-0"">
                        <div class=""gap-40""></div>

                        <div class=""small-bg"">

                            <div class=""item"">
                                <div class=""container usluga"">
                                    <a class=""gallery-popup gallery""");
                BeginWriteAttribute("src", " src=\"", 1580, "\"", 1618, 2);
                WriteAttributeValue("", 1586, "data:image/png;base64,", 1586, 22, true);
#nullable restore
#line 41 "C:\Users\Korisnik\Desktop\Hidromil\Hidromil\Hidromil\Hidromil\Views\Admin\AdminUsluge.cshtml"
WriteAttributeValue("", 1608, u.Putanja, 1608, 10, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" aria-label=\"project-img\">\r\n                                        <img");
                BeginWriteAttribute("src", " src=\"", 1691, "\"", 1729, 2);
                WriteAttributeValue("", 1697, "data:image/png;base64,", 1697, 22, true);
#nullable restore
#line 42 "C:\Users\Korisnik\Desktop\Hidromil\Hidromil\Hidromil\Hidromil\Views\Admin\AdminUsluge.cshtml"
WriteAttributeValue("", 1719, u.Putanja, 1719, 10, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@" class=""img-lg"" alt=""Free HTML5 Bootstrap Template by FreeHTML5.co"" style=""height:200px; width:250px; margin-left:10%;"">

                                    </a>
                                </div>
                            </div><!-- Item 1 end -->

                        </div><!-- Page slider end-->

                    </div><!-- Col end -->
                    <div class=""gap-20""></div>
                    <div class=""swal2-warning"">
                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "a42e4833e7f636b21d0fd2aa7c46c465c92600b312051", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormActionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.Action = (string)__tagHelperAttribute_5.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
                if (__Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.RouteValues == null)
                {
                    throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.FormActionTagHelper", "RouteValues"));
                }
                BeginWriteTagHelperAttribute();
#nullable restore
#line 53 "C:\Users\Korisnik\Desktop\Hidromil\Hidromil\Hidromil\Hidromil\Views\Admin\AdminUsluge.cshtml"
                                                                                                                      WriteLiteral(u.Id);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
                    </div>
                    <div class=""gap-40""></div>

                </div><!-- Content row end -->
                <div style=""width: 100%; background-color:black; height: 2px;""></div>
                <div style=""width: 100%; background-color:white; height: 1px;""></div>
                <div style=""width: 100%; background-color:#ffb600; height: 12px;""></div>
");
#nullable restore
#line 61 "C:\Users\Korisnik\Desktop\Hidromil\Hidromil\Hidromil\Hidromil\Views\Admin\AdminUsluge.cshtml"
            }

#line default
#line hidden
#nullable disable
                WriteLiteral("        </div><!-- Container end -->\r\n    </section><!-- Main container end -->\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
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
