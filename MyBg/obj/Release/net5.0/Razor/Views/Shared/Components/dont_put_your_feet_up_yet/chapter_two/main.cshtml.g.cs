#pragma checksum "C:\Users\danielr\source\repos\Mine\MyBg\MyBg\Views\Shared\Components\dont_put_your_feet_up_yet\chapter_two\main.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3766a551f7e111f6c45700238558af3b1cc31317"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_dont_put_your_feet_up_yet_chapter_two_main), @"mvc.1.0.view", @"/Views/Shared/Components/dont_put_your_feet_up_yet/chapter_two/main.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3766a551f7e111f6c45700238558af3b1cc31317", @"/Views/Shared/Components/dont_put_your_feet_up_yet/chapter_two/main.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bc5dbcb0184da424cb338a8e1ab3a5366afac376", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_dont_put_your_feet_up_yet_chapter_two_main : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<string[]>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<div class=\"sub-layout\" id=\"layer-chapter-two\">\r\n    <h2 class=\"std-h2 chapter-section-title\">2 LIVING UP TO THE NAME</h2>\r\n    ");
#nullable restore
#line 5 "C:\Users\danielr\source\repos\Mine\MyBg\MyBg\Views\Shared\Components\dont_put_your_feet_up_yet\chapter_two\main.cshtml"
Write(await Html.PartialAsync("./section_one.cshtml", Model[0]));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    ");
#nullable restore
#line 6 "C:\Users\danielr\source\repos\Mine\MyBg\MyBg\Views\Shared\Components\dont_put_your_feet_up_yet\chapter_two\main.cshtml"
Write(await Html.PartialAsync("./section_two.cshtml", Model[1]));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    ");
#nullable restore
#line 7 "C:\Users\danielr\source\repos\Mine\MyBg\MyBg\Views\Shared\Components\dont_put_your_feet_up_yet\chapter_two\main.cshtml"
Write(await Html.PartialAsync("./section_three.cshtml", Model[2]));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n    <div class=\"spacer-from-chapter-section\"></div>\r\n\r\n    <section class=\"chapter-sections-selector-wrapper\">\r\n        <div");
            BeginWriteAttribute("style", " style=\'", 463, "\'", 505, 4);
            WriteAttributeValue("", 471, "background-image:", 471, 17, true);
            WriteAttributeValue(" ", 488, "url(\"", 489, 6, true);
#nullable restore
#line 12 "C:\Users\danielr\source\repos\Mine\MyBg\MyBg\Views\Shared\Components\dont_put_your_feet_up_yet\chapter_two\main.cshtml"
WriteAttributeValue("", 494, Model[0], 494, 9, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 503, "\")", 503, 2, true);
            EndWriteAttribute();
            WriteLiteral(" id=\"chapter-two_section-one--trigger\" class=\"focused-section chapter-section-card\" data-section=\"1\"></div>\r\n        <div");
            BeginWriteAttribute("style", " style=\'", 627, "\'", 669, 4);
            WriteAttributeValue("", 635, "background-image:", 635, 17, true);
            WriteAttributeValue(" ", 652, "url(\"", 653, 6, true);
#nullable restore
#line 13 "C:\Users\danielr\source\repos\Mine\MyBg\MyBg\Views\Shared\Components\dont_put_your_feet_up_yet\chapter_two\main.cshtml"
WriteAttributeValue("", 658, Model[1], 658, 9, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 667, "\")", 667, 2, true);
            EndWriteAttribute();
            WriteLiteral(" id=\"chapter-two_section-two--trigger\" class=\"chapter-section-card\" data-section=\"2\"></div>\r\n        <div");
            BeginWriteAttribute("style", " style=\'", 775, "\'", 817, 4);
            WriteAttributeValue("", 783, "background-image:", 783, 17, true);
            WriteAttributeValue(" ", 800, "url(\"", 801, 6, true);
#nullable restore
#line 14 "C:\Users\danielr\source\repos\Mine\MyBg\MyBg\Views\Shared\Components\dont_put_your_feet_up_yet\chapter_two\main.cshtml"
WriteAttributeValue("", 806, Model[2], 806, 9, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 815, "\")", 815, 2, true);
            EndWriteAttribute();
            WriteLiteral(@" id=""chapter-two_section-three--trigger"" class=""chapter-section-card"" data-section=""3""></div>
    </section>
</div>

<script>

    const chapterTwo_SectionOne = document.querySelector(""#chapter-two_section-one"");
    const chapterTwo_SectionTwo = document.querySelector(""#chapter-two_section-two"");
    const chapterTwo_SectionThree = document.querySelector(""#chapter-two_section-three"");

    const chapterTwo_SectionOne_Trigger = document.querySelector(""#chapter-two_section-one--trigger"");
    const chapterTwo_SectionTwo_Trigger = document.querySelector(""#chapter-two_section-two--trigger"");
    const chapterTwo_SectionThree_Trigger = document.querySelector(""#chapter-two_section-three--trigger"");


    const chooseSection_ChapterTwo = (e) => {
        const section = e.target.dataset.section;
        switch (section) {
            case '1':
                chapterTwo_SectionThree.style.display = ""none""
                chapterTwo_SectionTwo.style.display = ""none""
                chapterTwo_Se");
            WriteLiteral(@"ctionOne.style.display = ""flex""

                // add the shiny border class
                chapterTwo_SectionThree_Trigger.classList.remove('focused-section')
                chapterTwo_SectionTwo_Trigger.classList.remove('focused-section')
                chapterTwo_SectionOne_Trigger.classList.add('focused-section')
                break;

            case '2':
                chapterTwo_SectionThree.style.display = ""none""
                chapterTwo_SectionOne.style.display = ""none""
                chapterTwo_SectionTwo.style.display = ""flex""

                // add the shiny border class
                chapterTwo_SectionThree_Trigger.classList.remove('focused-section')
                chapterTwo_SectionOne_Trigger.classList.remove('focused-section')
                chapterTwo_SectionTwo_Trigger.classList.add('focused-section')
                break;

            case '3':
                chapterTwo_SectionOne.style.display = ""none""
                chapterTwo_SectionTwo.style.displ");
            WriteLiteral(@"ay = ""none""
                chapterTwo_SectionThree.style.display = ""flex""

                // add the shiny border class
                chapterTwo_SectionOne_Trigger.classList.remove('focused-section')
                chapterTwo_SectionTwo_Trigger.classList.remove('focused-section')
                chapterTwo_SectionThree_Trigger.classList.add('focused-section')
                break;

        }
    }

    // assign click event to section card
    const chapterTwo_Section_Cards = document.querySelectorAll("".chapter-section-card"");
    chapterTwo_Section_Cards.forEach(item => {
        item.addEventListener('click', chooseSection_ChapterTwo)
    })

</script>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<string[]> Html { get; private set; }
    }
}
#pragma warning restore 1591
