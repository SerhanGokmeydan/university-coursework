const leftNavBar = document.querySelector("#left-nav");

let navBool = false;

document.addEventListener("click", (e) => {
    const elm = e.target;
    if (!navBool && elm.id == "menu-btn") {
        leftNavBar.style.left = "0px";
        navBool = true;
    } else if (elm.id == "left-nav") {
        leftNavBar.style.left = "0px";
    } else {
        leftNavBar.style.left = "-100%";
        navBool = false;
    }
});
