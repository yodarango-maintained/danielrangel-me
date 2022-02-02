#pragma checksum "C:\Users\danielr\source\repos\MyBg\MyBg\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2412eadcf8778941a096b85d79cd913bfbd6e401"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2412eadcf8778941a096b85d79cd913bfbd6e401", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bc5dbcb0184da424cb338a8e1ab3a5366afac376", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/images/logo.jfif"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("intro-logo"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Posts", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("category-tag"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#nullable restore
#line 2 "C:\Users\danielr\source\repos\MyBg\MyBg\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Welcome to My Blog";
    UserAdminModel admin = ViewData["User"] as UserAdminModel;
    string followersCount = ViewData["FollowerCount"].ToString();
    IEnumerable<PostsViewModel> posts = ViewData["Posts"] as IEnumerable<PostsViewModel>;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"main-wrapper main-wrapper_index\">\r\n");
#nullable restore
#line 10 "C:\Users\danielr\source\repos\MyBg\MyBg\Views\Home\Index.cshtml"
     if ((bool)ViewData["SubsMessage"] == true)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"        <div id=""menu-wrapper"" class=""color-theme-wrapper color-theme-wrapper--open"">
            <h3 class=""std-h3 subscribe-h3"">Thank you for subscribing!</h3>
            <button type=""submit"" class=""std-button close-button"" onclick=""closeNotification()"">Close</button>
        </div>
");
#nullable restore
#line 16 "C:\Users\danielr\source\repos\MyBg\MyBg\Views\Home\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    <section class=\"indexp-upper-half\">\r\n        <h1 class=\"std-h1 intro-title\">\r\n            MY TITLE\r\n        </h1>\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "2412eadcf8778941a096b85d79cd913bfbd6e4016158", async() => {
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
#line 23 "C:\Users\danielr\source\repos\MyBg\MyBg\Views\Home\Index.cshtml"
                               Write(admin.About_Me);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</p>
        <button class=""std-button subscribe-button"" id=""subscribe-button"" onclick=""handleSubscribe()"">Subscribe</button>

        <div class=""social-media-section"">
            <h3 class=""std-h3 sm-section-title"">Find Me On</h3>
            <div class=""sm-links-wrapper"">
                <a");
            BeginWriteAttribute("href", " href=\"", 1253, "\"", 1281, 1);
#nullable restore
#line 29 "C:\Users\danielr\source\repos\MyBg\MyBg\Views\Home\Index.cshtml"
WriteAttributeValue("", 1260, admin.YouVersion_Url, 1260, 21, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"sm-link youversion\">\r\n                    <span class=\"youversion-icon\"></span>\r\n                </a>\r\n                <a");
            BeginWriteAttribute("href", " href=\"", 1411, "\"", 1438, 1);
#nullable restore
#line 32 "C:\Users\danielr\source\repos\MyBg\MyBg\Views\Home\Index.cshtml"
WriteAttributeValue("", 1418, admin.Instagram_Url, 1418, 20, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"sm-link insta\">\r\n                    <span class=\"insta-icon\"></span>\r\n                </a>\r\n                <a");
            BeginWriteAttribute("href", " href=\"", 1558, "\"", 1582, 1);
#nullable restore
#line 35 "C:\Users\danielr\source\repos\MyBg\MyBg\Views\Home\Index.cshtml"
WriteAttributeValue("", 1565, admin.Github_Url, 1565, 17, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"sm-link github\">\r\n                    <span class=\"github-icon\"></span>\r\n                </a>\r\n                <a");
            BeginWriteAttribute("href", " href=\"", 1704, "\"", 1731, 1);
#nullable restore
#line 38 "C:\Users\danielr\source\repos\MyBg\MyBg\Views\Home\Index.cshtml"
WriteAttributeValue("", 1711, admin.Goodreads_url, 1711, 20, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"sm-link goodreads\">\r\n                    <span class=\"goodreads-icon\"></span>\r\n                </a>\r\n                <a");
            BeginWriteAttribute("href", " href=\"", 1859, "\"", 1884, 1);
#nullable restore
#line 41 "C:\Users\danielr\source\repos\MyBg\MyBg\Views\Home\Index.cshtml"
WriteAttributeValue("", 1866, admin.Youtube_url, 1866, 18, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"sm-link youtube\">\r\n                    <span class=\"youtube-icon\"></span>\r\n                </a>\r\n                <a");
            BeginWriteAttribute("href", " href=\"", 2008, "\"", 2032, 1);
#nullable restore
#line 44 "C:\Users\danielr\source\repos\MyBg\MyBg\Views\Home\Index.cshtml"
WriteAttributeValue("", 2015, admin.Reddit_Url, 2015, 17, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"sm-link reddit\">\r\n                    <span class=\"reddit-icon\"></span>\r\n                </a>\r\n                <a");
            BeginWriteAttribute("href", " href=\"", 2154, "\"", 2179, 1);
#nullable restore
#line 47 "C:\Users\danielr\source\repos\MyBg\MyBg\Views\Home\Index.cshtml"
WriteAttributeValue("", 2161, admin.Twitter_url, 2161, 18, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"sm-link twitter\">\r\n                    <span class=\"twitter-icon\"></span>\r\n                </a>\r\n                <a");
            BeginWriteAttribute("href", " href=\"", 2303, "\"", 2327, 1);
#nullable restore
#line 50 "C:\Users\danielr\source\repos\MyBg\MyBg\Views\Home\Index.cshtml"
WriteAttributeValue("", 2310, admin.Strava_url, 2310, 17, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"sm-link strava\">\r\n                    <span class=\"strava-icon\"></span>\r\n                </a>\r\n                <a");
            BeginWriteAttribute("href", " href=\"", 2449, "\"", 2475, 1);
#nullable restore
#line 53 "C:\Users\danielr\source\repos\MyBg\MyBg\Views\Home\Index.cshtml"
WriteAttributeValue("", 2456, admin.LinkedIn_url, 2456, 19, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"sm-link linkedin\">\r\n                    <span class=\"linkedin-icon\"></span>\r\n                </a>\r\n                <a");
            BeginWriteAttribute("href", " href=\"", 2601, "\"", 2626, 1);
#nullable restore
#line 56 "C:\Users\danielr\source\repos\MyBg\MyBg\Views\Home\Index.cshtml"
WriteAttributeValue("", 2608, admin.Discord_url, 2608, 18, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"sm-link discord\">\r\n                    <span class=\"discord-icon\"></span>\r\n                </a>\r\n                <a");
            BeginWriteAttribute("href", " href=\"", 2750, "\"", 2775, 1);
#nullable restore
#line 59 "C:\Users\danielr\source\repos\MyBg\MyBg\Views\Home\Index.cshtml"
WriteAttributeValue("", 2757, admin.Codepen_url, 2757, 18, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"sm-link codepen\">\r\n                    <span class=\"codepen-icon\"></span>\r\n                </a>\r\n            </div>\r\n        </div>\r\n    </section>\r\n\r\n");
            WriteLiteral("    <div class=\"social-media-section--dp-left\">\r\n        <a");
            BeginWriteAttribute("href", " href=\"", 3081, "\"", 3106, 1);
#nullable restore
#line 68 "C:\Users\danielr\source\repos\MyBg\MyBg\Views\Home\Index.cshtml"
WriteAttributeValue("", 3088, admin.Twitter_url, 3088, 18, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"sm-link twitter\">\r\n            <span class=\"twitter-icon\"></span>\r\n        </a>\r\n        <a");
            BeginWriteAttribute("href", " href=\"", 3206, "\"", 3230, 1);
#nullable restore
#line 71 "C:\Users\danielr\source\repos\MyBg\MyBg\Views\Home\Index.cshtml"
WriteAttributeValue("", 3213, admin.Strava_url, 3213, 17, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"sm-link strava\">\r\n            <span class=\"strava-icon\"></span>\r\n        </a>\r\n        <a");
            BeginWriteAttribute("href", " href=\"", 3328, "\"", 3354, 1);
#nullable restore
#line 74 "C:\Users\danielr\source\repos\MyBg\MyBg\Views\Home\Index.cshtml"
WriteAttributeValue("", 3335, admin.LinkedIn_url, 3335, 19, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"sm-link linkedin\">\r\n            <span class=\"linkedin-icon\"></span>\r\n        </a>\r\n        <a");
            BeginWriteAttribute("href", " href=\"", 3456, "\"", 3481, 1);
#nullable restore
#line 77 "C:\Users\danielr\source\repos\MyBg\MyBg\Views\Home\Index.cshtml"
WriteAttributeValue("", 3463, admin.Discord_url, 3463, 18, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"sm-link discord\">\r\n            <span class=\"discord-icon\"></span>\r\n        </a>\r\n        <a");
            BeginWriteAttribute("href", " href=\"", 3581, "\"", 3606, 1);
#nullable restore
#line 80 "C:\Users\danielr\source\repos\MyBg\MyBg\Views\Home\Index.cshtml"
WriteAttributeValue("", 3588, admin.Codepen_url, 3588, 18, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"sm-link codepen\">\r\n            <span class=\"codepen-icon\"></span>\r\n        </a>\r\n    </div>\r\n    <div class=\"social-media-section--dp-right\">\r\n        <a");
            BeginWriteAttribute("href", " href=\"", 3768, "\"", 3796, 1);
#nullable restore
#line 85 "C:\Users\danielr\source\repos\MyBg\MyBg\Views\Home\Index.cshtml"
WriteAttributeValue("", 3775, admin.YouVersion_Url, 3775, 21, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"sm-link youversion\">\r\n            <span class=\"youversion-icon\"></span>\r\n        </a>\r\n        <a");
            BeginWriteAttribute("href", " href=\"", 3902, "\"", 3929, 1);
#nullable restore
#line 88 "C:\Users\danielr\source\repos\MyBg\MyBg\Views\Home\Index.cshtml"
WriteAttributeValue("", 3909, admin.Instagram_Url, 3909, 20, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"sm-link insta\">\r\n            <span class=\"insta-icon\"></span>\r\n        </a>\r\n        <a");
            BeginWriteAttribute("href", " href=\"", 4025, "\"", 4049, 1);
#nullable restore
#line 91 "C:\Users\danielr\source\repos\MyBg\MyBg\Views\Home\Index.cshtml"
WriteAttributeValue("", 4032, admin.Github_Url, 4032, 17, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"sm-link github\">\r\n            <span class=\"github-icon\"></span>\r\n        </a>\r\n        <a");
            BeginWriteAttribute("href", " href=\"", 4147, "\"", 4174, 1);
#nullable restore
#line 94 "C:\Users\danielr\source\repos\MyBg\MyBg\Views\Home\Index.cshtml"
WriteAttributeValue("", 4154, admin.Goodreads_url, 4154, 20, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"sm-link goodreads\">\r\n            <span class=\"goodreads-icon\"></span>\r\n        </a>\r\n        <a");
            BeginWriteAttribute("href", " href=\"", 4278, "\"", 4303, 1);
#nullable restore
#line 97 "C:\Users\danielr\source\repos\MyBg\MyBg\Views\Home\Index.cshtml"
WriteAttributeValue("", 4285, admin.Youtube_url, 4285, 18, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"sm-link youtube\">\r\n            <span class=\"youtube-icon\"></span>\r\n        </a>\r\n        <a");
            BeginWriteAttribute("href", " href=\"", 4403, "\"", 4427, 1);
#nullable restore
#line 100 "C:\Users\danielr\source\repos\MyBg\MyBg\Views\Home\Index.cshtml"
WriteAttributeValue("", 4410, admin.Reddit_Url, 4410, 17, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"sm-link reddit\">\r\n            <span class=\"reddit-icon\"></span>\r\n        </a>\r\n    </div>\r\n\r\n");
            WriteLiteral("\r\n    <section class=\"indexp-lower-half\">\r\n        <h2 class=\"std-h2 most-recent-h2\">MOST RECENT</h2>\r\n        <section class=\"posts-wrapper\">\r\n");
#nullable restore
#line 110 "C:\Users\danielr\source\repos\MyBg\MyBg\Views\Home\Index.cshtml"
             foreach (PostsViewModel post in posts)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"most-recent-post-wrapper\" id=\"most-recent-post-wrapper\"");
            BeginWriteAttribute("onclick", " onclick=\"", 4911, "\"", 4965, 6);
            WriteAttributeValue("", 4921, "redirectToPost(\'", 4921, 16, true);
#nullable restore
#line 112 "C:\Users\danielr\source\repos\MyBg\MyBg\Views\Home\Index.cshtml"
WriteAttributeValue("", 4937, post.ID, 4937, 8, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 4945, "\',", 4945, 2, true);
            WriteAttributeValue(" ", 4947, "\'", 4948, 2, true);
#nullable restore
#line 112 "C:\Users\danielr\source\repos\MyBg\MyBg\Views\Home\Index.cshtml"
WriteAttributeValue("", 4949, post.PostType, 4949, 14, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 4963, "\')", 4963, 2, true);
            EndWriteAttribute();
            WriteLiteral(">\r\n                    <img");
            BeginWriteAttribute("src", " src=\"", 4993, "\"", 5014, 1);
#nullable restore
#line 113 "C:\Users\danielr\source\repos\MyBg\MyBg\Views\Home\Index.cshtml"
WriteAttributeValue("", 4999, post.Tumbnails, 4999, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"most-recent-post_thumbnail\" />\r\n                    <h3 class=\"std-h3 most-recent-post_title\">");
#nullable restore
#line 114 "C:\Users\danielr\source\repos\MyBg\MyBg\Views\Home\Index.cshtml"
                                                         Write(post.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n                    <p class=\"std-text-quiet most-recent-post_date\">");
#nullable restore
#line 115 "C:\Users\danielr\source\repos\MyBg\MyBg\Views\Home\Index.cshtml"
                                                               Write(post.DatePosted);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                    <div class=\"tag-footer\">\r\n\r\n");
#nullable restore
#line 118 "C:\Users\danielr\source\repos\MyBg\MyBg\Views\Home\Index.cshtml"
                         if (post.PostType == "Favorite")
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <span class=\"std-icon  type_favorite std-icon-tag\"></span>\r\n");
#nullable restore
#line 121 "C:\Users\danielr\source\repos\MyBg\MyBg\Views\Home\Index.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 123 "C:\Users\danielr\source\repos\MyBg\MyBg\Views\Home\Index.cshtml"
                         if (post.PostType == "Blog")
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <span class=\"std-icon type_blog std-icon-tag\"></span>\r\n");
#nullable restore
#line 126 "C:\Users\danielr\source\repos\MyBg\MyBg\Views\Home\Index.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <div class=\"category-wrapper\">\r\n");
#nullable restore
#line 128 "C:\Users\danielr\source\repos\MyBg\MyBg\Views\Home\Index.cshtml"
                             if (!String.IsNullOrEmpty(post.Categories))
                            {
                                string[] tags = post.Categories.Split(" ");
                                foreach (string tag in tags)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2412eadcf8778941a096b85d79cd913bfbd6e40122681", async() => {
#nullable restore
#line 133 "C:\Users\danielr\source\repos\MyBg\MyBg\Views\Home\Index.cshtml"
                                                                                                                                       Write(tag);

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-tag", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 133 "C:\Users\danielr\source\repos\MyBg\MyBg\Views\Home\Index.cshtml"
                                                                                    WriteLiteral(tag.Replace("#", ""));

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["tag"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-tag", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["tag"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 134 "C:\Users\danielr\source\repos\MyBg\MyBg\Views\Home\Index.cshtml"
                                }

                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        </div>\r\n                    </div>\r\n\r\n                </div>\r\n");
#nullable restore
#line 141 "C:\Users\danielr\source\repos\MyBg\MyBg\Views\Home\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </section>\r\n    </section>\r\n\r\n</div>\r\n\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n    <script src=\"/js/Subscribe.js\"></script>\r\n");
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
