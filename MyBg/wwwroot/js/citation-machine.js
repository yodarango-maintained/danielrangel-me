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

const chooseCitationStyle =(style) => {

    if (style === 'mla') {
        mlaStyle()
    }

    if (style === 'apa') {
        apaStyle()
    }

    if (style === 'chicago') {
        chicagoStyle()
    }

    if (style === 'turbian') {
        turbianStyle()
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

const SelectSourceType = (style) => {

    if (style === 'book') {
        bookSource()
    }

    if (style === 'journal') {
        journalSource()
    }

    if (style === 'website') {
        websiteSource()
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
         <input type="text" class="std-form-input" placeholder="Auhthor's First Name">
         <input type="text" class="std-form-input" placeholder="Auhthor's Last Name">
         <div class="add-author-wrapper">
         <span class="remove-icon std-icon" onclick="removeAuthor(this)"></span> <p class="std-text-quiet add-author">Remove this Author</p>
         </div>
            `;
        const parent = e.target.parentNode.parentNode;
        parent.appendChild(newAuthorWrapper)
    })
})

// ------------------------------ click audio ------------------------------- //
// click mp3
const audioFile2 = new Audio("/sounds/keyboard_tap.mp3");

const playAudio2 = () => {
    audioFile2.play()
}
allButtons.forEach(button => {
    button.addEventListener("click", playAudio2)
})