#pragma checksum "C:\Users\Yulia\Desktop\my projects\Elections\Vybory\Views\Vote\TillElection.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "852d3e4a8331914cdb515b96ced4aa0b1f2a962b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Vote_TillElection), @"mvc.1.0.view", @"/Views/Vote/TillElection.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Vote/TillElection.cshtml", typeof(AspNetCore.Views_Vote_TillElection))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"852d3e4a8331914cdb515b96ced4aa0b1f2a962b", @"/Views/Vote/TillElection.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"df5106adb8c8542ff0b0664b72abbd02021e8fd9", @"/Views/_ViewImports.cshtml")]
    public class Views_Vote_TillElection : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Vybory.Models.Election>
    {
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(31, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\Yulia\Desktop\my projects\Elections\Vybory\Views\Vote\TillElection.cshtml"
  
    ViewData["Title"] = "TillElection";

#line default
#line hidden
            BeginContext(81, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(83, 47, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "852d3e4a8331914cdb515b96ced4aa0b1f2a962b3636", async() => {
                BeginContext(89, 34, true);
                WriteLiteral("\r\n    <title>Голосування</title>\r\n");
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
            BeginContext(130, 278, true);
            WriteLiteral(@"

<script>
    window.onload = function () {
        time();
        setInterval(function () {
            time();
        }, 1000);
    };

    //gets current time and changes html to reflect it
    function time() {
        var date = new Date();
        years = ");
            EndContext();
            BeginContext(409, 20, false);
#line 22 "C:\Users\Yulia\Desktop\my projects\Elections\Vybory\Views\Vote\TillElection.cshtml"
           Write(Model.StartVote.Year);

#line default
#line hidden
            EndContext();
            BeginContext(429, 41, true);
            WriteLiteral(" - date.getFullYear();\r\n        months = ");
            EndContext();
            BeginContext(471, 21, false);
#line 23 "C:\Users\Yulia\Desktop\my projects\Elections\Vybory\Views\Vote\TillElection.cshtml"
            Write(Model.StartVote.Month);

#line default
#line hidden
            EndContext();
            BeginContext(492, 40, true);
            WriteLiteral(" - date.getMonth() - 1;\r\n        days = ");
            EndContext();
            BeginContext(533, 19, false);
#line 24 "C:\Users\Yulia\Desktop\my projects\Elections\Vybory\Views\Vote\TillElection.cshtml"
          Write(Model.StartVote.Day);

#line default
#line hidden
            EndContext();
            BeginContext(552, 1184, true);
            WriteLiteral(@" - date.getDate();

        hours = 24 - date.getHours();
        hours = (hours == 24) ? (hours - 24) : hours;
        minutes = 60 - date.getMinutes();
        minutes = (minutes == 60) ? (minutes - 60) : minutes;
        seconds = 60 - date.getSeconds();
        seconds = (seconds == 60) ? (seconds - 60) : seconds;

        //invokes function to make sure number has at least two digits
        hours = addZero(hours);
        minutes = addZero(minutes);
        seconds = addZero(seconds);

        //changes the html to match results
        document.getElementsByClassName('years')[0].innerHTML = years;
        document.getElementsByClassName('months')[0].innerHTML = months;
        document.getElementsByClassName('days')[0].innerHTML = days;
        document.getElementsByClassName('hours')[0].innerHTML = hours;
        document.getElementsByClassName('minutes')[0].innerHTML = minutes;
        document.getElementsByClassName('seconds')[0].innerHTML = seconds;
    }

    //turns single ");
            WriteLiteral("digit numbers to two digit numbers by placing a zero in front\r\n    function addZero(val) {\r\n        return (val <= 9) ? (\"0\" + val) : val;\r\n    }\r\n</script>\r\n\r\n");
            EndContext();
            BeginContext(1736, 775, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "852d3e4a8331914cdb515b96ced4aa0b1f2a962b7457", async() => {
                BeginContext(1742, 60, true);
                WriteLiteral("\r\n    <div class=\"header\">\r\n        <a class=\"left_position\"");
                EndContext();
                BeginWriteAttribute("href", " href=\"", 1802, "\"", 1838, 1);
#line 55 "C:\Users\Yulia\Desktop\my projects\Elections\Vybory\Views\Vote\TillElection.cshtml"
WriteAttributeValue("", 1809, Url.Action("Index2", "Home"), 1809, 29, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1839, 665, true);
                WriteLiteral(@">Головна</a>
    </div>
    <div class=""main2"">
        <p class=""big_title"">
            До виборів залишилось:
          
            <div class=""clock"">
                <span class=""years"">0</span>
                <span> years </span>
                <span class=""months"">0</span>
                <span> months </span>
                <span class=""days"">0</span>
                <span> days </span>
                <span class=""hours"">00</span>
                <span> : </span>
                <span class=""minutes"">00</span>
                <span> : </span>
                <span class=""seconds"">00</span>
            </div>
    </div>
   
");
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
            BeginContext(2511, 2, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Vybory.Models.Election> Html { get; private set; }
    }
}
#pragma warning restore 1591
