#pragma checksum "C:\Users\Yulia\Desktop\my projects\Elections\Vybory\Views\PolStCherman\PolStChermanCitizen.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9a66e704c8c5bbdb3e6bdafe92716df062f3c52c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_PolStCherman_PolStChermanCitizen), @"mvc.1.0.view", @"/Views/PolStCherman/PolStChermanCitizen.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/PolStCherman/PolStChermanCitizen.cshtml", typeof(AspNetCore.Views_PolStCherman_PolStChermanCitizen))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9a66e704c8c5bbdb3e6bdafe92716df062f3c52c", @"/Views/PolStCherman/PolStChermanCitizen.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"df5106adb8c8542ff0b0664b72abbd02021e8fd9", @"/Views/_ViewImports.cshtml")]
    public class Views_PolStCherman_PolStChermanCitizen : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Vybory.Models.Citizen>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "DetailUser", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "EditCitizen", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 2 "C:\Users\Yulia\Desktop\my projects\Elections\Vybory\Views\PolStCherman\PolStChermanCitizen.cshtml"
  
    ViewData["Title"] = "PolStChermanCitizen";

#line default
#line hidden
            BeginContext(98, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(100, 45, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9a66e704c8c5bbdb3e6bdafe92716df062f3c52c4417", async() => {
                BeginContext(106, 32, true);
                WriteLiteral("\r\n    <title>Громадяни</title>\r\n");
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
            BeginContext(145, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
            BeginContext(149, 1073, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9a66e704c8c5bbdb3e6bdafe92716df062f3c52c5636", async() => {
                BeginContext(155, 60, true);
                WriteLiteral("\r\n    <div class=\"header\">\r\n        <a class=\"left_position\"");
                EndContext();
                BeginWriteAttribute("href", " href=\"", 215, "\"", 258, 1);
#line 12 "C:\Users\Yulia\Desktop\my projects\Elections\Vybory\Views\PolStCherman\PolStChermanCitizen.cshtml"
WriteAttributeValue("", 222, Url.Action("Index", "PolStCherman"), 222, 36, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(259, 350, true);
                WriteLiteral(@">Початкова</a>
    </div>
    <div class=""main2"">
        <table class=""table table-bordered table-responsive table-hover formclass"">
            <tr>
                <th>ID</th>
                <th>Округ  ID</th>
                <th>Дільниця ID</th>
                <th>Вибори ID</th>
                <th>Статус ID</th>
            </tr>
");
                EndContext();
#line 23 "C:\Users\Yulia\Desktop\my projects\Elections\Vybory\Views\PolStCherman\PolStChermanCitizen.cshtml"
             foreach (var citizen in Model)
            {

#line default
#line hidden
                BeginContext(669, 46, true);
                WriteLiteral("                <tr>\r\n                    <td>");
                EndContext();
                BeginContext(715, 69, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9a66e704c8c5bbdb3e6bdafe92716df062f3c52c7251", async() => {
                    BeginContext(770, 10, false);
#line 26 "C:\Users\Yulia\Desktop\my projects\Elections\Vybory\Views\PolStCherman\PolStChermanCitizen.cshtml"
                                                                         Write(citizen.Id);

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
#line 26 "C:\Users\Yulia\Desktop\my projects\Elections\Vybory\Views\PolStCherman\PolStChermanCitizen.cshtml"
                                                     WriteLiteral(citizen.Id);

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
                BeginContext(784, 32, true);
                WriteLiteral("</td>\r\n                    <td> ");
                EndContext();
                BeginContext(817, 18, false);
#line 27 "C:\Users\Yulia\Desktop\my projects\Elections\Vybory\Views\PolStCherman\PolStChermanCitizen.cshtml"
                    Write(citizen.DistrictId);

#line default
#line hidden
                EndContext();
                BeginContext(835, 32, true);
                WriteLiteral("</td>\r\n                    <td> ");
                EndContext();
                BeginContext(868, 24, false);
#line 28 "C:\Users\Yulia\Desktop\my projects\Elections\Vybory\Views\PolStCherman\PolStChermanCitizen.cshtml"
                    Write(citizen.PollingStationId);

#line default
#line hidden
                EndContext();
                BeginContext(892, 32, true);
                WriteLiteral("</td>\r\n                    <td> ");
                EndContext();
                BeginContext(925, 18, false);
#line 29 "C:\Users\Yulia\Desktop\my projects\Elections\Vybory\Views\PolStCherman\PolStChermanCitizen.cshtml"
                    Write(citizen.ElectionId);

#line default
#line hidden
                EndContext();
                BeginContext(943, 32, true);
                WriteLiteral("</td>\r\n                    <td> ");
                EndContext();
                BeginContext(976, 16, false);
#line 30 "C:\Users\Yulia\Desktop\my projects\Elections\Vybory\Views\PolStCherman\PolStChermanCitizen.cshtml"
                    Write(citizen.StatusId);

#line default
#line hidden
                EndContext();
                BeginContext(992, 57, true);
                WriteLiteral("</td>\r\n                    <td>\r\n                        ");
                EndContext();
                BeginContext(1049, 69, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9a66e704c8c5bbdb3e6bdafe92716df062f3c52c11637", async() => {
                    BeginContext(1104, 10, true);
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
#line 32 "C:\Users\Yulia\Desktop\my projects\Elections\Vybory\Views\PolStCherman\PolStChermanCitizen.cshtml"
                                                      WriteLiteral(citizen.Id);

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
                BeginContext(1118, 52, true);
                WriteLiteral("\r\n                    </td>\r\n                </tr>\r\n");
                EndContext();
#line 35 "C:\Users\Yulia\Desktop\my projects\Elections\Vybory\Views\PolStCherman\PolStChermanCitizen.cshtml"
            }

#line default
#line hidden
                BeginContext(1185, 30, true);
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
            BeginContext(1222, 4, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Vybory.Models.Citizen>> Html { get; private set; }
    }
}
#pragma warning restore 1591
