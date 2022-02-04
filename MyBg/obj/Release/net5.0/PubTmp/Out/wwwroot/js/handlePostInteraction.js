const loveBtn = document.querySelector("#love-button");
const shareBtn = document.querySelector("#share-button")

function getLikeCookie(cname) {
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

const artcookie = getLikeCookie("liked-Blogs");
const favcookie = getLikeCookie("liked-Favorites");
const post = document.querySelector('#post-wrapper');

if (artcookie && post.dataset.route == 'article') {
    console.log(artcookie);
    artcookie == post.dataset.id ? loveBtn.style.pointerEvents = "none" : null;
} else if (favcookie && post.dataset.route == 'favorite') {
    favcookie == post.dataset.id ? loveBtn.style.pointerEvents = "none" : null;
}

// --------------------- handle the posting -------------------------- //

const handleLike = async (id, post, likes) => {

    loveBtn.innerHTML = `<span class="love-btn"></span>${likes + 1}`;
    loveBtn.style.pointerEvents = "none";

    const date = Date.now() + 604800000;
    const newDate = new Date(date);

    document.cookie = `liked-${post}=${id}; expires=${newDate};  path=/`

    const body = {
        id,
        likes: likes + 1,
        post
    }
    await fetch('/posts/likepost',
        {
            method: "POST",
            headers: {
                "Content-Type": "application/json"
            },
            body: JSON.stringify(body)

        })
}

// --------------------------- POST SHARE --------------------------//
const handleShare = async (id, post, shares) => {
    shareBtn.innerHTML = `<span class="share-btn"></span>${shares + 1}`;

    const dummy = document.createElement('input'),
        text = window.location.href;

    document.body.appendChild(dummy);
    dummy.value = text;
    dummy.select();
    document.execCommand('copy');
    document.body.removeChild(dummy);

    const themeWrapper = document.createElement("DIV");
    themeWrapper.setAttribute("class", "notification-wrapper");
    themeWrapper.innerHTML = `
     <div class="theme-element"><p>Link copied to clipdoard, thank you for sharing! ❤️</p></div>
`
    document.body.appendChild(themeWrapper);

    setInterval(() => {
        themeWrapper.remove();
    }, 4000)

    const body = {
        id,
        shares: shares + 1,
        post
    }

    await fetch('/posts/sharepost',
        {
            method: "POST",
            headers: {
                "Content-Type": "application/json"
            },
            body: JSON.stringify(body)

        })
}