#pragma checksum "C:\Users\danielr\source\repos\Mine\MyBg\MyBg\Views\Shared\Components\dont_put_your_feet_up_yet\chapter_four\main.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ed3779c4644a3a77a53d264d862cd51d07252a3c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_dont_put_your_feet_up_yet_chapter_four_main), @"mvc.1.0.view", @"/Views/Shared/Components/dont_put_your_feet_up_yet/chapter_four/main.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ed3779c4644a3a77a53d264d862cd51d07252a3c", @"/Views/Shared/Components/dont_put_your_feet_up_yet/chapter_four/main.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bc5dbcb0184da424cb338a8e1ab3a5366afac376", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_dont_put_your_feet_up_yet_chapter_four_main : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<string[]>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<div class=\"sub-layout\" id=\"layer-chapter-four\">\r\n    <h2 class=\"std-h2 chapter-section-title\">4 IN THE FAR COUNTRY</h2>\r\n    ");
#nullable restore
#line 5 "C:\Users\danielr\source\repos\Mine\MyBg\MyBg\Views\Shared\Components\dont_put_your_feet_up_yet\chapter_four\main.cshtml"
Write(await Html.PartialAsync("./section_one.cshtml", Model[0]));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    ");
#nullable restore
#line 6 "C:\Users\danielr\source\repos\Mine\MyBg\MyBg\Views\Shared\Components\dont_put_your_feet_up_yet\chapter_four\main.cshtml"
Write(await Html.PartialAsync("./section_two.cshtml", Model[1]));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n    <div class=\"spacer-from-chapter-section\"></div>\r\n\r\n    <section class=\"chapter-sections-selector-wrapper\">\r\n        <div");
            BeginWriteAttribute("style", " style=\'", 396, "\'", 439, 5);
            WriteAttributeValue("", 404, "background-image:", 404, 17, true);
            WriteAttributeValue(" ", 421, "url(\"", 422, 6, true);
#nullable restore
#line 11 "C:\Users\danielr\source\repos\Mine\MyBg\MyBg\Views\Shared\Components\dont_put_your_feet_up_yet\chapter_four\main.cshtml"
WriteAttributeValue("", 427, Model[0], 427, 9, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 436, "\")", 436, 2, true);
            WriteAttributeValue(" ", 438, "", 439, 1, true);
            EndWriteAttribute();
            WriteLiteral(" id=\"chapter-four_section-one--trigger\" class=\"focused-section chapter-section-card\" data-section=\"1\"></div>\r\n        <div");
            BeginWriteAttribute("style", " style=\'", 562, "\'", 605, 5);
            WriteAttributeValue("", 570, "background-image:", 570, 17, true);
            WriteAttributeValue(" ", 587, "url(\"", 588, 6, true);
#nullable restore
#line 12 "C:\Users\danielr\source\repos\Mine\MyBg\MyBg\Views\Shared\Components\dont_put_your_feet_up_yet\chapter_four\main.cshtml"
WriteAttributeValue("", 593, Model[1], 593, 9, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 602, "\")", 602, 2, true);
            WriteAttributeValue(" ", 604, "", 605, 1, true);
            EndWriteAttribute();
            WriteLiteral(@" id=""chapter-four_section-two--trigger"" class=""chapter-section-card"" data-section=""2""></div>
    </section>
</div>

<script>

    const chapterFour_SectionOne = document.querySelector(""#chapter-four_section-one"");
    const chapterFour_SectionTwo = document.querySelector(""#chapter-four_section-two"");

    const chapterFour_SectionOne_Trigger = document.querySelector(""#chapter-four_section-one--trigger"");
    const chapterFour_SectionTwo_Trigger = document.querySelector(""#chapter-four_section-two--trigger"");

    const chooseSection_chapterFour = (e) => {
        const section = e.target.dataset.section;
        switch (section) {
            case '1':
                chapterFour_SectionTwo.style.display = ""none""
                chapterFour_SectionOne.style.display = ""flex""

                // add the shiny border class
                chapterFour_SectionTwo_Trigger.classList.remove('focused-section')
                chapterFour_SectionOne_Trigger.classList.add('focused-section')
        ");
            WriteLiteral(@"        break;

            case '2':
                chapterFour_SectionTwo.style.display = ""flex""
                chapterFour_SectionOne.style.display = ""none""

                // add the shiny border class
                chapterFour_SectionTwo_Trigger.classList.add('focused-section')
                chapterFour_SectionOne_Trigger.classList.remove('focused-section')
                break;


        }
    }

    // assign click event to section card
    const chapterFour_SectionOne_Cards = document.querySelectorAll("".chapter-section-card"");
    chapterFour_SectionOne_Cards.forEach(item => {
        item.addEventListener('click', chooseSection_chapterFour)
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
