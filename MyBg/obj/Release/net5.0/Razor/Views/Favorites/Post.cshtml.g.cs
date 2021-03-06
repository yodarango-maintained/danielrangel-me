#pragma checksum "C:\Users\danielr\source\repos\Mine\MyBg\MyBg\Views\Favorites\Post.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7adfd3fbbe9b21bc208264c001c4a1e695a17d37"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Favorites_Post), @"mvc.1.0.view", @"/Views/Favorites/Post.cshtml")]
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
#line 1 "C:\Users\danielr\source\repos\Mine\MyBg\MyBg\Views\_ViewImports.cshtml"
using MyBg;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\danielr\source\repos\Mine\MyBg\MyBg\Views\_ViewImports.cshtml"
using MyBg.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7adfd3fbbe9b21bc208264c001c4a1e695a17d37", @"/Views/Favorites/Post.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bc5dbcb0184da424cb338a8e1ab3a5366afac376", @"/Views/_ViewImports.cshtml")]
    public class Views_Favorites_Post : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<MyBg.Models.FavoriteModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/sermons.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Favorites", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("std-button back-to-all"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Posts", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("category-tag"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/handlePostInteraction.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\danielr\source\repos\Mine\MyBg\MyBg\Views\Favorites\Post.cshtml"
  
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

    ViewData["MenuBtnTitle"] = "Favorite";

    string postTorender = ViewData["Post"].ToString();

#line default
#line hidden
#nullable disable
            DefineSection("Styles", async() => {
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "7adfd3fbbe9b21bc208264c001c4a1e695a17d376890", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
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
            WriteLiteral("<div class=\"main-wrapper_favorite-single\">\r\n    <div class=\"post-top-single-wrapper\">\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7adfd3fbbe9b21bc208264c001c4a1e695a17d378225", async() => {
                WriteLiteral("???? BACK TO ALL");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
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
#line 40 "C:\Users\danielr\source\repos\Mine\MyBg\MyBg\Views\Favorites\Post.cshtml"
                 if (!String.IsNullOrEmpty(Model.Categories))
                {
                    string[] tags = Model.Categories.Split(" ");
                    foreach (string tag in tags)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7adfd3fbbe9b21bc208264c001c4a1e695a17d3710263", async() => {
                WriteLiteral("#");
#nullable restore
#line 45 "C:\Users\danielr\source\repos\Mine\MyBg\MyBg\Views\Favorites\Post.cshtml"
                                                                                                           Write(tag);

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-tag", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 45 "C:\Users\danielr\source\repos\Mine\MyBg\MyBg\Views\Favorites\Post.cshtml"
                                                                        WriteLiteral(tag);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["tag"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-tag", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["tag"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 46 "C:\Users\danielr\source\repos\Mine\MyBg\MyBg\Views\Favorites\Post.cshtml"
                    }
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </div>\r\n        </div>\r\n\r\n        <h3 class=\"std-h3\">Did you like this content?</h3>\r\n        <section class=\"buttons-wrapper\">\r\n\r\n            <button");
            BeginWriteAttribute("onclick", " onclick=\"", 1925, "\"", 1985, 6);
            WriteAttributeValue("", 1935, "handleLike(\'", 1935, 12, true);
#nullable restore
#line 54 "C:\Users\danielr\source\repos\Mine\MyBg\MyBg\Views\Favorites\Post.cshtml"
WriteAttributeValue("", 1947, Model.ID, 1947, 9, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1956, "\',", 1956, 2, true);
            WriteAttributeValue(" ", 1958, "\'Favorites\',", 1959, 13, true);
#nullable restore
#line 54 "C:\Users\danielr\source\repos\Mine\MyBg\MyBg\Views\Favorites\Post.cshtml"
WriteAttributeValue(" ", 1971, Model.Likes, 1972, 12, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1984, ")", 1984, 1, true);
            EndWriteAttribute();
            WriteLiteral(" class=\"std-button std-button-reactions\" id=\"love-button\"> <span class=\"love-btn\"></span>");
#nullable restore
#line 54 "C:\Users\danielr\source\repos\Mine\MyBg\MyBg\Views\Favorites\Post.cshtml"
                                                                                                                                                                    Write(Model.Likes);

#line default
#line hidden
#nullable disable
            WriteLiteral("</button>\r\n            <button");
            BeginWriteAttribute("onclick", " onclick=\"", 2117, "\"", 2178, 5);
            WriteAttributeValue("", 2127, "handleShare(\'", 2127, 13, true);
#nullable restore
#line 55 "C:\Users\danielr\source\repos\Mine\MyBg\MyBg\Views\Favorites\Post.cshtml"
WriteAttributeValue("", 2140, Model.ID, 2140, 9, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2149, "\',\'Favorites\',", 2149, 14, true);
#nullable restore
#line 55 "C:\Users\danielr\source\repos\Mine\MyBg\MyBg\Views\Favorites\Post.cshtml"
WriteAttributeValue(" ", 2163, Model.Shares, 2164, 13, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2177, ")", 2177, 1, true);
            EndWriteAttribute();
            WriteLiteral(" class=\"std-button std-button-reactions\" id=\"share-button\"><span class=\"share-btn\"></span>");
#nullable restore
#line 55 "C:\Users\danielr\source\repos\Mine\MyBg\MyBg\Views\Favorites\Post.cshtml"
                                                                                                                                                                      Write(Model.Shares);

#line default
#line hidden
#nullable disable
            WriteLiteral("</button>\r\n        </section>\r\n\r\n");
            WriteLiteral("\r\n");
            WriteLiteral("    </div>\r\n    <div class=\"std-medium-spacer\" data-id=\"");
#nullable restore
#line 62 "C:\Users\danielr\source\repos\Mine\MyBg\MyBg\Views\Favorites\Post.cshtml"
                                       Write(Model.ID);

#line default
#line hidden
#nullable disable
            WriteLiteral("\" data-route=\"favorite\" id=\"post-wrapper\">    </div>\r\n        ");
#nullable restore
#line 63 "C:\Users\danielr\source\repos\Mine\MyBg\MyBg\Views\Favorites\Post.cshtml"
   Write(await Html.PartialAsync("~/Views/Shared/Sermons/" + postTorender + ".cshtml"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n</div>\r\n\r\n\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7adfd3fbbe9b21bc208264c001c4a1e695a17d3716908", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<MyBg.Models.FavoriteModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
