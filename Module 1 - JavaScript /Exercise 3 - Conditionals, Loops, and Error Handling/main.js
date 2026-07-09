const events = [
    {
        name: "Music Festival",
        date: "2026-07-20",
        seats: 50
    },
    {
        name: "Food Carnival",
        date: "2025-06-15",
        seats: 30
    },
    {
        name: "Tree Plantation",
        date: "2026-08-10",
        seats: 0
    },
    {
        name: "Coding Workshop",
        date: "2026-09-05",
        seats: 25
    }
];

const today = new Date();

events.forEach(event => {
    const eventDate = new Date(event.date);

    if (eventDate >= today && event.seats > 0) {
        console.log(`${event.name} is available with ${event.seats} seats.`);
    } else {
        console.log(`${event.name} is unavailable.`);
    }
});

function register(event) {
    try {
        if (event.seats <= 0) {
            throw new Error("Registration failed. No seats available.");
        }

        event.seats--;

        console.log(`Successfully registered for ${event.name}.`);
        console.log(`Remaining Seats: ${event.seats}`);
    } catch (error) {
        console.error(error.message);
    }
}

register(events[0]);
register(events[2]);
