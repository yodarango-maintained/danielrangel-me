#pragma checksum "C:\Users\danielr\source\repos\MyBg\MyBg\Views\Tools\Citation_Machine.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0cf01b2b20ea25a47dda67aff8820900bf7e81e6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Tools_Citation_Machine), @"mvc.1.0.view", @"/Views/Tools/Citation_Machine.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0cf01b2b20ea25a47dda67aff8820900bf7e81e6", @"/Views/Tools/Citation_Machine.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bc5dbcb0184da424cb338a8e1ab3a5366afac376", @"/Views/_ViewImports.cshtml")]
    public class Views_Tools_Citation_Machine : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "CitationMachine", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 1 "C:\Users\danielr\source\repos\MyBg\MyBg\Views\Tools\Citation_Machine.cshtml"
  
    ViewData["Title"] = "Tools - Reading Speed";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<div class=""main-wrapper"">
    <section class=""post-title-wrapper wrapper-favorite"">
        <span class=""post-type post-type_header--cite-source std-icon""></span>
        <h1 class=""std-h1 favorites-title"">CITE A COURCE</h1>
    </section>

    <section class=""reader-wrapper"">
        <div class=""reader-header"">
            <h3 class=""std-h3 h3-reader-title"">Select a citation style</h3>
            <div class=""topics-wrapper"">
                <span class=""std-icon reader-topic-icon"" onclick=""chooseCitationStyle('mla')"" id=""button-mla"">MLA</span>
                <span class=""std-icon reader-topic-icon"" onclick=""chooseCitationStyle('apa')"" id=""button-apa"">APA</span>
                <span class=""std-icon reader-topic-icon"" onclick=""chooseCitationStyle('chicago')"" id=""button-chicago"">Chicago</span>
                <span class=""std-icon reader-topic-icon"" onclick=""chooseCitationStyle('turbian')"" id=""button-turbian"">Turbian</span>
            </div>

            <h3 class=""std-h3 h3-reader-title"">S");
            WriteLiteral(@"elect a source type</h3>
            <div class=""botton-wrapper"">
                <button class=""source-button"" id=""source-type-book"" onclick=""SelectSourceType('book')""> <span class=""citation-journal-source std-icon""></span>BOOK</button>
                <button class=""source-button"" id=""source-type-journal"" onclick=""SelectSourceType('journal')""> <span class=""citation-journal-source std-icon""></span>JOURNAL</button>
                <button class=""source-button"" id=""source-type-website"" onclick=""SelectSourceType('website')""><span class=""citation-website-source std-icon""></span>WEBSITE</button>
            </div>
        </div>
");
            WriteLiteral(@"        <div class=""citation-form-wrapper citation-form_mla-book"" id=""mla-wrapper-book"">
            <div class=""authors-wrapper"">
                <div class=""single-author-wrap"">
                    <input type=""text"" class=""std-form-input"" placeholder=""Auhthor's First Name"" id=""input-first-author-fn--book"" />
                    <input type=""text"" class=""std-form-input"" placeholder=""Auhthor's Last Name"" id=""input-first-author-ln--book"" />
                </div>
                <div class=""add-author-wrapper"">
                    <span class=""more-icon std-icon"" id=""addAuthor""></span> <p class=""std-text-quiet add-author"">Add another author</p>
                </div>
            </div>

            <input type=""text"" class=""std-form-input"" placeholder=""Book Title"" id=""input-title--book"" />
            <input type=""text"" class=""std-form-input"" placeholder=""Edition"" id=""input-edition--book"" />
            <input type=""text"" class=""std-form-input"" placeholder=""Publisher"" id=""input-publisher--book"" /");
            WriteLiteral(">\r\n            <input type=\"text\" class=\"std-form-input\" placeholder=\"Year Published\" id=\"input-yearPub--book\"/>\r\n\r\n        </div>\r\n\r\n");
            WriteLiteral(@"        <div class=""citation-form-wrapper citation-form_mla-journal"" id=""mla-wrapper-journal"">
            <div class=""authors-wrapper"">
                <div class=""single-author-wrap"">
                    <input type=""text"" class=""std-form-input"" placeholder=""Auhthor's First Name"" id=""input-first-author-fn--journal""/>
                    <input type=""text"" class=""std-form-input"" placeholder=""Auhthor's Last Name"" id=""input-first-author-ln--journal"" />
                </div>
                <div class=""add-author-wrapper"">
                    <span class=""more-icon std-icon"" id=""addAuthor""></span> <p class=""std-text-quiet add-author"">Add another author</p>
                </div>
            </div>

            <input type=""text"" class=""std-form-input"" placeholder=""Title of Article"" id=""input-source-art-title--journal"" />
            <input type=""text"" class=""std-form-input"" placeholder=""Title of Journal"" id=""input-source-jour-title--journal""/>
            <input type=""text"" class=""std-form-input"" ");
            WriteLiteral(@"placeholder=""Voulme"" id=""input-source-volume--journal"" />
            <input type=""text"" class=""std-form-input"" placeholder=""Issue Number"" id=""input-source-issueNum-journal"" />
            <input type=""text"" class=""std-form-input"" placeholder=""Month Published"" id=""input-source-monthPub--journal""/>
            <input type=""text"" class=""std-form-input"" placeholder=""Year Published"" id=""input-source-yearPub--journal""/>
            <input type=""text"" class=""std-form-input"" placeholder=""Pages Used""  id=""input-source-Pages--journal"" />
            <input type=""text"" class=""std-form-input"" placeholder=""DOI or URL"" id=""input-source-doi--journal"" />
        </div>

");
            WriteLiteral(@"    <div class=""citation-form-wrapper citation-form_mla-website"" id=""mla-wrapper-website"">
        <div class=""authors-wrapper"">
            <div class=""single-author-wrap"">
                <input type=""text"" class=""std-form-input"" placeholder=""Auhthor's First Name"" id=""input-first-author-fn--website""/>
                <input type=""text"" class=""std-form-input"" placeholder=""Auhthor's Last Name"" id=""input-first-author-ln--website""/>
            </div>
            <div class=""add-author-wrapper"">
                <span class=""more-icon std-icon"" id=""addAuthor""></span> <p class=""std-text-quiet add-author"">Add another author</p>
            </div>
        </div>

        <input type=""text"" class=""std-form-input"" placeholder=""Page Title"" id=""input-pageTitle--website"" />
        <input type=""text"" class=""std-form-input"" placeholder=""Website title (not URL)"" id=""input-webTitle--website""/>
        <input type=""text"" class=""std-form-input"" placeholder=""Day Published"" id=""input-dayPub--website""/>
        <i");
            WriteLiteral(@"nput type=""text"" class=""std-form-input"" placeholder=""Month Published"" id=""input-monthPub--website""/>
        <input type=""text"" class=""std-form-input"" placeholder=""Year Published"" id=""input-yearPub--website""/>
        <input type=""text"" class=""std-form-input"" placeholder=""Source URL"" id=""input-sourceUrl--website""/>

    </div>

        <div class=""botton-wrapper citing-buttons"">
            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0cf01b2b20ea25a47dda67aff8820900bf7e81e610726", async() => {
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
            <button class=""reset-button"" onclick=""citeSource()""> <span class=""read-start std-icon cite-button""></span>CITE</button>
        </div>
    </section>

    <div class=""reading-result-wrapper"">
        <h3 class=""std-h3 h3-reader-title"">Citation: </h3>
        <div class=""reading-results-img citation-results-img""></div>
        <div class=""std-p reading-time-result"" id=""citation-time-result"">
        </div>
    </div>
</div>

");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n    <script src=\"/js/citation-machine.js\"></script>\r\n");
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