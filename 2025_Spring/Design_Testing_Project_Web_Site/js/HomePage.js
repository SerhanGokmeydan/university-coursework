const mainContainer = document.querySelector("#main-container");
const welcomeMessage = document.querySelector("#welcome-message p");

const range = 400;

mainContainer.addEventListener("scroll", () => {
    const rect = welcomeMessage.getBoundingClientRect();

    const centerY = rect.top + rect.height / 2;
    const distance = Math.abs(centerY - window.innerHeight / 2);

    let opacity = 1 - distance / range;

    if (opacity < 0) {
        opacity = 0;
    }
    if (opacity > 1) {
        opacity = 1;
    }

    welcomeMessage.style.opacity = opacity;
});

mainContainer.dispatchEvent(new Event("scroll"));
