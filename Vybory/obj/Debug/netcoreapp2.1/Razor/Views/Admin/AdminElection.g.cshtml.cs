#pragma checksum "C:\Users\Yulia\Desktop\my projects\Elections\Vybory\Views\Admin\AdminElection.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7459b9b9fd13788d4a94729f6fb6e2b732efbea1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_AdminElection), @"mvc.1.0.view", @"/Views/Admin/AdminElection.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Admin/AdminElection.cshtml", typeof(AspNetCore.Views_Admin_AdminElection))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7459b9b9fd13788d4a94729f6fb6e2b732efbea1", @"/Views/Admin/AdminElection.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"df5106adb8c8542ff0b0664b72abbd02021e8fd9", @"/Views/_ViewImports.cshtml")]
    public class Views_Admin_AdminElection : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Vybory.Models.Election>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "CreateElection", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "EditElection", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "DeleteElection", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 2 "C:\Users\Yulia\Desktop\my projects\Elections\Vybory\Views\Admin\AdminElection.cshtml"
  
    ViewData["Title"] = "AdminElection";

#line default
#line hidden
            BeginContext(93, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(95, 42, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7459b9b9fd13788d4a94729f6fb6e2b732efbea14621", async() => {
                BeginContext(101, 29, true);
                WriteLiteral("\r\n    <title>Вибори</title>\r\n");
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
            BeginContext(137, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
            BeginContext(141, 1265, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7459b9b9fd13788d4a94729f6fb6e2b732efbea15837", async() => {
                BeginContext(147, 60, true);
                WriteLiteral("\r\n    <div class=\"header\">\r\n        <a class=\"left_position\"");
                EndContext();
                BeginWriteAttribute("href", " href=\"", 207, "\"", 243, 1);
#line 12 "C:\Users\Yulia\Desktop\my projects\Elections\Vybory\Views\Admin\AdminElection.cshtml"
WriteAttributeValue("", 214, Url.Action("StartAdminPage"), 214, 29, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(244, 78, true);
                WriteLiteral(">Початкова</a>\r\n    </div>\r\n    <div class=\"main2\">\r\n        <p>\r\n            ");
                EndContext();
                BeginContext(322, 55, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7459b9b9fd13788d4a94729f6fb6e2b732efbea16803", async() => {
                    BeginContext(353, 20, true);
                    WriteLiteral("Створити Нові Вибори");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(377, 344, true);
                WriteLiteral(@"
        </p>
        <table class=""table table-bordered table-responsive table-hover formclass"">
            <tr>
                <th>ID</th>
                <th>Ім'я</th>
                <th>Рік</th>
                <th>Тур</th>
                <th>Розпочаток виборів</th>
                <th>Кінець виборів</th>
            </tr>
");
                EndContext();
#line 27 "C:\Users\Yulia\Desktop\my projects\Elections\Vybory\Views\Admin\AdminElection.cshtml"
             foreach (var election in Model)
            {

#line default
#line hidden
                BeginContext(782, 46, true);
                WriteLiteral("                <tr>\r\n                    <td>");
                EndContext();
                BeginContext(829, 11, false);
#line 30 "C:\Users\Yulia\Desktop\my projects\Elections\Vybory\Views\Admin\AdminElection.cshtml"
                   Write(election.Id);

#line default
#line hidden
                EndContext();
                BeginContext(840, 31, true);
                WriteLiteral("</td>\r\n                    <td>");
                EndContext();
                BeginContext(872, 13, false);
#line 31 "C:\Users\Yulia\Desktop\my projects\Elections\Vybory\Views\Admin\AdminElection.cshtml"
                   Write(election.Name);

#line default
#line hidden
                EndContext();
                BeginContext(885, 31, true);
                WriteLiteral("</td>\r\n                    <td>");
                EndContext();
                BeginContext(917, 13, false);
#line 32 "C:\Users\Yulia\Desktop\my projects\Elections\Vybory\Views\Admin\AdminElection.cshtml"
                   Write(election.Year);

#line default
#line hidden
                EndContext();
                BeginContext(930, 31, true);
                WriteLiteral("</td>\r\n                    <td>");
                EndContext();
                BeginContext(962, 15, false);
#line 33 "C:\Users\Yulia\Desktop\my projects\Elections\Vybory\Views\Admin\AdminElection.cshtml"
                   Write(election.TourId);

#line default
#line hidden
                EndContext();
                BeginContext(977, 31, true);
                WriteLiteral("</td>\r\n                    <td>");
                EndContext();
                BeginContext(1009, 18, false);
#line 34 "C:\Users\Yulia\Desktop\my projects\Elections\Vybory\Views\Admin\AdminElection.cshtml"
                   Write(election.StartVote);

#line default
#line hidden
                EndContext();
                BeginContext(1027, 31, true);
                WriteLiteral("</td>\r\n                    <td>");
                EndContext();
                BeginContext(1059, 16, false);
#line 35 "C:\Users\Yulia\Desktop\my projects\Elections\Vybory\Views\Admin\AdminElection.cshtml"
                   Write(election.EndVote);

#line default
#line hidden
                EndContext();
                BeginContext(1075, 57, true);
                WriteLiteral("</td>\r\n                    <td>\r\n                        ");
                EndContext();
                BeginContext(1132, 71, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7459b9b9fd13788d4a94729f6fb6e2b732efbea111368", async() => {
                    BeginContext(1189, 10, true);
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
#line 37 "C:\Users\Yulia\Desktop\my projects\Elections\Vybory\Views\Admin\AdminElection.cshtml"
                                                       WriteLiteral(election.Id);

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
                BeginContext(1203, 28, true);
                WriteLiteral(" |\r\n                        ");
                EndContext();
                BeginContext(1231, 71, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7459b9b9fd13788d4a94729f6fb6e2b732efbea113874", async() => {
                    BeginContext(1290, 8, true);
                    WriteLiteral("Видалити");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
                {
                    throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
                }
                BeginWriteTagHelperAttribute();
#line 38 "C:\Users\Yulia\Desktop\my projects\Elections\Vybory\Views\Admin\AdminElection.cshtml"
                                                         WriteLiteral(election.Id);

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
                BeginContext(1302, 52, true);
                WriteLiteral("\r\n                    </td>\r\n                </tr>\r\n");
                EndContext();
#line 41 "C:\Users\Yulia\Desktop\my projects\Elections\Vybory\Views\Admin\AdminElection.cshtml"
            }

#line default
#line hidden
                BeginContext(1369, 30, true);
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
            BeginContext(1406, 4, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Vybory.Models.Election>> Html { get; private set; }
    }
}
#pragma warning restore 1591
