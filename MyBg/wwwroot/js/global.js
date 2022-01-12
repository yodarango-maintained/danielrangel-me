const menuButton = document.querySelector("#menu-button");
const darkLayer = document.querySelector("#dark-layer");
const menuWrapper = document.querySelector("#menu-wrapper");

let menuOpen = false;

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
            console.log("hey");
        }, 1500)

    }

    console.log(menuOpen)

}

menuButton.addEventListener("click", handleMenuTrigger);

// ----------------------------- REDIRECT POSTS ------------------------- //

const redirectToPost = (id, postType) => {
    console.log(id, postType)
    if (postType == "Favorite") {
        window.location.href = `/favorites/${id}`
    } else if (postType == "Blog") {
        window.location.href = `/blogs/${id}`
    }

}