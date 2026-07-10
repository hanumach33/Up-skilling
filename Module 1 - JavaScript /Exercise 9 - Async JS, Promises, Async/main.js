const loading = document.getElementById("loading");
const eventsContainer = document.getElementById("events");

fetch("https://jsonplaceholder.typicode.com/posts?_limit=5")
    .then(response => response.json())
    .then(data => {
        loading.style.display = "none";

        data.forEach(event => {

            const card = document.createElement("div");
            card.className = "card";

            card.innerHTML = `
                <h3>${event.title}</h3>
                <p>${event.body}</p>
            `;

            eventsContainer.appendChild(card);

        });

    })
    .catch(error => {
        loading.innerHTML = "Failed to load events.";
        console.error(error);
    });

async function loadEvents() {

    try {

        loading.style.display = "block";
        eventsContainer.innerHTML = "";

        const response = await fetch("https://jsonplaceholder.typicode.com/posts?_limit=5");

        const data = await response.json();

        loading.style.display = "none";

        data.forEach(event => {

            const card = document.createElement("div");
            card.className = "card";

            card.innerHTML = `
                <h3>${event.title}</h3>
                <p>${event.body}</p>
            `;

            eventsContainer.appendChild(card);

        });

    }
    catch (error) {

        loading.innerHTML = "Failed to load events.";
        console.error(error);

    }

}

setTimeout(loadEvents, 5000);
