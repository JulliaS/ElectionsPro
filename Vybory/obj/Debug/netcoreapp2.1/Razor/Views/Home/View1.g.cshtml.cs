#pragma checksum "C:\Users\Yulia\Desktop\my projects\Elections\Vybory\Views\Home\View1.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "46a053c2cd4fc42bf9299c77112b6e5c7a2744de"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_View1), @"mvc.1.0.view", @"/Views/Home/View1.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/View1.cshtml", typeof(AspNetCore.Views_Home_View1))]
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
#line 1 "C:\Users\Yulia\Desktop\my projects\Elections\Vybory\Views\_ViewImports.cshtml"
using Vybory;

#line default
#line hidden
#line 2 "C:\Users\Yulia\Desktop\my projects\Elections\Vybory\Views\_ViewImports.cshtml"
using Vybory.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"46a053c2cd4fc42bf9299c77112b6e5c7a2744de", @"/Views/Home/View1.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"df5106adb8c8542ff0b0664b72abbd02021e8fd9", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_View1 : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/ForDropDown.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 2 "C:\Users\Yulia\Desktop\my projects\Elections\Vybory\Views\Home\View1.cshtml"
  
    ViewData["Title"] = "View1";

#line default
#line hidden
            BeginContext(43, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(45, 43, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "46a053c2cd4fc42bf9299c77112b6e5c7a2744de4072", async() => {
                BeginContext(51, 30, true);
                WriteLiteral("\r\n    <title>Головна</title>\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(88, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(90, 1207, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "46a053c2cd4fc42bf9299c77112b6e5c7a2744de5282", async() => {
                BeginContext(96, 80, true);
                WriteLiteral("\r\n\r\n    <div class=\"header\">\r\n        <p class=\"right_position\">\r\n            <a");
                EndContext();
                BeginWriteAttribute("href", " href=\"", 176, "\"", 213, 1);
#line 13 "C:\Users\Yulia\Desktop\my projects\Elections\Vybory\Views\Home\View1.cshtml"
WriteAttributeValue("", 183, Url.Action("Login","Account"), 183, 30, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(214, 25, true);
                WriteLiteral(">Вхід</a>\r\n            <a");
                EndContext();
                BeginWriteAttribute("href", " href=\"", 239, "\"", 282, 1);
#line 14 "C:\Users\Yulia\Desktop\my projects\Elections\Vybory\Views\Home\View1.cshtml"
WriteAttributeValue("", 246, Url.Action("Registrate", "Account"), 246, 36, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(283, 258, true);
                WriteLiteral(@">Реєстрація</a>
        </p>

    </div>
    <div class=""main"">
        <div  class=""dropdown"">
            <button onclick=""myFunction()"" class=""dropbtn"">Допомога</button>
            <div id=""myDropdown"" class=""dropdown-content"">
                <a");
                EndContext();
                BeginWriteAttribute("href", " href=\"", 541, "\"", 578, 1);
#line 22 "C:\Users\Yulia\Desktop\my projects\Elections\Vybory\Views\Home\View1.cshtml"
WriteAttributeValue("", 548, Url.Action("Login","Account"), 548, 30, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(579, 580, true);
                WriteLiteral(@">Інструкції</a>
                <a href=""https://www.cvk.gov.ua/metod/kultura/npa/"">Нормативно-правова база</a>
                <a href=""https://uk.wikipedia.org/wiki/Вибори_Президента_України"">Довідкова інформація</a>
            </div>
        </div>
        <p class=""big_title"">
            Вибори президента України
            <br /><div style=""font-size:60px; text-align: center;"">2024</div>
        </p>
    </div>
    <div class=""footer"">
        <div style=""vertical-align:middle;  text-align: center;""> <a style=""vertical-align:central"" class=""center column""");
                EndContext();
                BeginWriteAttribute("href", " href=\"", 1159, "\"", 1197, 1);
#line 33 "C:\Users\Yulia\Desktop\my projects\Elections\Vybory\Views\Home\View1.cshtml"
WriteAttributeValue("", 1166, Url.Action("Login", "Account"), 1166, 31, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1198, 47, true);
                WriteLiteral(">Проголосувати</a></div>\r\n       </div>\r\n\r\n    ");
                EndContext();
                BeginContext(1245, 43, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "46a053c2cd4fc42bf9299c77112b6e5c7a2744de8410", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1288, 2, true);
                WriteLiteral("\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1297, 2, true);
            WriteLiteral("\r\n");
            EndContext();
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
