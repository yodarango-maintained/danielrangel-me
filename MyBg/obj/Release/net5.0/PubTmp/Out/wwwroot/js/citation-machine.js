
//*************************** Turbian citation is not going to be implemented at the moment ****************************/
// buttons
const allButtons = document.querySelectorAll(".botton-wrapper > *");
const mlaBtn = document.querySelector("#button-mla");
const apaBtn = document.querySelector("#button-apa");
const chicagoBtn = document.querySelector("#button-chicago");
const turbianBtn = document.querySelector("#button-turbian");

const sourceTypeBook = document.querySelector("#source-type-book");
const sourceTypeJournal = document.querySelector("#source-type-journal");
const sourceTypeWebsite = document.querySelector("#source-type-website");

const addAuthorBtn = document.querySelectorAll("#addAuthor")

// wrappers
const MLABookWrapper = document.querySelector("#mla-wrapper-book");
const MLAjournalWrapper = document.querySelector("#mla-wrapper-journal");
const MLAwebisteWrapper = document.querySelector("#mla-wrapper-website");

const atuhorsWrapper = document.querySelectorAll(".authors-wrapper")

// ---------------- book inputs 
const bookFirstAuthorFN = document.querySelector("#input-first-author-fn--book")
const bookFirstAuthorMN = document.querySelector("#input-first-author-mn--book")
const bookFirstAuthorLN = document.querySelector("#input-first-author-ln--book")
const bookTitle = document.querySelector("#input-title--book")
const bookEdition = document.querySelector("#input-edition--book")
const bookOublisher = document.querySelector("#input-publisher--book")
const bookPlaceofPublication = document.querySelector("#input-publisher--book-chicago")
const bookYearPub = document.querySelector("#input-yearPub--book")
const bookPagesUsed = document.querySelector("#input-pages--book")

// ---------------- journal inputs 
const journalFirstAuthorFN = document.querySelector("#input-first-author-fn--journal")
const journalFirstAuthorMN = document.querySelector("#input-first-author-mn--journal")
const journalFirstAuthorLN = document.querySelector("#input-first-author-ln--journal")
const journalArticleTitle = document.querySelector("#input-source-art-title--journal")
const journalJournalTitle = document.querySelector("#input-source-jour-title--journal")
const journalVolume = document.querySelector("#input-source-volume--journal")
const journalIssueNum = document.querySelector("#input-source-issueNum-journal")
const journalMonthPub = document.querySelector("#input-source-monthPub--journal")
const journalMonthPubChi = document.querySelector("#input-source-monthPub--journal-chicago")
const journalYearPub = document.querySelector("#input-source-yearPub--journal")
const journalSourcePages = document.querySelector("#input-source-Pages--journal")
const journalDoi = document.querySelector("#input-source-doi--journal")


// ---------------- website inputs 
const websiteFirstAuthorFN = document.querySelector("#input-first-author-fn--website")
const websiteFirstAuthorMN = document.querySelector("#input-first-author-mn--website")
const websiteFirstAuthorLN = document.querySelector("#input-first-author-ln--website")
const websitePageTitle = document.querySelector("#input-pageTitle--website")
const websiteWebsiteTitle = document.querySelector("#input-webTitle--website")
const websiteDayPub = document.querySelector("#input-dayPub--website")
const websiteMonthPub = document.querySelector("#input-monthPub--website")
const websiteMonthPubAPA = document.querySelector("#input-monthPub--website-apa")
const websiteYearPub = document.querySelector("#input-yearPub--website")

const websiteDayPubChi = document.querySelector("#input-dayPub--website-chi")
const websiteMonthPubChi = document.querySelector("#input-monthPub--website-chi")
const websiteYearPubChi = document.querySelector("#input-yearPub--website-chi")

const websiteSourceUrl = document.querySelector("#input-sourceUrl--website")

//------------ wrapper
const citationWrapper = document.querySelector(".reading-result-wrapper");
const citationResultText = document.querySelector("#citation-time-result");

//---------------------------- choose the citation style -------------------------- //
//------- 1: MLA Style
const mlaStyle = () => {
    apaBtn.classList.remove('active');
    chicagoBtn.classList.remove('active');
    //turbianBtn.classList.remove('active');

    mlaBtn.classList.add('active');

    journalMonthPub.style.display = "block";

    bookFirstAuthorMN.style.display = "none"
    journalFirstAuthorMN.style.display = "none"
    websiteFirstAuthorMN.style.display = "none"

    websiteMonthPub.style.display = "block";
    websiteMonthPubAPA.style.display = "none";
    websiteMonthPubChi.style.display = "none"

    websiteDayPub.style.display = "block";
    websiteDayPubChi.style.display = "none";

    websiteYearPub.style.display = "block";
    websiteYearPubChi.style.display = "none"

    bookPlaceofPublication.style.display = "none";

    bookPagesUsed.style.display = "none";

    bookEdition.style.display = "block";

    journalMonthPubChi.style.display = "none"
}

//------- 2: APA Style
const apaStyle = () => {
    mlaBtn.classList.remove('active');
    chicagoBtn.classList.remove('active');
    //turbianBtn.classList.remove('active');

    apaBtn.classList.add('active');

    journalMonthPub.style.display = "none";

    bookFirstAuthorMN.style.display = "block"
    journalFirstAuthorMN.style.display = "block"
    websiteFirstAuthorMN.style.display = "block"

    websiteMonthPub.style.display = "none";
    websiteMonthPubAPA.style.display = "block";
    websiteMonthPubChi.style.display = "none"

    websiteDayPub.style.display = "block";
    websiteDayPubChi.style.display = "none";

    websiteYearPub.style.display = "block";
    websiteYearPubChi.style.display = "none"


    bookPlaceofPublication.style.display = "none";

    bookPagesUsed.style.display = "none";

    bookEdition.style.display = "block";

    journalMonthPubChi.style.display = "none"
}

//------- 3: Chicago Style
const chicagoStyle = () => {
    atuhorsWrapper.forEach(wrap => wrap.style.display = "none");

    apaBtn.classList.remove('active');
    mlaBtn.classList.remove('active');
    //turbianBtn.classList.remove('active');

    chicagoBtn.classList.add('active');

    journalMonthPub.style.display = "none";
    journalMonthPubChi.style.display = "block"

    bookFirstAuthorMN.style.display = "none"
    journalFirstAuthorMN.style.display = "none"
    websiteFirstAuthorMN.style.display = "none"

    websiteMonthPub.style.display = "none";
    websiteMonthPubAPA.style.display = "none";
    websiteMonthPubChi.style.display = "block"

    websiteDayPub.style.display = "none";
    websiteDayPubChi.style.display = "block";

    websiteYearPub.style.display = "none";
    websiteYearPubChi.style.display = "block"

    bookPlaceofPublication.style.display = "block";

    bookPagesUsed.style.display = "block";

    bookEdition.style.display = "none";
}

////------- 4: Turbian Style
//const turbianStyle = () => {
//    apaBtn.classList.remove('active');
//    chicagoBtn.classList.remove('active');
//    mlaBtn.classList.remove('active');

//    turbianBtn.classList.add('active');

//    journalMonthPub.style.display = "none";
//    journalMonthPubChi.style.display = "none"

//    bookFirstAuthorMN.style.display = "none"
//    journalFirstAuthorMN.style.display = "none"
//    websiteFirstAuthorMN.style.display = "none"

//    websiteMonthPub.style.display = "none";
//    websiteMonthPubAPA.style.display = "none";
//    websiteMonthPubChi.style.display = "block"

//    websiteDayPub.style.display = "none";
//    websiteDayPubChi.style.display = "block";

//    websiteYearPub.style.display = "none";
//    websiteYearPubChi.style.display = "block"

//    bookPlaceofPublication.style.display = "block";

//    bookPagesUsed.style.display = "block";

//    bookEdition.style.display = "none";
//}

let isStyleChosen = {
    isIt: false,
    style: undefined
};

const chooseCitationStyle = (style) => {

    if (style === 'mla') {
        mlaStyle()

        isStyleChosen.isIt = true
        isStyleChosen.style = "mla"
    }

    if (style === 'apa') {
        apaStyle()

        isStyleChosen.isIt = true
        isStyleChosen.style = "apa"
    }

    if (style === 'chicago') {
        chicagoStyle()

        isStyleChosen.isIt = true
        isStyleChosen.style = "chicago"
    }

    //if (style === 'turbian') {
    //    turbianStyle()

    //    isStyleChosen.isIt = true
    //    isStyleChosen.style = "turbian"
    //}
}

//---------------------------- choose the citation source -------------------------- //
// ---------------- 1: Book
const bookSource = () => {

    sourceTypeJournal.classList.remove('active')
    sourceTypeWebsite.classList.remove('active')

    sourceTypeBook.classList.add('active')

    MLAwebisteWrapper.style.display = 'none'
    MLAjournalWrapper.style.display = 'none'

    MLABookWrapper.style.display = 'flex'


}

const journalSource = () => {

    sourceTypeBook.classList.remove('active')
    sourceTypeWebsite.classList.remove('active')

    sourceTypeJournal.classList.add('active')

    MLAwebisteWrapper.style.display = 'none'
    MLABookWrapper.style.display = 'none'

    MLAjournalWrapper.style.display = 'flex'

}

const websiteSource = () => {

    sourceTypeJournal.classList.remove('active')
    sourceTypeBook.classList.remove('active')

    sourceTypeWebsite.classList.add('active')

    MLABookWrapper.style.display = 'none'
    MLAjournalWrapper.style.display = 'none'


    MLAwebisteWrapper.style.display = 'flex'


}

let isSourceTypeChosen = {
    isIt: false,
    source: undefined
};

const SelectSourceType = (style) => {

    // remove the second auhtor fields from other places
    const additionalAuthorWrapper = document.querySelectorAll(".single-author-wrap--additional")

    additionalAuthorWrapper.forEach(field => field.remove())
    console.log(additionalAuthorWrapper)

    if (isStyleChosen.isIt) {

        if (style === 'book') {
            bookSource()

            isSourceTypeChosen.isIt = true;
            isSourceTypeChosen.source = "book";
        }

        if (style === 'journal') {
            journalSource()

            isSourceTypeChosen.isIt = true;
            isSourceTypeChosen.source = "journal";
        }

        if (style === 'website') {
            websiteSource()

            isSourceTypeChosen.isIt = true;
            isSourceTypeChosen.source = "website";
        }
    }
}

// ------------------------------ add author/ remove ------------------------------- //

const removeAuthor = (e) => {
    e.parentNode.parentNode.remove();
}

addAuthorBtn.forEach(item => {
    item.addEventListener("click", (e) => {

        const newAuthorWrapper = document.createElement("DIV");
        newAuthorWrapper.classList.add('single-author-wrap');
        newAuthorWrapper.classList.add('single-author-wrap--additional')

        newAuthorWrapper.innerHTML =
            `
         <input type="text" class="std-form-input" placeholder="Auhthor's First Name" id="input-second-author-fn">
         <input type="text" class="std-form-input" placeholder="Auhthor's Last Name" id="input-second-author-ln">
         <div class="add-author-wrapper">
         <span class="remove-icon std-icon" onclick="removeAuthor(this)"></span> <p class="std-text-quiet add-author">Remove this Author</p>
         </div>
            `;
        const parent = e.target.parentNode.parentNode;
        parent.appendChild(newAuthorWrapper)
    })
})


// ------------------------------ cite a source ----------------------------- //

const citeSource = () => {
    //---------------- general inputs
    const secondAuthorFN = document.querySelectorAll("#input-second-author-fn")
    const secondAuthorLN = document.querySelectorAll("#input-second-author-ln")


    if (isSourceTypeChosen.isIt) {

        citationWrapper.style.display = "block";

        if (isSourceTypeChosen.source === 'book' && isStyleChosen.style === "mla") {

            let FN = bookFirstAuthorLN.value != "" ? bookFirstAuthorFN.value + ". " : "";
            const LN = bookFirstAuthorFN.value != "" ? bookFirstAuthorLN.value + ", " : "";
            const title = bookTitle.value != "" ? `<i>${bookTitle.value}. </i>` : "";
            const edition = bookEdition.value != "" ? bookEdition.value + ", " : "";
            const publisher = bookOublisher.value != "" ? bookOublisher.value + ", " : "";
            const yearPub = bookYearPub.value != "" ? bookYearPub.value + "." : "";
            let secondFN = "";
            let secondLN = "";

            if (secondAuthorFN || secondAuthorLN) {

                if (secondAuthorFN.length === 1 && secondAuthorLN.length === 1) {
                    FN = bookFirstAuthorFN.value + ", "
                    secondFN = `and ${secondAuthorFN[0].value}`
                    secondLN = `, ${secondAuthorLN[0].value}.`

                } else if (secondAuthorFN.length > 1 && secondAuthorLN.length > 1) {
                    FN = bookFirstAuthorFN.value + ", "
                    secondFN = "et ";
                    secondLN = "al. "
                }
            }

            const citation = `<p class="std-p" id="citation-result-text">${LN}${FN}${secondFN}${secondLN}${title}${edition}${publisher}${yearPub}</p>`

            citationResultText.innerHTML = citation;
        }
        // journal MLA
        else if (isSourceTypeChosen.source === 'journal' && isStyleChosen.style === "mla") {
            let FN = journalFirstAuthorFN.value != "" ? journalFirstAuthorFN.value + ". " : "";
            const LN = journalFirstAuthorLN.value != "" ? journalFirstAuthorLN.value + ", " : "";
            const titleArticle = journalArticleTitle.value != "" ? `"${journalArticleTitle.value}." ` : "";
            const titleJournal = journalJournalTitle.value != "" ? `<i>${journalJournalTitle.value}, </i>` : "";
            const volume = journalVolume.value != "" ? "vol. " + journalVolume.value + ", " : "";
            const issue = journalIssueNum.value != "" ? "no. " + journalIssueNum.value + ", " : "";
            const month = journalMonthPub.value != "" ? journalMonthPub.value + " " : "";
            const year = journalYearPub.value != "" ? journalYearPub.value + ", " : "";
            const pages = journalSourcePages.value != "" ? "pp." + journalSourcePages.value + ", " : "";
            const doi = journalDoi.value != "" ? "doi:" + journalDoi.value + "." : "";
            let secondFN = "";
            let secondLN = "";

            if (secondAuthorFN || secondAuthorLN) {

                if (secondAuthorFN.length === 1 && secondAuthorLN.length === 1) {
                    FN = journalFirstAuthorFN.value + ", "
                    secondFN = `and ${secondAuthorFN[0].value}`
                    secondLN = `, ${secondAuthorLN[0].value}.`

                } else if (secondAuthorFN.length > 1 && secondAuthorLN.length > 1) {
                    FN = bookFirstAuthorFN.value + ", "
                    secondFN = "et ";
                    secondLN = "al. "
                }
            }

            const citation = `<p class="std-p" id="citation-result-text">${LN}${FN}${secondFN}${secondLN}${titleArticle}${titleJournal}${volume}${issue}${month}${month}${year}${pages}${doi}</p>`

            citationResultText.innerHTML = citation;
        }
        // website MLA
        else if (isSourceTypeChosen.source === 'website' && isStyleChosen.style === "mla") {
            let FN = websiteFirstAuthorFN.value != "" ? websiteFirstAuthorFN.value + ". " : "";
            const LN = websiteFirstAuthorLN.value != "" ? websiteFirstAuthorLN.value + ", " : "";
            const title = websitePageTitle.value != "" ? `"${websitePageTitle.value}." ` : "";
            const website = websiteWebsiteTitle.value != "" ? `<i>${websiteWebsiteTitle.value}, </i>` : "";
            const day = websiteDayPub.value != "" ? websiteDayPub.value + " " : "";
            const month = websiteMonthPub.value != "" ? websiteMonthPub.value + " " : "";
            const year = websiteYearPub.value != "" ? websiteYearPub.value + ", " : "";
            const url = websiteSourceUrl.value != "" ? "pp." + websiteSourceUrl.value + "." : "";
            let secondFN = "";
            let secondLN = "";

            if (secondAuthorFN || secondAuthorLN) {

                if (secondAuthorFN.length === 1 && secondAuthorLN.length === 1) {
                    FN = websiteFirstAuthorFN.value + ", "
                    secondFN = `and ${secondAuthorFN[0].value}`
                    secondLN = `, ${secondAuthorLN[0].value}.`

                } else if (secondAuthorFN.length > 1 && secondAuthorLN.length > 1) {
                    FN = bookFirstAuthorFN.value + ", "
                    secondFN = "et ";
                    secondLN = "al. "
                }
            }

            const citation = `<p class="std-p" id="citation-result-text">${LN}${FN}${secondFN}${secondLN}${title}${website}${day}${month}${month}${year}${url}</p>`

            citationResultText.innerHTML = citation;
        }


        // -------------------------------------------------------- APA ------------------------------------------------------ //
        // book APA
        else if (isSourceTypeChosen.source === 'book' && isStyleChosen.style === "apa") {
            let FN = bookFirstAuthorLN.value != "" ? bookFirstAuthorFN.value.charAt(0).toUpperCase() + ". " : "";
            let MN = bookFirstAuthorMN.value != "" ? bookFirstAuthorMN.value.charAt(0).toUpperCase() + ". " : "";
            let LN = bookFirstAuthorFN.value != "" ? bookFirstAuthorLN.value + ", " : "";
            const title = bookTitle.value != "" ? `<i>${bookTitle.value} </i>` : "";
            const edition = bookEdition.value != "" ? "(" + bookEdition.value + " ed.). " : "";
            const publisher = bookOublisher.value != "" ? bookOublisher.value + "." : "";
            const yearPub = bookYearPub.value != "" ? "(" + bookYearPub.value + "). " : "";
            let secondLN = "";

            if (secondAuthorFN || secondAuthorLN) {

                if (secondAuthorFN.length === 1 && secondAuthorLN.length === 1) {
                    FN = ""
                    MN = ""
                    secondLN = ` and ${secondAuthorLN[0].value}. `

                } else if (secondAuthorFN.length > 1 && secondAuthorLN.length > 1) {
                    FN = ""
                    MN = ""
                    LN = bookFirstAuthorLN.value + " ";
                    secondLN = "et al. ";
                }
            }

            const citation = `<p class="std-p" id="citation-result-text">${LN}${MN}${FN}${secondLN}${yearPub}${title}${edition}${publisher}</p>`

            citationResultText.innerHTML = citation;
        }
        // journal APA
        else if (isSourceTypeChosen.source === 'journal' && isStyleChosen.style === "apa") {
            let FN = journalFirstAuthorFN.value != "" ? journalFirstAuthorFN.value.charAt(0).toUpperCase() + ". " : "";
            let MN = journalFirstAuthorMN.value != "" ? journalFirstAuthorMN.value.charAt(0).toUpperCase() + ". " : "";
            let LN = journalFirstAuthorLN.value != "" ? journalFirstAuthorLN.value + ", " : "";
            const titleArticle = journalArticleTitle.value != "" ? `${journalArticleTitle.value}. ` : "";
            const titleJournal = journalJournalTitle.value != "" ? `<i>${journalJournalTitle.value}, </i>` : "";
            const volume = journalVolume.value != "" ? journalVolume.value : "";
            const issue = journalIssueNum.value != "" ? "(" + journalIssueNum.value + ")" : "";
            const year = journalYearPub.value != "" ? "(" + journalYearPub.value + "). " : "";
            const pages = journalSourcePages.value != "" ? journalSourcePages.value + ". " : "";
            const doi = journalDoi.value != "" ? journalDoi.value : "";
            let secondLN = "";

            if (secondAuthorFN || secondAuthorLN) {

                if (secondAuthorFN.length === 1 || secondAuthorLN.length === 1) {
                    FN = ""
                    MN = ""
                    secondLN = ` and ${secondAuthorLN[0].value}. `

                } else if (secondAuthorFN.length > 1 || secondAuthorLN.length > 1) {
                    FN = ""
                    MN = ""
                    LN = bookFirstAuthorLN.value + " ";
                    secondLN = "et al. ";
                }
            }

            const citation = `<p class="std-p" id="citation-result-text">${LN}${MN}${FN}${secondLN}${year}${titleArticle}${titleJournal}${volume}${issue}${volume || issue ? "," : ""}${pages}${doi}</p>`

            citationResultText.innerHTML = citation;
        }
        // website APA
        else if (isSourceTypeChosen.source === 'website' && isStyleChosen.style === "apa") {
            let FN = websiteFirstAuthorFN.value != "" ? websiteFirstAuthorFN.value.charAt(0).toUpperCase() + ". " : "";
            let MN = websiteFirstAuthorMN.value != "" ? websiteFirstAuthorMN.value.charAt(0).toUpperCase() + ". " : "";
            let LN = websiteFirstAuthorLN.value != "" ? websiteFirstAuthorLN.value + ", " : "";
            const title = websitePageTitle.value != "" ? `<i>${websitePageTitle.value}. </i>` : "";
            const website = websiteWebsiteTitle.value != "" ? `${websiteWebsiteTitle.value}. ` : "";
            const day = websiteDayPub.value != "" ? websiteDayPub.value : "";
            const month = websiteMonthPubAPA.value != "" ? websiteMonthPubAPA.value + " " : "";
            const year = websiteYearPub.value != "" ? websiteYearPub.value + ", " : "";
            const url = websiteSourceUrl.value != "" ? websiteSourceUrl.value : "";
            let secondLN = "";

            if (secondAuthorFN || secondAuthorLN) {

                if (secondAuthorFN.length === 1 || secondAuthorLN.length === 1) {
                    FN = ""
                    MN = ""
                    secondLN = ` and ${secondAuthorLN[0].value}. `

                } else if (secondAuthorFN.length > 1 || secondAuthorLN.length > 1) {
                    FN = ""
                    MN = ""
                    LN = websiteFirstAuthorLN.value + " ";
                    secondLN = "et al. ";
                }
            }

            const citation = `<p class="std-p" id="citation-result-text">${LN}${MN}${FN}${secondLN}${year || month || day ? "(" : ""}${year}${month}${day}${year || month || day ? ")" : ""}${title}${website}${url}</p>`
        }

        // -------------------------------------------------------- CHICAGO ------------------------------------------------------ //
        // book Chicago
        else if (isSourceTypeChosen.source === 'book' && isStyleChosen.style === "chicago") {
            let FN = bookFirstAuthorLN.value != "" ? bookFirstAuthorFN.value + ", " : "";
            let LN = bookFirstAuthorFN.value != "" ? bookFirstAuthorLN.value + " " : "";
            const title = bookTitle.value != "" ? `<i>${bookTitle.value} </i>` : "";
            const placeOfPub = bookPlaceofPublication.value != "" ? bookPlaceofPublication.value + ": " : ""
            const publisher = bookOublisher.value != "" ? bookOublisher.value + ", " : "";
            const yearPub = bookYearPub.value != "" ? bookYearPub.value : "";
            const pages = bookPagesUsed.value != "" ? bookPagesUsed.value + "." : "";

            const secondFN1 = secondAuthorFN[0] ? secondAuthorFN[0].value + " " : "";
            const secondLN1 = secondAuthorFN[0] ? secondAuthorLN[0].value + ", " : "";
            const secondFN2 = secondAuthorFN[1] ? secondAuthorFN[1].value + " " : "";
            const secondLN2 = secondAuthorFN[1] ? secondAuthorLN[1].value + ", " : "";
            const secondFN3 = secondAuthorFN[2] ? secondAuthorFN[2].value + " " : "";
            const secondLN3 = secondAuthorFN[2] ? secondAuthorLN[2].value + ", " : "";
            const secondFN4 = secondAuthorFN[3] ? secondAuthorFN[3].value + " " : "";
            const secondLN4 = secondAuthorFN[3] ? secondAuthorLN[3].value + ", " : "";


            const citation = `<p class="std-p" id="citation-result-text">${LN}${FN}${secondFN1}${secondLN1}${secondFN2}${secondLN2}${secondFN3}${secondLN3}${secondFN4}${secondLN4}${title}${placeOfPub || publisher || yearPub ? "(" : ""}${placeOfPub}${publisher}${yearPub}${placeOfPub || publisher || yearPub ? "), " : ""}${pages}</p>`

            citationResultText.innerHTML = citation;
        }
        // journal Chicago
        else if (isSourceTypeChosen.source === 'journal' && isStyleChosen.style === "chicago") {
            let FN = journalFirstAuthorFN.value != "" ? journalFirstAuthorFN.value + ", " : "";
            let LN = journalFirstAuthorLN.value != "" ? journalFirstAuthorLN.value + " " : "";
            const titleArticle = journalArticleTitle.value != "" ? `"${journalArticleTitle.value}," ` : "";
            const titleJournal = journalJournalTitle.value != "" ? `<i>${journalJournalTitle.value} </i>` : "";
            const volume = journalVolume.value != "" ? journalVolume.value + ", ": "";
            const issue = journalIssueNum.value != "" ? "no. " + journalIssueNum.value + " " : "";
            const month = journalMonthPubChi.value != "" ? journalMonthPubChi.value + " " : "";
            const year = journalYearPub.value != "" ? journalYearPub.value : "";
            const pages = journalSourcePages.value != "" ? journalSourcePages.value + ". " : "";
            const doi = journalDoi.value != "" ? journalDoi.value : "";

            const secondFN1 = secondAuthorFN[0] ? secondAuthorFN[0].value + " " : "";
            const secondLN1 = secondAuthorFN[0] ? secondAuthorLN[0].value + ", " : "";
            const secondFN2 = secondAuthorFN[1] ? secondAuthorFN[1].value + " " : "";
            const secondLN2 = secondAuthorFN[1] ? secondAuthorLN[1].value + ", " : "";
            const secondFN3 = secondAuthorFN[2] ? secondAuthorFN[2].value + " " : "";
            const secondLN3 = secondAuthorFN[2] ? secondAuthorLN[2].value + ", " : "";
            const secondFN4 = secondAuthorFN[3] ? secondAuthorFN[3].value + " " : "";
            const secondLN4 = secondAuthorFN[3] ? secondAuthorLN[3].value + ", " : "";

            const citation = `<p class="std-p" id="citation-result-text">${LN}${FN}${secondFN1}${secondLN1}${secondFN2}${secondLN2}${secondFN3}${secondLN3}${secondFN4}${secondLN4}${titleArticle}${titleJournal}${volume}${issue}${year || month ? "(" : ""}${month}${year}${year || month ? ")" : ""}${(year || month) && pages ? ": " : ""}${pages}${doi}</p>`

            citationResultText.innerHTML = citation;
        }
        // website Chicago
        else if (isSourceTypeChosen.source === 'website' && isStyleChosen.style === "chicago") {
            const title = websitePageTitle.value != "" ? `"${websitePageTitle.value}," ` : "";
            const website = websiteWebsiteTitle.value != "" ? `${websiteWebsiteTitle.value}, ` : "";
            const day = websiteDayPubChi.value != "" ? websiteDayPubChi.value + ", ": "";
            const month = websiteMonthPubChi.value != "" ? websiteMonthPubChi.value + " " : "";
            const year = websiteYearPubChi.value != "" ? websiteYearPubChi.value + ", " : "";
            const url = websiteSourceUrl.value != "" ? websiteSourceUrl.value : ".";

            const citation = `<p class="std-p" id="citation-result-text">${website}${title}accessed ${month}${day}${year}${title}${url}</p>`

            citationResultText.innerHTML = citation;
        }
    }
}

// ------------------------------ click audio ------------------------------- //
// click mp3
const audioFile2 = new Audio("/sounds/keyboard_tap.mp3");

const playAudio2 = () => {
    audioFile2.play()
}
allButtons.forEach(button => {
    button.addEventListener("click", playAudio2)
})

// ------------------------------ copy Citation ------------------------------- //
const copyCitation = () => {
    const citation = document.querySelector("#citation-result-text");

    const dummy = document.createElement('input');

    document.body.appendChild(dummy);
    dummy.value = citation.textContent;
    dummy.select();
    document.execCommand('copy');
    document.body.removeChild(dummy);

    const themeWrapper = document.createElement("DIV");
    themeWrapper.setAttribute("class", "notification-wrapper");
    themeWrapper.innerHTML = `
     <div class="theme-element"><p>Text copied to clipdoard, thank you for using this tool! ❤️</p></div>
`
    document.body.appendChild(themeWrapper);

    setInterval(() => {
        themeWrapper.remove();
    }, 4000)
}