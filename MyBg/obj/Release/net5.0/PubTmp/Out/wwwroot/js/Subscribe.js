const subscribeButton = document.querySelector("#subscribe-button");
const notificationWrapper = document.querySelector("#menu-wrapper");

const closeForm = () => {
    const subscribeForm = document.querySelector("#subs-form");
        subscribeForm.remove()

    darkLayer.classList.remove("std-bkg-layer--dark")
    darkLayer.classList.add("std-bkg-layer--dark--close")


    setTimeout(() => {
        darkLayer.classList.remove("std-bkg-layer--dark--close")
        menuWrapper.classList.remove("menu--desktop--close")
    }, 1500)
}

const sendingEmailNotification = () => {
    const submitButton = document.querySelector("#subscribe-submit-button");
    const closeButton = document.querySelector("#subscribe-close-button");
    const notificationP = document.querySelector("#sending-email-p")

    submitButton.style.display = "none";
    closeButton.style.display = "none";
    notificationP.style.display = "block";
    notificationP.textContent = "Adding you to the Database, please do not leave this page..."


}

const handleSubscribe = () => {
    darkLayer.classList.remove("std-bkg-layer--dark--close")
    darkLayer.classList.add("std-bkg-layer--dark")

    const subscribeForm = document.createElement("FORM");
    subscribeForm.setAttribute("class", "form-subs-wrapper--open form-subs-wrapper");
    subscribeForm.setAttribute("id", "subs-form");
    subscribeForm.setAttribute("action", "/Home/Subscribe");

    subscribeForm.innerHTML = `
<h3 class="std-h3 subscribe-h3">THANK YOU FOR FOLLOWING</h3>
<p class="std-p subscriber-p">Once following you will get email notifiations every time new goodies come out 🍫🍬</p>
<input type="text" required max-length="80" placeholder="Name" class="std-form-input input-subscribe" name="Follower_Name"/>
<input type="email" required max-length="150"placeholder="Email" class="std-form-input input-subscribe" name="Email"/>
<p class="sending-email-p std-p" id="sending-email-p"></p>
<button type="submit" class="std-button submit-button" onclick="sendingEmailNotification()" id="subscribe-submit-button">Submit</button>
<button type="submit" class="std-button close-button" onclick="closeForm()" id="subscribe-close-button">Close</button>
`
    document.body.appendChild(subscribeForm);
}

const closeNotification = () => {
    notificationWrapper.remove();
}