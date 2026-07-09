const events = [
    {
        name: "Music Festival",
        category: "Music"
    },
    {
        name: "Food Carnival",
        category: "Food"
    },
    {
        name: "Coding Workshop",
        category: "Education"
    },
    {
        name: "Live Concert",
        category: "Music"
    }
];

const container = document.getElementById("eventContainer");
const searchBox = document.getElementById("searchBox");
const categoryFilter = document.getElementById("categoryFilter");

function displayEvents(eventList) {

    container.innerHTML = "";

    eventList.forEach(event => {

        const card = document.createElement("div");
        card.className = "card";

        card.innerHTML = `
            <h2>${event.name}</h2>
            <p>${event.category}</p>
        `;

        const button = document.createElement("button");
        button.textContent = "Register";

        button.onclick = function () {
            alert(`Registered for ${event.name}`);
        };

        card.appendChild(button);

        container.appendChild(card);

    });

}

categoryFilter.onchange = function () {

    const category = this.value;

    if (category === "All") {
        displayEvents(events);
        return;
    }

    const filteredEvents = events.filter(event => event.category === category);

    displayEvents(filteredEvents);

};

searchBox.onkeydown = function () {

    const keyword = this.value.toLowerCase();

    const filteredEvents = events.filter(event =>
        event.name.toLowerCase().includes(keyword)
    );

    displayEvents(filteredEvents);

};

displayEvents(events);
