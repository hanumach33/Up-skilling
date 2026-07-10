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

function displayEvent(event, status = "Open") {

    const { name, category, seats } = event;

    console.log(`Event: ${name}`);
    console.log(`Category: ${category}`);
    console.log(`Available Seats: ${seats}`);
    console.log(`Status: ${status}`);
    console.log("-------------------------");

}

events.forEach(event => displayEvent(event));

const clonedEvents = [...events];

const musicEvents = clonedEvents.filter(event => event.category === "Music");

console.log("Music Events");

musicEvents.forEach(event => displayEvent(event));

let totalEvents = events.length;

console.log(`Total Events: ${totalEvents}`);
