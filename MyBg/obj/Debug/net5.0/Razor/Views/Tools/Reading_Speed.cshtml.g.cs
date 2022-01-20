#pragma checksum "C:\Users\danielr\source\repos\MyBg\MyBg\Views\Tools\Reading_Speed.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "67154d55c82f562cdcd5b4ecf2644600dd7644fe"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Tools_Reading_Speed), @"mvc.1.0.view", @"/Views/Tools/Reading_Speed.cshtml")]
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
#line 1 "C:\Users\danielr\source\repos\MyBg\MyBg\Views\_ViewImports.cshtml"
using MyBg;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\danielr\source\repos\MyBg\MyBg\Views\_ViewImports.cshtml"
using MyBg.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"67154d55c82f562cdcd5b4ecf2644600dd7644fe", @"/Views/Tools/Reading_Speed.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bc5dbcb0184da424cb338a8e1ab3a5366afac376", @"/Views/_ViewImports.cshtml")]
    public class Views_Tools_Reading_Speed : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "ReadingSpeed", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Tools", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("reset-button"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\danielr\source\repos\MyBg\MyBg\Views\Tools\Reading_Speed.cshtml"
  
    ViewData["Title"] = "Tools - Citation Machine";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<div class=""main-wrapper"">
    <section class=""reader-wrapper"">
        <div class=""reader-header"">
            <h3 class=""std-h3 h3-reader-title"">Select an animal to read about</h3>
            <div class=""topics-wrapper"">
                <span class=""std-icon reader-topic-icon"" onclick=""choseTopic('wolf')"" id=""button-wolf"">Wolf🐺</span>
                <span class=""std-icon reader-topic-icon"" onclick=""choseTopic('eagle')"" id=""button-eagle"">Eagle 🦅</span>
                <span class=""std-icon reader-topic-icon"" onclick=""choseTopic('rhino')"" id=""button-rhino"">Rhino 🦏</span>
                <span class=""std-icon reader-topic-icon"" onclick=""choseTopic('bison')"" id=""button-bison"">Bison 🦬</span>
                <span class=""std-icon reader-topic-icon"" onclick=""choseTopic('mammoth')"" id=""button-mammoth"">Mammoth 🦣</span>
                <span class=""std-icon reader-topic-icon"" onclick=""choseTopic('mamba')"" id=""button-mamba"">Mamba 🐍</span>
                <span class=""std-icon reader-topic-icon"" oncl");
            WriteLiteral(@"ick=""choseTopic('shark')"" id=""button-shark"">Shark 🦈</span>
            </div>
        </div>
        <p class=""reader-text-box""></p>
        <div class=""container"">
            <div class=""box"">
                <div class=""clock""></div>
            </div>
        </div>
        <div class=""botton-wrapper"">
            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "67154d55c82f562cdcd5b4ecf2644600dd7644fe5671", async() => {
                WriteLiteral(" <span class=\"read-reset std-icon\"></span>RESET");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
            <button class=""reset-button"" onclick=""startReading()""> <span class=""read-start std-icon""></span>START</button>
            <button class=""reset-button"" onclick=""stopReading()""><span class=""read-stop std-icon""></span>STOP</button>
        </div>
    </section>

    <div class=""reading-result-wrapper"">
    <h3 class=""std-h3 h3-reader-title"">Your results: </h3>
    <p class=""std-p reading-time-result"" id=""reading-time-result""></p>
    </div>
</div>

");
            DefineSection("Scripts", async() => {
                WriteLiteral(" \r\n<script src=\"/js/reading-speed.js\"></script>\r\n");
            }
            );
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
