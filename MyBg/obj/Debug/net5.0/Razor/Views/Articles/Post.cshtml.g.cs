#pragma checksum "C:\Users\danielr\source\repos\MyBg\MyBg\Views\Articles\Post.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cc030542a64d91770021bc7e0736764e3c468d9f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Articles_Post), @"mvc.1.0.view", @"/Views/Articles/Post.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cc030542a64d91770021bc7e0736764e3c468d9f", @"/Views/Articles/Post.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bc5dbcb0184da424cb338a8e1ab3a5366afac376", @"/Views/_ViewImports.cshtml")]
    public class Views_Articles_Post : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<MyBg.Models.ArticleModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Articles", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("std-button back-to-all"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/handlePostInteraction.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\danielr\source\repos\MyBg\MyBg\Views\Articles\Post.cshtml"
  
    // metatags
    ViewData["MetaDescription"] = Model.Description;

    ViewData["OGTitle"] = Model.Title;
    ViewData["OGUrl"] = $"http://danielrangel.me/{Model.ID}";
    ViewData["OGImage"] = Model.Tumbnails;
    ViewData["OGType"] = "website";
    ViewData["OGDescription"] = Model.Description;
    ViewData["OGSiteName"] = "Daniel Rangel";

    ViewData["TWTitle"] = Model.Title;
    ViewData["TWDescription"] = Model.Description;
    ViewData["TWImage"] = Model.Tumbnails;
    ViewData["TWSite"] = "@Yodarango";
    ViewData["TWCreator"] = "@Yodarango";

    ViewData["Title"] = Model.Title;

    ViewData["MenuBtnTitle"] = "Article";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"main-wrapper_favorite-single\">\r\n    <div class=\"post-top-single-wrapper\">\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "cc030542a64d91770021bc7e0736764e3c468d9f5449", async() => {
                WriteLiteral("???? BACK TO ALL");
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
            WriteLiteral("\r\n\r\n");
            WriteLiteral("\r\n        <div class=\"tag-footer\">\r\n            <div class=\"category-wrapper category-wrapper--single--post\">\r\n");
#nullable restore
#line 35 "C:\Users\danielr\source\repos\MyBg\MyBg\Views\Articles\Post.cshtml"
                 if (!String.IsNullOrEmpty(Model.Categories))
                {
                    string[] tags = Model.Categories.Split(" ");
                    foreach (string tag in tags)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <span class=\"category-tag\">");
#nullable restore
#line 40 "C:\Users\danielr\source\repos\MyBg\MyBg\Views\Articles\Post.cshtml"
                                              Write(tag);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n");
#nullable restore
#line 41 "C:\Users\danielr\source\repos\MyBg\MyBg\Views\Articles\Post.cshtml"
                    }
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </div>\r\n        </div>\r\n\r\n        <h3 class=\"std-h3\">Did you like this content?</h3>\r\n        <section class=\"buttons-wrapper\">\r\n\r\n            <button");
            BeginWriteAttribute("onclick", " onclick=\"", 1728, "\"", 1784, 6);
            WriteAttributeValue("", 1738, "handleLike(\'", 1738, 12, true);
#nullable restore
#line 49 "C:\Users\danielr\source\repos\MyBg\MyBg\Views\Articles\Post.cshtml"
WriteAttributeValue("", 1750, Model.ID, 1750, 9, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1759, "\',", 1759, 2, true);
            WriteAttributeValue(" ", 1761, "\'Blogs\',", 1762, 9, true);
#nullable restore
#line 49 "C:\Users\danielr\source\repos\MyBg\MyBg\Views\Articles\Post.cshtml"
WriteAttributeValue(" ", 1770, Model.Likes, 1771, 12, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1783, ")", 1783, 1, true);
            EndWriteAttribute();
            WriteLiteral(" class=\"std-button std-button-reactions\" id=\"love-button\"> <span class=\"love-btn\"></span>");
#nullable restore
#line 49 "C:\Users\danielr\source\repos\MyBg\MyBg\Views\Articles\Post.cshtml"
                                                                                                                                                                Write(Model.Likes);

#line default
#line hidden
#nullable disable
            WriteLiteral("</button>\r\n            <button");
            BeginWriteAttribute("onclick", " onclick=\"", 1916, "\"", 1973, 5);
            WriteAttributeValue("", 1926, "handleShare(\'", 1926, 13, true);
#nullable restore
#line 50 "C:\Users\danielr\source\repos\MyBg\MyBg\Views\Articles\Post.cshtml"
WriteAttributeValue("", 1939, Model.ID, 1939, 9, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1948, "\',\'Blogs\',", 1948, 10, true);
#nullable restore
#line 50 "C:\Users\danielr\source\repos\MyBg\MyBg\Views\Articles\Post.cshtml"
WriteAttributeValue(" ", 1958, Model.Shares, 1959, 13, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1972, ")", 1972, 1, true);
            EndWriteAttribute();
            WriteLiteral(" class=\"std-button std-button-reactions\" id=\"share-button\"><span class=\"share-btn\"></span>");
#nullable restore
#line 50 "C:\Users\danielr\source\repos\MyBg\MyBg\Views\Articles\Post.cshtml"
                                                                                                                                                                  Write(Model.Shares);

#line default
#line hidden
#nullable disable
            WriteLiteral("</button>\r\n        </section>\r\n\r\n");
            WriteLiteral("\r\n");
            WriteLiteral("    </div>\r\n    <div class=\"std-medium-spacer\" data-id=\"");
#nullable restore
#line 57 "C:\Users\danielr\source\repos\MyBg\MyBg\Views\Articles\Post.cshtml"
                                       Write(Model.ID);

#line default
#line hidden
#nullable disable
            WriteLiteral("\" data-route=\"article\" id=\"post-wrapper\"></div>\r\n    ");
#nullable restore
#line 58 "C:\Users\danielr\source\repos\MyBg\MyBg\Views\Articles\Post.cshtml"
Write(Html.Raw(Model.HTML));

#line default
#line hidden
#nullable disable
            WriteLiteral(";\r\n\r\n</div>\r\n\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "cc030542a64d91770021bc7e0736764e3c468d9f11519", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
            }
            );
            WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<MyBg.Models.ArticleModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
