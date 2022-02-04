// click mp3
const audioFile = new Audio("/sounds/click.mp3");

// global elements
const menuButton = document.querySelector("#menu-button");
const themeButton = document.querySelector("#theme-button");
const LinkButtons = document.querySelectorAll("#menu-bttn");
const darkLayer = document.querySelector("#dark-layer");
const menuWrapper = document.querySelector("#menu-wrapper");
const globalWraper = document.querySelector("#global-wrapper");

let menuOpen = false;


// --------------------------- Check for color theme cookie ----------------- 
function getCookie(cname) {
    let name = cname + "=";
    let decodedCookie = decodeURIComponent(document.cookie);
    let ca = decodedCookie.split(';');
    for (let i = 0; i < ca.length; i++) {
        let c = ca[i];
        while (c.charAt(0) == ' ') {
            c = c.substring(1);
        }
        if (c.indexOf(name) == 0) {
            return c.substring(name.length, c.length);
        }
    }
    return "";
}
const cookie = getCookie("color-theme");
globalWraper.setAttribute("data-theme-color", cookie);

setTimeout(() => {
    globalWraper.style.opacity = "1"
}, 500)

const handleMenuTrigger = () => {
    if (menuOpen == false) {
        menuOpen = true
        darkLayer.classList.remove("std-bkg-layer--dark--close")
        darkLayer.classList.add("std-bkg-layer--dark")

        menuWrapper.classList.remove("menu--desktop--close")
        menuWrapper.classList.add("menu--desktop--open")

        menuButton.classList.add("menu-button-desktop--trigger--open")
    }
    else if (menuOpen == true) {
        menuOpen = false
        darkLayer.classList.remove("std-bkg-layer--dark")
        darkLayer.classList.add("std-bkg-layer--dark--close")

        menuWrapper.classList.remove("menu--desktop--open")
        menuWrapper.classList.add("menu--desktop--close")

        menuButton.classList.remove("menu-button-desktop--trigger--open")

        setTimeout(() => {
            darkLayer.classList.remove("std-bkg-layer--dark--close")
            menuWrapper.classList.remove("menu--desktop--close")
        }, 1500)

    }

}

menuButton.addEventListener("click", handleMenuTrigger);

// ----------------------------- REDIRECT POSTS ------------------------- //

const redirectToPost = (id, postType) => {
    console.log(id, postType)
    if (postType == "Favorite") {
        window.location.href = `/favorites/${id}`
    } else if (postType == "Article") {
        window.location.href = `/blogs/${id}`
    }

}

 // ----------------------------- CLICK EFFECT -------------------------- //
const playAudio = () => {
    audioFile.play()
}

LinkButtons.forEach(button => button.addEventListener("click", playAudio))
menuButton.addEventListener("click", playAudio);
themeButton.addEventListener("click", playAudio);


const menuRedirect = (location) => {

    setTimeout(() => {
        window.location.href = location
    }, 500)

}

// -------------------------- CHOOSE THEME ----------------------------- //
const switchTheme = (theme) => {
    playAudio();

    globalWraper.removeAttribute("data-theme-color")
    globalWraper.setAttribute("data-theme-color", theme);

    const date = Date.now() + 604800000;
    const newDate = new Date(date);

    document.cookie = `color-theme=${theme}; expires=${newDate};  path=/`
}

let themeWrapperOpen = false;

const openThemeSelector = () => {
    if (themeWrapperOpen === false) {
        themeWrapperOpen = true;

        darkLayer.classList.remove("std-bkg-layer--dark--close")
        darkLayer.classList.add("std-bkg-layer--dark")

        themeButton.classList.add("theme-button--open")

        const themeWrapper = document.createElement("DIV");
        themeWrapper.setAttribute("class", "color-theme-wrapper color-theme-wrapper--open");
        themeWrapper.innerHTML = `
    <div class="theme-element" onclick="switchTheme('default')"><span class=""></span><p>Default</p></div>
    <div class="theme-element" onclick="switchTheme('velvetcake')"><span class="velvet-cake"></span><p>Velvet Cake</p></div>
    <div class="theme-element" onclick="switchTheme('chocolatedBananas')"><span class="chocolated-bananas"></span><p>Chocolated Bananas</p></div>
     <div class="theme-element" onclick="switchTheme('blueberryCobbler')"><span class="blueberry-cobbler"></span><p>Blueberry Cobbler</p></div>
     <div class="theme-element" onclick="switchTheme('orangeCake')"><span class="orange-cake"></span><p>Orange Cake</p></div>
     <div class="theme-element" onclick="switchTheme('blackSapodillaIcecream')"><span class="black-sapodilla-icecream"></span><p>Black Sapodilla Icecream</p></div>
     <div class="theme-element" onclick="switchTheme('soursopSorbet')"><span class="soursop-sorbet"></span><p>Soursap Sorbet</p></div>
`
        document.body.appendChild(themeWrapper);

    } else if (themeWrapperOpen === true) {
        themeWrapperOpen = false;

        const themeWrapper = document.querySelector(".color-theme-wrapper")

        darkLayer.classList.remove("std-bkg-layer--dark")
        darkLayer.classList.add("std-bkg-layer--dark--close")

        themeWrapper.classList.remove("color-theme-wrapper--open")
        themeWrapper.classList.add("color-theme-wrapper--close")

        themeButton.classList.remove("theme-button--open")

        setTimeout(() => {
            darkLayer.classList.remove("std-bkg-layer--dark--close")
            themeWrapper.remove();
        }, 1500)

    }
}