 https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification




// here is jquery to make the guitars picturs look bigger

$("#guitar1").hover(makeBigger, returnToOriginalSize);

function makeBigger() {
    $(this).css({ height: "+=10%", width: "+=10%" });
}
function returnToOriginalSize() {
    $(this).css({ height: "", width: "" });
}
$("#guitar2").hover(makeBigger, returnToOriginalSize);

function makeBigger() {
    $(this).css({ height: "+=10%", width: "+=10%" });
}
function returnToOriginalSize() {
    $(this).css({ height: "", width: "" });
}

$("#guitar3").hover(makeBigger, returnToOriginalSize);

function makeBigger() {
    $(this).css({ height: "+=10%", width: "+=10%" });
}
function returnToOriginalSize() {
    $(this).css({ height: "", width: "" });
}

// this function to scroll down to a specfic anchor tag
document.querySelectorAll('a[href^="#"]').forEach((anchor) => {
    anchor.addEventListener("click", function (e) {
        e.preventDefault();

        document.querySelector(this.getAttribute("href")).scrollIntoView({
            behavior: "smooth",
        });
    });
});

var modal = document.getElementById("id01");

// When the user clicks anywhere outside the log-in window, it will be cloesd down
window.onclick = function (event) {
    if (event.target == modal) {
        modal.style.display = "none";
    }
};

// this function to greet the user when the user fill up the contact form
function thanks(fullName) {
    document.write("Thanks for keeping in touch with me <br>" + fullName);
}

