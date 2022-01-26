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

//---------------------------- choose the citation style -------------------------- //
//------- 1: MLA Style
const mlaStyle = () => {
    apaBtn.classList.remove('active');
    chicagoBtn.classList.remove('active');
    turbianBtn.classList.remove('active');

    mlaBtn.classList.add('active');
}

//------- 2: APA Style
const apaStyle = () => {
    mlaBtn.classList.remove('active');
    chicagoBtn.classList.remove('active');
    turbianBtn.classList.remove('active');

    apaBtn.classList.add('active');
}

//------- 3: Chicago Style
const chicagoStyle = () => {
    apaBtn.classList.remove('active');
    mlaBtn.classList.remove('active');
    turbianBtn.classList.remove('active');

    chicagoBtn.classList.add('active');
}

//------- 4: Turbian Style
const turbianStyle = () => {
    apaBtn.classList.remove('active');
    chicagoBtn.classList.remove('active');
    mlaBtn.classList.remove('active');

    turbianBtn.classList.add('active');
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
    MLAwebisteWrapper.style.display = 'none'
    MLAjournalWrapper.style.display = 'none'
    sourceTypeJournal.classList.remove('active')
    sourceTypeWebsite.classList.remove('active')

    MLABookWrapper.style.display = 'flex'
    sourceTypeBook.classList.add('active')
}

const journalSource = () => {
    MLAwebisteWrapper.style.display = 'none'
    MLABookWrapper.style.display = 'none'
    sourceTypeBook.classList.remove('active')
    sourceTypeWebsite.classList.remove('active')

    MLAjournalWrapper.style.display = 'flex'
    sourceTypeJournal.classList.add('active')
}

const websiteSource = () => {
    MLABookWrapper.style.display = 'none'
    MLAjournalWrapper.style.display = 'none'
    sourceTypeJournal.classList.remove('active')
    sourceTypeBook.classList.remove('active')

    MLAwebisteWrapper.style.display = 'flex'
    sourceTypeWebsite.classList.add('active')
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
         <input type="text" class="std-form-input" placeholder="Auhthor's Last Name" id="input-second-author-fn">
         <div class="add-author-wrapper">
         <span class="remove-icon std-icon" onclick="removeAuthor(this)"></span> <p class="std-text-quiet add-author">Remove this Author</p>
         </div>
            `;
        const parent = e.target.parentNode.parentNode;
        parent.appendChild(newAuthorWrapper)
    })
})


// ------------------------------ cite a source ----------------------------- //
// ---------------- book inputs 
const bookFirstAuthorFN = document.querySelector("#input-first-author-fn--book")
const bookFirstAuthorLN = document.querySelector("#input-first-author-ln--book")
const bookTitle = document.querySelector("#input-title--book")
const bookEdition = document.querySelector("#input-edition--book")
const bookOublisher = document.querySelector("#input-publisher--book")
const bookYearPub = document.querySelector("#input-yearPub--book")

// ---------------- journal inputs 
const journalFirstAuthorFN = document.querySelector("#input-first-author-fn--journal")
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

const citeSource = () => {

    if (isSourceTypeChosen.isIt) {

        citationWrapper.style.display = "block";

        if (isSourceTypeChosen.source === 'book' && isStyleChosen.style === "mla") {
            console.log(isSourceTypeChosen.source, isStyleChosen.style, bookFirstAuthorFN.value)

            const FN = bookFirstAuthorLN.value != "" ? bookFirstAuthorFN.value + ". " : "";
            const LN = bookFirstAuthorFN.value != "" ? bookFirstAuthorLN.value + ", " : "";
            const title = bookTitle.value != "" ? `<i>${bookTitle.value}. </i>` : "";
            const edition = bookEdition.value != "" ? bookEdition.value + ", ": "";
            const publisher = bookOublisher.value != "" ? bookOublisher.value + ", " : "";
            const yearPub = bookYearPub.value != "" ? bookYearPub.value + "." : "";


            const citation = `<p class="std-p" id="citation-result-text">${LN}${FN}${title}${edition}${publisher}${yearPub}</p>`

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