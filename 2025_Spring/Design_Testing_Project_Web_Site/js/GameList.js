const filterContainer = document.querySelector("#filter-container");
const filterList = document.querySelectorAll(".filter ul");

filterContainer.addEventListener("click", (e) => {
    const elm = e.target;
    if (elm.tagName === "P" && elm.id) {
        if (!elm.classList.contains("p-active")) {
            switch (elm.id) {
                case "console":
                    filterList[0].style.display = "block";
                    break;
                case "year":
                    filterList[1].style.display = "block";
                    break;
                case "rate":
                    filterList[2].style.display = "block";
                    break;
            }
            elm.classList.add("p-active");
        } else {
            switch (elm.id) {
                case "console":
                    filterList[0].style.display = "none";
                    break;
                case "year":
                    filterList[1].style.display = "none";
                    break;
                case "rate":
                    filterList[2].style.display = "none";
                    break;
            }
            elm.classList.remove("p-active");
        }
    }
});

const searchInput = document.querySelector("#filter-search");
const checkBoxes = document.querySelectorAll("input[type='checkbox']");
const criticCards = document.querySelectorAll(".critic-card");

const filter = () => {
    const search = searchInput.value.toLowerCase().trim();
    const selectedConsoles = Array.from(
        document.querySelectorAll("#filter-console input:checked"),
    ).map((cb) => cb.value);

    const selectedYears = Array.from(
        document.querySelectorAll("#filter-year input:checked"),
    ).map((cb) => cb.value);

    const selectedRate = Array.from(
        document.querySelectorAll("#filter-rate input:checked"),
    ).map((cb) => cb.value);

    criticCards.forEach((card) => {
        const title = card.querySelector("h2").textContent.toLowerCase();
        const console = card.getAttribute("data-console");
        const year = card.getAttribute("data-year");
        const rate = card.getAttribute("data-rate");

        const matchesSearch = title.includes(search);
        const matchesConsole =
            selectedConsoles.includes(console) || selectedConsoles.length == 0;
        const matchesYears =
            selectedYears.includes(year) || selectedYears.length == 0;
        const matchesRate =
            selectedRate.includes(rate) || selectedRate.length == 0;

        if (matchesConsole && matchesYears && matchesRate && matchesSearch) {
            card.style.display = "block";
        } else {
            card.style.display = "none";
        }
    });
};

searchInput.addEventListener("input", filter);

checkBoxes.forEach((checkbox) => {
    checkbox.addEventListener("change", filter);
});
