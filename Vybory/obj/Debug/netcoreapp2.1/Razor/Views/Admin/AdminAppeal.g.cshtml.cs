#pragma checksum "C:\Users\Yulia\Desktop\my projects\Elections\Vybory\Views\Admin\AdminAppeal.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "64284532059f1fea9f06fe2e6723693f90857155"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_AdminAppeal), @"mvc.1.0.view", @"/Views/Admin/AdminAppeal.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Admin/AdminAppeal.cshtml", typeof(AspNetCore.Views_Admin_AdminAppeal))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"64284532059f1fea9f06fe2e6723693f90857155", @"/Views/Admin/AdminAppeal.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"df5106adb8c8542ff0b0664b72abbd02021e8fd9", @"/Views/_ViewImports.cshtml")]
    public class Views_Admin_AdminAppeal : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Vybory.Models.Appeal>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "EditPollingStation", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "EditElection", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "EditCitizen", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "EditAppeal", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 2 "C:\Users\Yulia\Desktop\my projects\Elections\Vybory\Views\Admin\AdminAppeal.cshtml"
  
    ViewData["Title"] = "AdminAppeal";

#line default
#line hidden
            BeginContext(89, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(91, 41, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "64284532059f1fea9f06fe2e6723693f908571554907", async() => {
                BeginContext(97, 28, true);
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
            BeginContext(132, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
            BeginContext(136, 1251, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "64284532059f1fea9f06fe2e6723693f908571556121", async() => {
                BeginContext(142, 60, true);
                WriteLiteral("\r\n    <div class=\"header\">\r\n        <a class=\"left_position\"");
                EndContext();
                BeginWriteAttribute("href", " href=\"", 202, "\"", 238, 1);
#line 12 "C:\Users\Yulia\Desktop\my projects\Elections\Vybory\Views\Admin\AdminAppeal.cshtml"
WriteAttributeValue("", 209, Url.Action("StartAdminPage"), 209, 29, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(239, 389, true);
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
#line 24 "C:\Users\Yulia\Desktop\my projects\Elections\Vybory\Views\Admin\AdminAppeal.cshtml"
             foreach (var appeal in Model)
            {

#line default
#line hidden
                BeginContext(687, 38, true);
                WriteLiteral("            <tr>\r\n                <td>");
                EndContext();
                BeginContext(726, 9, false);
#line 27 "C:\Users\Yulia\Desktop\my projects\Elections\Vybory\Views\Admin\AdminAppeal.cshtml"
               Write(appeal.Id);

#line default
#line hidden
                EndContext();
                BeginContext(735, 28, true);
                WriteLiteral("</td>\r\n                <td> ");
                EndContext();
                BeginContext(763, 103, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "64284532059f1fea9f06fe2e6723693f908571558109", async() => {
                    BeginContext(839, 23, false);
#line 28 "C:\Users\Yulia\Desktop\my projects\Elections\Vybory\Views\Admin\AdminAppeal.cshtml"
                                                                                           Write(appeal.PollingStationId);

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
#line 28 "C:\Users\Yulia\Desktop\my projects\Elections\Vybory\Views\Admin\AdminAppeal.cshtml"
                                                          WriteLiteral(appeal.PollingStationId);

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
                BeginContext(866, 28, true);
                WriteLiteral("</td>\r\n                <td> ");
                EndContext();
                BeginContext(894, 85, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "64284532059f1fea9f06fe2e6723693f9085715510826", async() => {
                    BeginContext(958, 17, false);
#line 29 "C:\Users\Yulia\Desktop\my projects\Elections\Vybory\Views\Admin\AdminAppeal.cshtml"
                                                                               Write(appeal.ElectionId);

#line default
#line hidden
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
#line 29 "C:\Users\Yulia\Desktop\my projects\Elections\Vybory\Views\Admin\AdminAppeal.cshtml"
                                                    WriteLiteral(appeal.ElectionId);

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
                BeginContext(979, 28, true);
                WriteLiteral("</td>\r\n                <td> ");
                EndContext();
                BeginContext(1007, 82, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "64284532059f1fea9f06fe2e6723693f9085715513515", async() => {
                    BeginContext(1069, 16, false);
#line 30 "C:\Users\Yulia\Desktop\my projects\Elections\Vybory\Views\Admin\AdminAppeal.cshtml"
                                                                             Write(appeal.CitizenId);

#line default
#line hidden
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
#line 30 "C:\Users\Yulia\Desktop\my projects\Elections\Vybory\Views\Admin\AdminAppeal.cshtml"
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
                BeginContext(1089, 27, true);
                WriteLiteral("</td>\r\n                <td>");
                EndContext();
                BeginContext(1117, 19, false);
#line 31 "C:\Users\Yulia\Desktop\my projects\Elections\Vybory\Views\Admin\AdminAppeal.cshtml"
               Write(appeal.AppealTypeId);

#line default
#line hidden
                EndContext();
                BeginContext(1136, 27, true);
                WriteLiteral("</td>\r\n                <td>");
                EndContext();
                BeginContext(1164, 11, false);
#line 32 "C:\Users\Yulia\Desktop\my projects\Elections\Vybory\Views\Admin\AdminAppeal.cshtml"
               Write(appeal.Text);

#line default
#line hidden
                EndContext();
                BeginContext(1175, 49, true);
                WriteLiteral("</td>\r\n                <td>\r\n                    ");
                EndContext();
                BeginContext(1224, 67, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "64284532059f1fea9f06fe2e6723693f9085715516998", async() => {
                    BeginContext(1277, 10, true);
                    WriteLiteral("Редагувати");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
                if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
                {
                    throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
                }
                BeginWriteTagHelperAttribute();
#line 34 "C:\Users\Yulia\Desktop\my projects\Elections\Vybory\Views\Admin\AdminAppeal.cshtml"
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
                BeginContext(1291, 44, true);
                WriteLiteral("\r\n                </td>\r\n            </tr>\r\n");
                EndContext();
#line 37 "C:\Users\Yulia\Desktop\my projects\Elections\Vybory\Views\Admin\AdminAppeal.cshtml"
            }

#line default
#line hidden
                BeginContext(1350, 30, true);
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
            BeginContext(1387, 4, true);
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