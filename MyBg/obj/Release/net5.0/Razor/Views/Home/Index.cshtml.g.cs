#pragma checksum "C:\Users\danielr\source\repos\MyBg\MyBg\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "912bf1ec0626552a361197842613f2cce96b28fc"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"912bf1ec0626552a361197842613f2cce96b28fc", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bc5dbcb0184da424cb338a8e1ab3a5366afac376", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/images/Intro-logo.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("intro-logo"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("logo of the webiste"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Posts", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("category-tag"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
  
    // metatags
    ViewData["MetaDescription"] = "Toughts, tips, tech, tools, and a little bit of everything to help your ministry and enrich your Christian walk by Daniel Rangel";

    ViewData["OGTitle"] = "Tools, Tips, Thoughts, and Tech to help your Christian walk";
    ViewData["OGUrl"] = "http://danielrangel.me";
    ViewData["OGImage"] = "https://res.cloudinary.com/dq6prlmvh/image/upload/v1643904780/danielrangel.me/logo_lnqtd7.png";
    ViewData["OGType"] = "website";
    ViewData["OGDescription"] = "Toughts, tips, tech, tools, and a little bit of everything to help your ministry and enrich your Christian walk by Daniel Rangel";
    ViewData["OGSiteName"] = "Daniel Rangel";

    ViewData["TWTitle"] = "Daniel Rangel";
    ViewData["TWDescription"] = "Toughts, tips, tech, tools, and a little bit of everything to help your ministry and enrich your Christian walk by Daniel Rangel";
    ViewData["TWImage"] = "https://res.cloudinary.com/dq6prlmvh/image/upload/v1643904780/danielrangel.me/logo_lnqtd7.png";
    ViewData["TWSite"] = "@Yodarango";
    ViewData["TWCreator"] = "@Yodarango";

    ViewData["Title"] = "Tools, Tips, Thoughts, and Tech to help your Christian walk";

    ViewData["MenuBtnTitle"] = "Home";
    UserAdminModel admin = ViewData["User"] as UserAdminModel;
    string followersCount = ViewData["FollowerCount"].ToString();
    IEnumerable<PostsViewModel> posts = ViewData["Posts"] as IEnumerable<PostsViewModel>;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"main-wrapper main-wrapper_index\">\r\n");
#nullable restore
#line 28 "C:\Users\danielr\source\repos\MyBg\MyBg\Views\Home\Index.cshtml"
     if ((bool)ViewData["SubsMessage"] == true)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"        <div id=""menu-wrapper"" class=""color-theme-wrapper color-theme-wrapper--open thankyou-for-subs"">
            <h3 class=""std-h3 subscribe-h3"">Thank you for subscribing!</h3>
            <button type=""submit"" class=""std-button close-button"" onclick=""closeNotification()"">Close</button>
        </div>
");
#nullable restore
#line 34 "C:\Users\danielr\source\repos\MyBg\MyBg\Views\Home\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    <section class=\"indexp-upper-half\">\r\n        <h1 class=\"std-h1 intro-title\">\r\n            THOUGHTS. TIPS. TOOLS. TECH.\r\n        </h1>\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "912bf1ec0626552a361197842613f2cce96b28fc7761", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n        <p class=\"std-p intro-text\">");
#nullable restore
#line 41 "C:\Users\danielr\source\repos\MyBg\MyBg\Views\Home\Index.cshtml"
                               Write(admin.About_Me);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</p>
        <button class=""std-button subscribe-button"" id=""subscribe-button"" onclick=""handleSubscribe()"">Follow</button>

        <div class=""social-media-section"">
            <h3 class=""std-h3 sm-section-title"">Find Me On</h3>
            <div class=""sm-links-wrapper"">
                <a");
            BeginWriteAttribute("href", " href=\"", 2521, "\"", 2549, 1);
#nullable restore
#line 47 "C:\Users\danielr\source\repos\MyBg\MyBg\Views\Home\Index.cshtml"
WriteAttributeValue("", 2528, admin.YouVersion_Url, 2528, 21, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"sm-link youversion\">\r\n                    <span class=\"youversion-icon\"></span>\r\n                </a>\r\n                <a");
            BeginWriteAttribute("href", " href=\"", 2679, "\"", 2706, 1);
#nullable restore
#line 50 "C:\Users\danielr\source\repos\MyBg\MyBg\Views\Home\Index.cshtml"
WriteAttributeValue("", 2686, admin.Instagram_Url, 2686, 20, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"sm-link insta\">\r\n                    <span class=\"insta-icon\"></span>\r\n                </a>\r\n                <a");
            BeginWriteAttribute("href", " href=\"", 2826, "\"", 2850, 1);
#nullable restore
#line 53 "C:\Users\danielr\source\repos\MyBg\MyBg\Views\Home\Index.cshtml"
WriteAttributeValue("", 2833, admin.Github_Url, 2833, 17, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"sm-link github\">\r\n                    <span class=\"github-icon\"></span>\r\n                </a>\r\n                <a");
            BeginWriteAttribute("href", " href=\"", 2972, "\"", 2999, 1);
#nullable restore
#line 56 "C:\Users\danielr\source\repos\MyBg\MyBg\Views\Home\Index.cshtml"
WriteAttributeValue("", 2979, admin.Goodreads_url, 2979, 20, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"sm-link goodreads\">\r\n                    <span class=\"goodreads-icon\"></span>\r\n                </a>\r\n                <a");
            BeginWriteAttribute("href", " href=\"", 3127, "\"", 3152, 1);
#nullable restore
#line 59 "C:\Users\danielr\source\repos\MyBg\MyBg\Views\Home\Index.cshtml"
WriteAttributeValue("", 3134, admin.Youtube_url, 3134, 18, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"sm-link youtube\">\r\n                    <span class=\"youtube-icon\"></span>\r\n                </a>\r\n                <a");
            BeginWriteAttribute("href", " href=\"", 3276, "\"", 3300, 1);
#nullable restore
#line 62 "C:\Users\danielr\source\repos\MyBg\MyBg\Views\Home\Index.cshtml"
WriteAttributeValue("", 3283, admin.Reddit_Url, 3283, 17, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"sm-link reddit\">\r\n                    <span class=\"reddit-icon\"></span>\r\n                </a>\r\n                <a");
            BeginWriteAttribute("href", " href=\"", 3422, "\"", 3447, 1);
#nullable restore
#line 65 "C:\Users\danielr\source\repos\MyBg\MyBg\Views\Home\Index.cshtml"
WriteAttributeValue("", 3429, admin.Twitter_url, 3429, 18, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"sm-link twitter\">\r\n                    <span class=\"twitter-icon\"></span>\r\n                </a>\r\n                <a");
            BeginWriteAttribute("href", " href=\"", 3571, "\"", 3595, 1);
#nullable restore
#line 68 "C:\Users\danielr\source\repos\MyBg\MyBg\Views\Home\Index.cshtml"
WriteAttributeValue("", 3578, admin.Strava_url, 3578, 17, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"sm-link strava\">\r\n                    <span class=\"strava-icon\"></span>\r\n                </a>\r\n                <a");
            BeginWriteAttribute("href", " href=\"", 3717, "\"", 3743, 1);
#nullable restore
#line 71 "C:\Users\danielr\source\repos\MyBg\MyBg\Views\Home\Index.cshtml"
WriteAttributeValue("", 3724, admin.LinkedIn_url, 3724, 19, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"sm-link linkedin\">\r\n                    <span class=\"linkedin-icon\"></span>\r\n                </a>\r\n                <a");
            BeginWriteAttribute("href", " href=\"", 3869, "\"", 3894, 1);
#nullable restore
#line 74 "C:\Users\danielr\source\repos\MyBg\MyBg\Views\Home\Index.cshtml"
WriteAttributeValue("", 3876, admin.Discord_url, 3876, 18, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"sm-link discord\">\r\n                    <span class=\"discord-icon\"></span>\r\n                </a>\r\n                <a");
            BeginWriteAttribute("href", " href=\"", 4018, "\"", 4043, 1);
#nullable restore
#line 77 "C:\Users\danielr\source\repos\MyBg\MyBg\Views\Home\Index.cshtml"
WriteAttributeValue("", 4025, admin.Codepen_url, 4025, 18, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"sm-link codepen\">\r\n                    <span class=\"codepen-icon\"></span>\r\n                </a>\r\n            </div>\r\n        </div>\r\n    </section>\r\n\r\n");
            WriteLiteral("    <div class=\"social-media-section--dp-left\">\r\n        <a");
            BeginWriteAttribute("href", " href=\"", 4349, "\"", 4374, 1);
#nullable restore
#line 86 "C:\Users\danielr\source\repos\MyBg\MyBg\Views\Home\Index.cshtml"
WriteAttributeValue("", 4356, admin.Twitter_url, 4356, 18, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"sm-link twitter\">\r\n            <span class=\"twitter-icon\"></span>\r\n        </a>\r\n        <a");
            BeginWriteAttribute("href", " href=\"", 4474, "\"", 4498, 1);
#nullable restore
#line 89 "C:\Users\danielr\source\repos\MyBg\MyBg\Views\Home\Index.cshtml"
WriteAttributeValue("", 4481, admin.Strava_url, 4481, 17, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"sm-link strava\">\r\n            <span class=\"strava-icon\"></span>\r\n        </a>\r\n        <a");
            BeginWriteAttribute("href", " href=\"", 4596, "\"", 4622, 1);
#nullable restore
#line 92 "C:\Users\danielr\source\repos\MyBg\MyBg\Views\Home\Index.cshtml"
WriteAttributeValue("", 4603, admin.LinkedIn_url, 4603, 19, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"sm-link linkedin\">\r\n            <span class=\"linkedin-icon\"></span>\r\n        </a>\r\n        <a");
            BeginWriteAttribute("href", " href=\"", 4724, "\"", 4749, 1);
#nullable restore
#line 95 "C:\Users\danielr\source\repos\MyBg\MyBg\Views\Home\Index.cshtml"
WriteAttributeValue("", 4731, admin.Discord_url, 4731, 18, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"sm-link discord\">\r\n            <span class=\"discord-icon\"></span>\r\n        </a>\r\n        <a");
            BeginWriteAttribute("href", " href=\"", 4849, "\"", 4874, 1);
#nullable restore
#line 98 "C:\Users\danielr\source\repos\MyBg\MyBg\Views\Home\Index.cshtml"
WriteAttributeValue("", 4856, admin.Codepen_url, 4856, 18, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"sm-link codepen\">\r\n            <span class=\"codepen-icon\"></span>\r\n        </a>\r\n    </div>\r\n    <div class=\"social-media-section--dp-right\">\r\n        <a");
            BeginWriteAttribute("href", " href=\"", 5036, "\"", 5064, 1);
#nullable restore
#line 103 "C:\Users\danielr\source\repos\MyBg\MyBg\Views\Home\Index.cshtml"
WriteAttributeValue("", 5043, admin.YouVersion_Url, 5043, 21, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"sm-link youversion\">\r\n            <span class=\"youversion-icon\"></span>\r\n        </a>\r\n        <a");
            BeginWriteAttribute("href", " href=\"", 5170, "\"", 5197, 1);
#nullable restore
#line 106 "C:\Users\danielr\source\repos\MyBg\MyBg\Views\Home\Index.cshtml"
WriteAttributeValue("", 5177, admin.Instagram_Url, 5177, 20, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"sm-link insta\">\r\n            <span class=\"insta-icon\"></span>\r\n        </a>\r\n        <a");
            BeginWriteAttribute("href", " href=\"", 5293, "\"", 5317, 1);
#nullable restore
#line 109 "C:\Users\danielr\source\repos\MyBg\MyBg\Views\Home\Index.cshtml"
WriteAttributeValue("", 5300, admin.Github_Url, 5300, 17, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"sm-link github\">\r\n            <span class=\"github-icon\"></span>\r\n        </a>\r\n        <a");
            BeginWriteAttribute("href", " href=\"", 5415, "\"", 5442, 1);
#nullable restore
#line 112 "C:\Users\danielr\source\repos\MyBg\MyBg\Views\Home\Index.cshtml"
WriteAttributeValue("", 5422, admin.Goodreads_url, 5422, 20, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"sm-link goodreads\">\r\n            <span class=\"goodreads-icon\"></span>\r\n        </a>\r\n        <a");
            BeginWriteAttribute("href", " href=\"", 5546, "\"", 5571, 1);
#nullable restore
#line 115 "C:\Users\danielr\source\repos\MyBg\MyBg\Views\Home\Index.cshtml"
WriteAttributeValue("", 5553, admin.Youtube_url, 5553, 18, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"sm-link youtube\">\r\n            <span class=\"youtube-icon\"></span>\r\n        </a>\r\n        <a");
            BeginWriteAttribute("href", " href=\"", 5671, "\"", 5695, 1);
#nullable restore
#line 118 "C:\Users\danielr\source\repos\MyBg\MyBg\Views\Home\Index.cshtml"
WriteAttributeValue("", 5678, admin.Reddit_Url, 5678, 17, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"sm-link reddit\">\r\n            <span class=\"reddit-icon\"></span>\r\n        </a>\r\n    </div>\r\n\r\n");
            WriteLiteral("\r\n    <section class=\"indexp-lower-half\">\r\n        <h2 class=\"std-h2 most-recent-h2\">MOST RECENT</h2>\r\n        <section class=\"posts-wrapper\">\r\n");
#nullable restore
#line 128 "C:\Users\danielr\source\repos\MyBg\MyBg\Views\Home\Index.cshtml"
             foreach (PostsViewModel post in posts)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"most-recent-post-wrapper\" id=\"most-recent-post-wrapper\"");
            BeginWriteAttribute("onclick", " onclick=\"", 6179, "\"", 6233, 6);
            WriteAttributeValue("", 6189, "redirectToPost(\'", 6189, 16, true);
#nullable restore
#line 130 "C:\Users\danielr\source\repos\MyBg\MyBg\Views\Home\Index.cshtml"
WriteAttributeValue("", 6205, post.ID, 6205, 8, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 6213, "\',", 6213, 2, true);
            WriteAttributeValue(" ", 6215, "\'", 6216, 2, true);
#nullable restore
#line 130 "C:\Users\danielr\source\repos\MyBg\MyBg\Views\Home\Index.cshtml"
WriteAttributeValue("", 6217, post.PostType, 6217, 14, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 6231, "\')", 6231, 2, true);
            EndWriteAttribute();
            WriteLiteral(">\r\n                    <img");
            BeginWriteAttribute("src", " src=\"", 6261, "\"", 6282, 1);
#nullable restore
#line 131 "C:\Users\danielr\source\repos\MyBg\MyBg\Views\Home\Index.cshtml"
WriteAttributeValue("", 6267, post.Tumbnails, 6267, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"most-recent-post_thumbnail\" />\r\n                    <h3 class=\"std-h3 most-recent-post_title\">");
#nullable restore
#line 132 "C:\Users\danielr\source\repos\MyBg\MyBg\Views\Home\Index.cshtml"
                                                         Write(post.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n                    <p class=\"std-text-quiet most-recent-post_date\">");
#nullable restore
#line 133 "C:\Users\danielr\source\repos\MyBg\MyBg\Views\Home\Index.cshtml"
                                                               Write(post.DatePosted);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                    <div class=\"tag-footer\">\r\n\r\n");
#nullable restore
#line 136 "C:\Users\danielr\source\repos\MyBg\MyBg\Views\Home\Index.cshtml"
                         if (post.PostType == "Favorite")
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <span class=\"std-icon  type_favorite std-icon-tag\"></span>\r\n");
#nullable restore
#line 139 "C:\Users\danielr\source\repos\MyBg\MyBg\Views\Home\Index.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 141 "C:\Users\danielr\source\repos\MyBg\MyBg\Views\Home\Index.cshtml"
                         if (post.PostType == "Blog")
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <span class=\"std-icon type_blog std-icon-tag\"></span>\r\n");
#nullable restore
#line 144 "C:\Users\danielr\source\repos\MyBg\MyBg\Views\Home\Index.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <div class=\"category-wrapper\">\r\n");
#nullable restore
#line 146 "C:\Users\danielr\source\repos\MyBg\MyBg\Views\Home\Index.cshtml"
                             if (!String.IsNullOrEmpty(post.Categories))
                            {
                                string[] tags = post.Categories.Split(" ");
                                foreach (string tag in tags)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "912bf1ec0626552a361197842613f2cce96b28fc24369", async() => {
#nullable restore
#line 151 "C:\Users\danielr\source\repos\MyBg\MyBg\Views\Home\Index.cshtml"
                                                                                                                                       Write(tag);

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-tag", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 151 "C:\Users\danielr\source\repos\MyBg\MyBg\Views\Home\Index.cshtml"
                                                                                    WriteLiteral(tag.Replace("#", ""));

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["tag"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-tag", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["tag"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 152 "C:\Users\danielr\source\repos\MyBg\MyBg\Views\Home\Index.cshtml"
                                }

                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        </div>\r\n                    </div>\r\n\r\n                </div>\r\n");
#nullable restore
#line 159 "C:\Users\danielr\source\repos\MyBg\MyBg\Views\Home\Index.cshtml"
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
