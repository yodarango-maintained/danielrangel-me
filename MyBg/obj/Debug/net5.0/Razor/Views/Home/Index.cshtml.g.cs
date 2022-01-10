#pragma checksum "C:\Users\danielr\source\repos\MyBg\MyBg\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d123ed3d61c81ddf0701fa862eaaf0af563e70e1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d123ed3d61c81ddf0701fa862eaaf0af563e70e1", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bc5dbcb0184da424cb338a8e1ab3a5366afac376", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/images/logo.jfif"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("intro-logo"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\danielr\source\repos\MyBg\MyBg\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Welcome to My Blog";
    UserAdminModel admin = ViewData["User"] as UserAdminModel;
    string followersCount = ViewData["FollowerCount"].ToString();
    IEnumerable<PostsViewModel> posts = ViewData["Posts"] as IEnumerable<PostsViewModel>;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"main-wrapper main-wrapper_index\">\r\n    <section class=\"indexp-upper-half\">\r\n        <h1 class=\"std-h1 intro-title\">\r\n            MY TITLE\r\n        </h1>\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "d123ed3d61c81ddf0701fa862eaaf0af563e70e14346", async() => {
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
            WriteLiteral("\r\n        <p class=\"std-p intro-text\">");
#nullable restore
#line 15 "C:\Users\danielr\source\repos\MyBg\MyBg\Views\Home\Index.cshtml"
                               Write(admin.About_Me);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n\r\n        <div class=\"social-media-section\">\r\n            <h3 class=\"std-h3 sm-section-title\">Find Me On</h3>\r\n            <div class=\"sm-links-wrapper\">\r\n                <a");
            BeginWriteAttribute("href", " href=\"", 774, "\"", 802, 1);
#nullable restore
#line 20 "C:\Users\danielr\source\repos\MyBg\MyBg\Views\Home\Index.cshtml"
WriteAttributeValue("", 781, admin.YouVersion_Url, 781, 21, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"sm-link youversion\">\r\n                    <span class=\"youversion-icon\"></span>\r\n                </a>\r\n                <a");
            BeginWriteAttribute("href", " href=\"", 932, "\"", 959, 1);
#nullable restore
#line 23 "C:\Users\danielr\source\repos\MyBg\MyBg\Views\Home\Index.cshtml"
WriteAttributeValue("", 939, admin.Instagram_Url, 939, 20, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"sm-link insta\">\r\n                    <span class=\"insta-icon\"></span>\r\n                </a>\r\n                <a");
            BeginWriteAttribute("href", " href=\"", 1079, "\"", 1103, 1);
#nullable restore
#line 26 "C:\Users\danielr\source\repos\MyBg\MyBg\Views\Home\Index.cshtml"
WriteAttributeValue("", 1086, admin.Github_Url, 1086, 17, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"sm-link github\">\r\n                    <span class=\"github-icon\"></span>\r\n                </a>\r\n                <a");
            BeginWriteAttribute("href", " href=\"", 1225, "\"", 1252, 1);
#nullable restore
#line 29 "C:\Users\danielr\source\repos\MyBg\MyBg\Views\Home\Index.cshtml"
WriteAttributeValue("", 1232, admin.Goodreads_url, 1232, 20, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"sm-link goodreads\">\r\n                    <span class=\"goodreads-icon\"></span>\r\n                </a>\r\n                <a");
            BeginWriteAttribute("href", " href=\"", 1380, "\"", 1405, 1);
#nullable restore
#line 32 "C:\Users\danielr\source\repos\MyBg\MyBg\Views\Home\Index.cshtml"
WriteAttributeValue("", 1387, admin.Youtube_url, 1387, 18, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"sm-link youtube\">\r\n                    <span class=\"youtube-icon\"></span>\r\n                </a>\r\n                <a");
            BeginWriteAttribute("href", " href=\"", 1529, "\"", 1553, 1);
#nullable restore
#line 35 "C:\Users\danielr\source\repos\MyBg\MyBg\Views\Home\Index.cshtml"
WriteAttributeValue("", 1536, admin.Reddit_Url, 1536, 17, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"sm-link reddit\">\r\n                    <span class=\"reddit-icon\"></span>\r\n                </a>\r\n                <a");
            BeginWriteAttribute("href", " href=\"", 1675, "\"", 1700, 1);
#nullable restore
#line 38 "C:\Users\danielr\source\repos\MyBg\MyBg\Views\Home\Index.cshtml"
WriteAttributeValue("", 1682, admin.Twitter_url, 1682, 18, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"sm-link twitter\">\r\n                    <span class=\"twitter-icon\"></span>\r\n                </a>\r\n                <a");
            BeginWriteAttribute("href", " href=\"", 1824, "\"", 1848, 1);
#nullable restore
#line 41 "C:\Users\danielr\source\repos\MyBg\MyBg\Views\Home\Index.cshtml"
WriteAttributeValue("", 1831, admin.Strava_url, 1831, 17, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"sm-link strava\">\r\n                    <span class=\"strava-icon\"></span>\r\n                </a>\r\n                <a");
            BeginWriteAttribute("href", " href=\"", 1970, "\"", 1996, 1);
#nullable restore
#line 44 "C:\Users\danielr\source\repos\MyBg\MyBg\Views\Home\Index.cshtml"
WriteAttributeValue("", 1977, admin.LinkedIn_url, 1977, 19, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"sm-link linkedin\">\r\n                    <span class=\"linkedin-icon\"></span>\r\n                </a>\r\n                <a");
            BeginWriteAttribute("href", " href=\"", 2122, "\"", 2147, 1);
#nullable restore
#line 47 "C:\Users\danielr\source\repos\MyBg\MyBg\Views\Home\Index.cshtml"
WriteAttributeValue("", 2129, admin.Discord_url, 2129, 18, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"sm-link discord\">\r\n                    <span class=\"discord-icon\"></span>\r\n                </a>\r\n                <a");
            BeginWriteAttribute("href", " href=\"", 2271, "\"", 2296, 1);
#nullable restore
#line 50 "C:\Users\danielr\source\repos\MyBg\MyBg\Views\Home\Index.cshtml"
WriteAttributeValue("", 2278, admin.Codepen_url, 2278, 18, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" class=""sm-link codepen"">
                    <span class=""codepen-icon""></span>
                </a>
            </div>
        </div>
    </section>

    <section class=""indexp-lower-half"">
        <h2 class=""std-h2 most-recent-h2"">MOST RECENT</h2>
        <section class=""posts-wrapper"">
");
#nullable restore
#line 60 "C:\Users\danielr\source\repos\MyBg\MyBg\Views\Home\Index.cshtml"
             foreach (PostsViewModel post in posts)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"most-recent-post-wrapper\">\r\n                    <img");
            BeginWriteAttribute("src", " src=\"", 2746, "\"", 2752, 0);
            EndWriteAttribute();
            WriteLiteral(" class=\"most-recent-post_thumbnail\"/>\r\n                    <h3 class=\"std-h3 most-recent-post_title\" >");
#nullable restore
#line 64 "C:\Users\danielr\source\repos\MyBg\MyBg\Views\Home\Index.cshtml"
                                                          Write(post.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n                    <p class=\"std-text-quiet most-recent-post_date\">");
#nullable restore
#line 65 "C:\Users\danielr\source\repos\MyBg\MyBg\Views\Home\Index.cshtml"
                                                               Write(post.DatePosted);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                    <div class=\"tag-footer\">\r\n\r\n");
#nullable restore
#line 68 "C:\Users\danielr\source\repos\MyBg\MyBg\Views\Home\Index.cshtml"
                         if (post.PostType == "Favorite")
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <span class=\"std-icon  type_favorite\">favorite</span>\r\n");
#nullable restore
#line 71 "C:\Users\danielr\source\repos\MyBg\MyBg\Views\Home\Index.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 73 "C:\Users\danielr\source\repos\MyBg\MyBg\Views\Home\Index.cshtml"
                         if (post.PostType == "Blog")
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <span class=\"std-icon type_blog\">blog</span>\r\n");
#nullable restore
#line 76 "C:\Users\danielr\source\repos\MyBg\MyBg\Views\Home\Index.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <div class=\"category-wrapper\">\r\n");
#nullable restore
#line 78 "C:\Users\danielr\source\repos\MyBg\MyBg\Views\Home\Index.cshtml"
                             if (!String.IsNullOrEmpty(post.Categories))
                            {
                                string[] tags = post.Categories.Split(" ");
                                foreach (string tag in tags)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <a");
            BeginWriteAttribute("href", " href=\"", 3765, "\"", 3800, 2);
            WriteAttributeValue("", 3772, "/posts/", 3772, 7, true);
#nullable restore
#line 83 "C:\Users\danielr\source\repos\MyBg\MyBg\Views\Home\Index.cshtml"
WriteAttributeValue("", 3779, tag.Replace("#", ""), 3779, 21, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"category-tag\">");
#nullable restore
#line 83 "C:\Users\danielr\source\repos\MyBg\MyBg\Views\Home\Index.cshtml"
                                                                                           Write(tag);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n");
#nullable restore
#line 84 "C:\Users\danielr\source\repos\MyBg\MyBg\Views\Home\Index.cshtml"
                                }

                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        </div>\r\n                    </div>\r\n\r\n                </div>\r\n");
#nullable restore
#line 91 "C:\Users\danielr\source\repos\MyBg\MyBg\Views\Home\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </section>\r\n    </section>\r\n\r\n</div>\r\n");
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
