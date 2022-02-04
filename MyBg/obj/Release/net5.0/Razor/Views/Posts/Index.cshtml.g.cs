#pragma checksum "C:\Users\danielr\source\repos\MyBg\MyBg\Views\Posts\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "26e2264b666ba52b9872d9a606138ba45ca91d02"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Posts_Index), @"mvc.1.0.view", @"/Views/Posts/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"26e2264b666ba52b9872d9a606138ba45ca91d02", @"/Views/Posts/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bc5dbcb0184da424cb338a8e1ab3a5366afac376", @"/Views/_ViewImports.cshtml")]
    public class Views_Posts_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<MyBg.Models.PostsViewModel>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Posts", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("category-tag"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n");
            WriteLiteral("\r\n");
#nullable restore
#line 4 "C:\Users\danielr\source\repos\MyBg\MyBg\Views\Posts\Index.cshtml"
  
    // metatags
    ViewData["MetaDescription"] = "Toughts, tips, tech, tools, and a little bit of everything to help your ministry and enrich your Christian walk by Daniel Rangel";

    ViewData["OGTitle"] = "Tools, Tips, Thoughts, and Tech to help your Christian walk";
    ViewData["OGUrl"] = "http://danielrangel.me/posts";
    ViewData["OGImage"] = "";
    ViewData["OGType"] = "website";
    ViewData["OGDescription"] = "Toughts, tips, tech, tools, and a little bit of everything to help your ministry and enrich your Christian walk by Daniel Rangel";
    ViewData["OGSiteName"] = "Daniel Rangel";

    ViewData["TWTitle"] = "All Posts";
    ViewData["TWDescription"] = "Toughts, tips, tech, tools, and a little bit of everything to help your ministry and enrich your Christian walk by Daniel Rangel";
    ViewData["TWImage"] = "";
    ViewData["TWSite"] = "@Yodarango";
    ViewData["TWCreator"] = "@Yodarango";

    ViewData["Title"] = "Tips, Thoughts, and Tech to help your Christian walk";

    ViewData["MenuBtnTitle"] = "";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"main-wrapper main-wrapper_favorite\">\r\n\r\n    <section class=\"post-title-wrapper wrapper-favorite\">\r\n        <h1 class=\"std-h1 favorites-title\">");
#nullable restore
#line 29 "C:\Users\danielr\source\repos\MyBg\MyBg\Views\Posts\Index.cshtml"
                                      Write(ViewData["Tag"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n    </section>\r\n\r\n");
#nullable restore
#line 32 "C:\Users\danielr\source\repos\MyBg\MyBg\Views\Posts\Index.cshtml"
     foreach (PostsViewModel post in Model)
    {
        if (post.PostType == "Favorite")
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"favorite-post-wrapper\"");
            BeginWriteAttribute("onclick", " onclick=\"", 1462, "\"", 1516, 6);
            WriteAttributeValue("", 1472, "redirectToPost(\'", 1472, 16, true);
#nullable restore
#line 36 "C:\Users\danielr\source\repos\MyBg\MyBg\Views\Posts\Index.cshtml"
WriteAttributeValue("", 1488, post.ID, 1488, 8, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1496, "\',", 1496, 2, true);
            WriteAttributeValue(" ", 1498, "\'", 1499, 2, true);
#nullable restore
#line 36 "C:\Users\danielr\source\repos\MyBg\MyBg\Views\Posts\Index.cshtml"
WriteAttributeValue("", 1500, post.PostType, 1500, 14, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1514, "\')", 1514, 2, true);
            EndWriteAttribute();
            WriteLiteral(">\r\n                ");
#nullable restore
#line 37 "C:\Users\danielr\source\repos\MyBg\MyBg\Views\Posts\Index.cshtml"
           Write(await Html.PartialAsync("_Carrousel", post));

#line default
#line hidden
#nullable disable
            WriteLiteral(";\r\n                <div class=\"std-blurr-layer\"></div>\r\n                <aside class=\"favorite-post-info-wrapper\">\r\n                    <div>\r\n                        <h3 class=\"std-h3 header-h3--favorite\">");
#nullable restore
#line 41 "C:\Users\danielr\source\repos\MyBg\MyBg\Views\Posts\Index.cshtml"
                                                          Write(post.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n                        <p class=\"std-text-quiet quiet-post-info\">");
#nullable restore
#line 42 "C:\Users\danielr\source\repos\MyBg\MyBg\Views\Posts\Index.cshtml"
                                                             Write(post.DatePosted);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n\r\n                        <div class=\"tag-footer\">\r\n\r\n                            <span class=\"post-type type_favorite\"></span>\r\n\r\n                            <div class=\"category-wrapper\">\r\n");
#nullable restore
#line 49 "C:\Users\danielr\source\repos\MyBg\MyBg\Views\Posts\Index.cshtml"
                                 if (!String.IsNullOrEmpty(post.Categories))
                                {
                                    string[] tags = post.Categories.Split(" ");
                                    foreach (string tag in tags)
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "26e2264b666ba52b9872d9a606138ba45ca91d028689", async() => {
#nullable restore
#line 54 "C:\Users\danielr\source\repos\MyBg\MyBg\Views\Posts\Index.cshtml"
                                                                                                                          Write(tag);

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-tag", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 54 "C:\Users\danielr\source\repos\MyBg\MyBg\Views\Posts\Index.cshtml"
                                                                                        WriteLiteral(tag);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["tag"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-tag", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["tag"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 55 "C:\Users\danielr\source\repos\MyBg\MyBg\Views\Posts\Index.cshtml"
                                    }

                                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                            </div>\r\n                        </div>\r\n                    </div>\r\n");
            WriteLiteral("                </aside>\r\n            </div>\r\n");
#nullable restore
#line 66 "C:\Users\danielr\source\repos\MyBg\MyBg\Views\Posts\Index.cshtml"
        }
        else if (post.PostType == "Article")
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"blog-post-wrapper by-tag-blog\"");
            BeginWriteAttribute("onclick", " onclick=\"", 2999, "\"", 3053, 6);
            WriteAttributeValue("", 3009, "redirectToPost(\'", 3009, 16, true);
#nullable restore
#line 69 "C:\Users\danielr\source\repos\MyBg\MyBg\Views\Posts\Index.cshtml"
WriteAttributeValue("", 3025, post.ID, 3025, 8, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3033, "\',", 3033, 2, true);
            WriteAttributeValue(" ", 3035, "\'", 3036, 2, true);
#nullable restore
#line 69 "C:\Users\danielr\source\repos\MyBg\MyBg\Views\Posts\Index.cshtml"
WriteAttributeValue("", 3037, post.PostType, 3037, 14, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3051, "\')", 3051, 2, true);
            EndWriteAttribute();
            WriteLiteral(">\r\n                ");
#nullable restore
#line 70 "C:\Users\danielr\source\repos\MyBg\MyBg\Views\Posts\Index.cshtml"
           Write(await Html.PartialAsync("_Carrousel_Blog", post));

#line default
#line hidden
#nullable disable
            WriteLiteral(";\r\n                <div class=\"std-blurr-layer blog-blurr-layer\"></div>\r\n                <aside class=\"blog-post-info-wrapper\">\r\n                    <div>\r\n                        <h3 class=\"std-h3 header-h3--blog\">");
#nullable restore
#line 74 "C:\Users\danielr\source\repos\MyBg\MyBg\Views\Posts\Index.cshtml"
                                                      Write(post.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n                        <p class=\"std-text-quiet quiet-post-info\">");
#nullable restore
#line 75 "C:\Users\danielr\source\repos\MyBg\MyBg\Views\Posts\Index.cshtml"
                                                             Write(post.DatePosted);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n\r\n                        <div class=\"tag-footer\">\r\n\r\n                            <span class=\"post-type type_blog\"></span>\r\n\r\n                            <div class=\"category-wrapper\">\r\n");
#nullable restore
#line 82 "C:\Users\danielr\source\repos\MyBg\MyBg\Views\Posts\Index.cshtml"
                                 if (!String.IsNullOrEmpty(post.Categories))
                                {
                                    string[] tags = post.Categories.Split(" ");
                                    foreach (string tag in tags)
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "26e2264b666ba52b9872d9a606138ba45ca91d0214792", async() => {
#nullable restore
#line 87 "C:\Users\danielr\source\repos\MyBg\MyBg\Views\Posts\Index.cshtml"
                                                                                                                          Write(tag);

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-tag", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 87 "C:\Users\danielr\source\repos\MyBg\MyBg\Views\Posts\Index.cshtml"
                                                                                        WriteLiteral(tag);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["tag"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-tag", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["tag"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 88 "C:\Users\danielr\source\repos\MyBg\MyBg\Views\Posts\Index.cshtml"
                                    }

                                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                            </div>\r\n                        </div>\r\n                    </div>\r\n                    <p class=\"std-p std-p_blog-desc\">\r\n                        ");
#nullable restore
#line 95 "C:\Users\danielr\source\repos\MyBg\MyBg\Views\Posts\Index.cshtml"
                   Write(post.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </p>\r\n                </aside>\r\n            </div>\r\n");
#nullable restore
#line 99 "C:\Users\danielr\source\repos\MyBg\MyBg\Views\Posts\Index.cshtml"
        }
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<MyBg.Models.PostsViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591