#pragma checksum "C:\Users\Yulia\Desktop\my projects\Elections\Vybory\Views\Observer\ObserverAppeal.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "31b915b2697857f25fc056dafbe5865f07120fec"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Observer_ObserverAppeal), @"mvc.1.0.view", @"/Views/Observer/ObserverAppeal.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Observer/ObserverAppeal.cshtml", typeof(AspNetCore.Views_Observer_ObserverAppeal))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"31b915b2697857f25fc056dafbe5865f07120fec", @"/Views/Observer/ObserverAppeal.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"df5106adb8c8542ff0b0664b72abbd02021e8fd9", @"/Views/_ViewImports.cshtml")]
    public class Views_Observer_ObserverAppeal : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Vybory.Models.Appeal>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "DetailUser", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "EditAppeal", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\Yulia\Desktop\my projects\Elections\Vybory\Views\Observer\ObserverAppeal.cshtml"
  
    ViewData["Title"] = "ObserverAppeal";

#line default
#line hidden
            BeginContext(92, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(94, 41, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "31b915b2697857f25fc056dafbe5865f07120fec4337", async() => {
                BeginContext(100, 28, true);
                WriteLiteral("\r\n    <title>Заява</title>\r\n");
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
            BeginContext(135, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
            BeginContext(139, 1150, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "31b915b2697857f25fc056dafbe5865f07120fec5552", async() => {
                BeginContext(145, 60, true);
                WriteLiteral("\r\n    <div class=\"header\">\r\n        <a class=\"left_position\"");
                EndContext();
                BeginWriteAttribute("href", " href=\"", 205, "\"", 244, 1);
#line 12 "C:\Users\Yulia\Desktop\my projects\Elections\Vybory\Views\Observer\ObserverAppeal.cshtml"
WriteAttributeValue("", 212, Url.Action("Index", "Observer"), 212, 32, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(245, 389, true);
                WriteLiteral(@">Початкова</a>
    </div>
    <div class=""main2"">
        <table class=""table table-bordered table-responsive table-hover formclass"">
            <tr>
                <th>ID</th>
                <th>Дільниця ID</th>
                <th>Вибори ID</th>
                <th>Громадянин ID</th>
                <th>тип Заяви ID</th>
                <th>Заява</th>
            </tr>
");
                EndContext();
#line 24 "C:\Users\Yulia\Desktop\my projects\Elections\Vybory\Views\Observer\ObserverAppeal.cshtml"
             foreach (var appeal in Model)
            {

#line default
#line hidden
                BeginContext(693, 46, true);
                WriteLiteral("                <tr>\r\n                    <td>");
                EndContext();
                BeginContext(740, 9, false);
#line 27 "C:\Users\Yulia\Desktop\my projects\Elections\Vybory\Views\Observer\ObserverAppeal.cshtml"
                   Write(appeal.Id);

#line default
#line hidden
                EndContext();
                BeginContext(749, 32, true);
                WriteLiteral("</td>\r\n                    <td> ");
                EndContext();
                BeginContext(782, 23, false);
#line 28 "C:\Users\Yulia\Desktop\my projects\Elections\Vybory\Views\Observer\ObserverAppeal.cshtml"
                    Write(appeal.PollingStationId);

#line default
#line hidden
                EndContext();
                BeginContext(805, 31, true);
                WriteLiteral("</td>\r\n                    <td>");
                EndContext();
                BeginContext(837, 17, false);
#line 29 "C:\Users\Yulia\Desktop\my projects\Elections\Vybory\Views\Observer\ObserverAppeal.cshtml"
                   Write(appeal.ElectionId);

#line default
#line hidden
                EndContext();
                BeginContext(854, 32, true);
                WriteLiteral("</td>\r\n                    <td> ");
                EndContext();
                BeginContext(886, 81, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "31b915b2697857f25fc056dafbe5865f07120fec8386", async() => {
                    BeginContext(947, 16, false);
#line 30 "C:\Users\Yulia\Desktop\my projects\Elections\Vybory\Views\Observer\ObserverAppeal.cshtml"
                                                                                Write(appeal.CitizenId);

#line default
#line hidden
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
                {
                    throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
                }
                BeginWriteTagHelperAttribute();
#line 30 "C:\Users\Yulia\Desktop\my projects\Elections\Vybory\Views\Observer\ObserverAppeal.cshtml"
                                                      WriteLiteral(appeal.CitizenId);

#line default
#line hidden
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(967, 31, true);
                WriteLiteral("</td>\r\n                    <td>");
                EndContext();
                BeginContext(999, 19, false);
#line 31 "C:\Users\Yulia\Desktop\my projects\Elections\Vybory\Views\Observer\ObserverAppeal.cshtml"
                   Write(appeal.AppealTypeId);

#line default
#line hidden
                EndContext();
                BeginContext(1018, 31, true);
                WriteLiteral("</td>\r\n                    <td>");
                EndContext();
                BeginContext(1050, 11, false);
#line 32 "C:\Users\Yulia\Desktop\my projects\Elections\Vybory\Views\Observer\ObserverAppeal.cshtml"
                   Write(appeal.Text);

#line default
#line hidden
                EndContext();
                BeginContext(1061, 57, true);
                WriteLiteral("</td>\r\n                    <td>\r\n                        ");
                EndContext();
                BeginContext(1118, 67, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "31b915b2697857f25fc056dafbe5865f07120fec11919", async() => {
                    BeginContext(1171, 10, true);
                    WriteLiteral("Редагувати");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
                {
                    throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
                }
                BeginWriteTagHelperAttribute();
#line 34 "C:\Users\Yulia\Desktop\my projects\Elections\Vybory\Views\Observer\ObserverAppeal.cshtml"
                                                     WriteLiteral(appeal.Id);

#line default
#line hidden
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1185, 52, true);
                WriteLiteral("\r\n                    </td>\r\n                </tr>\r\n");
                EndContext();
#line 37 "C:\Users\Yulia\Desktop\my projects\Elections\Vybory\Views\Observer\ObserverAppeal.cshtml"
            }

#line default
#line hidden
                BeginContext(1252, 30, true);
                WriteLiteral("        </table>\r\n    </div>\r\n");
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
            BeginContext(1289, 4, true);
            WriteLiteral("\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Vybory.Models.Appeal>> Html { get; private set; }
    }
}
#pragma warning restore 1591
