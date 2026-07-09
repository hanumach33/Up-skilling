const events = [
    {
        name: "Music Festival",
        category: "Music",
        seats: 50
    },
    {
        name: "Food Carnival",
        category: "Food",
        seats: 30
    },
    {
        name: "Coding Workshop",
        category: "Education",
        seats: 20
    }
];

const container = document.querySelector("#eventContainer");

function renderEvents() {

    container.innerHTML = "";

    events.forEach((event, index) => {

        const card = document.createElement("div");
        card.className = "card";

        const title = document.createElement("h2");
        title.textContent = event.name;

        const category = document.createElement("p");
        category.textContent = `Category: ${event.category}`;

        const seats = document.createElement("p");
        seats.textContent = `Seats: ${event.seats}`;

        const registerButton = document.createElement("button");
        registerButton.textContent = "Register";

        registerButton.onclick = function () {

            if (events[index].seats > 0) {
                events[index].seats--;
                renderEvents();
            }

        };

        const cancelButton = document.createElement("button");
        cancelButton.textContent = "Cancel";

        cancelButton.onclick = function () {

            events[index].seats++;
            renderEvents();

        };

        card.appendChild(title);
        card.appendChild(category);
        card.appendChild(seats);
        card.appendChild(registerButton);
        card.appendChild(cancelButton);

        container.appendChild(card);

    });

}

renderEvents();
