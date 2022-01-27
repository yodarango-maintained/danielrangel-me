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
const bookYearPub = document.querySelector("#input-yearPub--book")

// ---------------- journal inputs 
const journalFirstAuthorFN = document.querySelector("#input-first-author-fn--journal")
const journalFirstAuthorMN = document.querySelector("#input-first-author-mn--journal")
const journalFirstAuthorLN = document.querySelector("#input-first-author-ln--journal")
const journalArticleTitle = document.querySelector("#input-source-art-title--journal")
const journalJournalTitle = document.querySelector("#input-source-jour-title--journal")
const journalVolume = document.querySelector("#input-source-volume--journal")
const journalIssueNum = document.querySelector("#input-source-issueNum-journal")
const journalMonthPub = document.querySelector("#input-source-monthPub--journal")
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
const websiteYearPub = document.querySelector("#input-yearPub--website")
const websiteSourceUrl = document.querySelector("#input-sourceUrl--website")


//------------ wrapper
const citationWrapper = document.querySelector(".reading-result-wrapper");
const citationResultText = document.querySelector("#citation-time-result");

//---------------------------- choose the citation style -------------------------- //
//------- 1: MLA Style
const mlaStyle = () => {
    apaBtn.classList.remove('active');
    chicagoBtn.classList.remove('active');
    turbianBtn.classList.remove('active');

    mlaBtn.classList.add('active');

    journalMonthPub.style.display = "block";

    bookFirstAuthorMN.style.display = "none"
    journalFirstAuthorMN.style.display = "none"
    websiteFirstAuthorMN.style.display = "none"
}

//------- 2: APA Style
const apaStyle = () => {
    mlaBtn.classList.remove('active');
    chicagoBtn.classList.remove('active');
    turbianBtn.classList.remove('active');

    apaBtn.classList.add('active');

    journalMonthPub.style.display = "none";

    bookFirstAuthorMN.style.display = "block"
    journalFirstAuthorMN.style.display = "block"
    websiteFirstAuthorMN.style.display = "block"
}

//------- 3: Chicago Style
const chicagoStyle = () => {
    apaBtn.classList.remove('active');
    mlaBtn.classList.remove('active');
    turbianBtn.classList.remove('active');

    chicagoBtn.classList.add('active');

    journalMonthPub.style.display = "none";

    bookFirstAuthorMN.style.display = "none"
    journalFirstAuthorMN.style.display = "none"
    websiteFirstAuthorMN.style.display = "none"
}

//------- 4: Turbian Style
const turbianStyle = () => {
    apaBtn.classList.remove('active');
    chicagoBtn.classList.remove('active');
    mlaBtn.classList.remove('active');

    turbianBtn.classList.add('active');

    journalMonthPub.style.display = "none";

    bookFirstAuthorMN.style.display = "none"
    journalFirstAuthorMN.style.display = "none"
    websiteFirstAuthorMN.style.display = "none"
}

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

    if (style === 'turbian') {
        turbianStyle()

        isStyleChosen.isIt = true
        isStyleChosen.style = "turbian"
    }
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

    if (isSourceTypeChosen.isIt) {

        citationWrapper.style.display = "block";

        //---------------- general inputs
        const secondAuthorFN = document.querySelectorAll("#input-second-author-fn")
        const secondAuthorLN = document.querySelectorAll("#input-second-author-ln")

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
        // book APA
        else if (isSourceTypeChosen.source === 'book' && isStyleChosen.style === "apa") {
            let FN = bookFirstAuthorLN.value != "" ? bookFirstAuthorFN.value.charAt(0).toUpperCase() + ". " : "";
            let MN = bookFirstAuthorMN.value != "" ? bookFirstAuthorMN.value.charAt(0).toUpperCase() + ". " : "";
            let LN = bookFirstAuthorFN.value != "" ? bookFirstAuthorLN.value + ", " : "";
            const title = bookTitle.value != "" ? `<i>${bookTitle.value} </i>` : "";
            const edition = bookEdition.value != "" ? "(" +  bookEdition.value + " ed.). " : "";
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
                    LN = bookFirstAuthorFN.value + " ";
                    secondLN = "et al. ";
                }
            }

            const citation = `<p class="std-p" id="citation-result-text">${LN}${MN}${FN}${secondLN}${yearPub}${title}${edition}${publisher}</p>`

            citationResultText.innerHTML = citation;
        }
        // journal APA
        else if (isSourceTypeChosen.source === 'journal' && isStyleChosen.style === "apa") {
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
        // website APA
        else if (isSourceTypeChosen.source === 'website' && isStyleChosen.style === "apa") {
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