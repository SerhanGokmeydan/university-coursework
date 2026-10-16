const sliderContainer = document.querySelector("#slider-container");

const currentTop = parseInt(getComputedStyle(sliderContainer).paddingTop, 10) || 0;

mainContainer.addEventListener("scroll", () => {
    const nextTop = Math.max(0, currentTop - mainContainer.scrollTop / 1.5);
    sliderContainer.style.paddingTop = nextTop + "px";
});
